using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class AppointmentForm : Form
    {
        private AppointmentsController appointmentsController;
        private PatientsController patientsController;
        private List<Appointment> appointmentList;
        private Person patient;
        public int patientID;
        
        public AppointmentForm()
        {
            InitializeComponent();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            fillPatientInformation();
            fillAppointmentInformation();
            switch (appointmentList.Count)
            {
                case 0:
                    messageLabel.Text = "No appointments found.";
                    break;
                case 1:
                    messageLabel.Text = "One appointment found.";
                    break;
                default:
                    messageLabel.Text = appointmentDataGridView.RowCount + " appointments found.";
                    break;
            }
        }


        ///////////////////////////////////////////////////////////////
        /////////////////////// Actions/Buttons ///////////////////////
        ///////////////////////////////////////////////////////////////

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers ///////////////////////
        ///////////////////////////////////////////////////////////////

        // Fills our patient info into the form
        private void fillPatientInformation()
        {
            patient = patientsController.GetPatientByID(patientID);
            firstNameTextBox.Text   = patient.firstName;
            lastNameTextBox.Text    = patient.lastName;
            phoneNumberTextBox.Text = patient.phoneNumber;
            cityTextBox.Text        = patient.city;
            stateTextBox.Text       = patient.state;
            zipTextBox.Text         = patient.zip;
        }

        // Loads our DataGridView with appointment information
        private void fillAppointmentInformation()
        {
            try
            {
                appointmentList = appointmentsController.GetAppointmentsByPatient(patientID);
                appointmentDataGridView.DataSource = appointmentList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }
}
