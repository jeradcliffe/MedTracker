using System;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            startDateTimePicker.MaxDate = DateTime.Today;
            endDateTimePicker.MaxDate   = DateTime.Today;
        }

        private void runReportButton_Click(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value.Date > endDateTimePicker.Value.Date)
            {
                MessageBox.Show("Start Date cannot come after End Date", "Invalid Date Range");
            }
            else
            {
                try
                {
                    //fill with report from dataset
                    this.usp_mostPerformedTestsDuringDatesTableAdapter.Fill(
                        this._CS6232_g3DataSet.usp_mostPerformedTestsDuringDates,
                        startDateTimePicker.Value, endDateTimePicker.Value);
                    reportViewer.RefreshReport();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error: Unable to retrieve report information.","Error");
                }
            }
        }
    }
}
