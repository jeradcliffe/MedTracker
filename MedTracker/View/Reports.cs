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

            reportViewer.RefreshReport();
        }

        private void runReportButton_Click(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value.Date > endDateTimePicker.Value.Date)
            {
                MessageBox.Show("Start Date cannot come after End Date", "Invalid Date Range");
            }
            else
            {
                //fill with report from dataset
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateTime.Today;
            endDateTimePicker.Value   = DateTime.Today;
            reportViewer.Reset();
        }
    }
}
