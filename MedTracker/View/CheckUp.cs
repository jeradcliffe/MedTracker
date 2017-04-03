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
    public partial class CheckUpForm : Form
    {
        private AppointmentsController appointmentsController;
        private PatientsController patientsController;
        private DoctorsController doctorsController;
        private NursesController nursesController;
        //private Person patient;
        public int patientID;
        //private Person doctor;
        public int doctorID;
        private List<Appointment> appointmentTests;
        private Appointment appointmentVitals;
        public DateTime appointmentDate;

        public CheckUpForm()
        {
            InitializeComponent();
            nursesController = new NursesController();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
            addVitalsButton.Enabled = false;
        }

        private void CheckUpForm_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            fillAppointmentDoctorPatientInformation();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Vitals Private Helpers ///////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills all of the vitals informationo into the table if exists
        private void fillVitals()
        {
            appointmentVitals = appointmentsController.GetAppointmentVitals(appointmentDate, doctorID, patientID);

            if (appointmentVitals != null)
            {
                // set attending nurse
                // List<Person> nurses = nursesController.GetNurses();
                nursesComboBox.SelectedIndex =
                        nursesComboBox.FindString(appointmentVitals.nurseFullName.ToString());
                systolicTextBox.Text = appointmentVitals.systolic;
                diastolicTextBox.Text = appointmentVitals.diastolic;
                temperatureTextBox.Text = appointmentVitals.temperature;
                pulseTextBox.Text = appointmentVitals.pulse;
                symptomsTextBox.Text = appointmentVitals.symptoms;
                diagnosisTextBox.Text = appointmentVitals.diagnosis;

                nursesComboBox.Enabled = false;
                systolicTextBox.ReadOnly = true;
                diastolicTextBox.ReadOnly = true;
                temperatureTextBox.ReadOnly = true;
                pulseTextBox.ReadOnly = true;
                symptomsTextBox.ReadOnly = true;
                diagnosisTextBox.ReadOnly = true;

                clearVitalsButton.Enabled = false;
            }
            else
            {
                nursesComboBox.SelectedIndex = -1;

                addVitalsButton.Enabled = true;
                clearVitalsButton.Enabled = true;
            }
                
        }

        // Clears our vitals fields if necessary
        private void clearVitalsButton_Click(object sender, EventArgs e)
        {
            nursesComboBox.SelectedIndex = -1;
            systolicTextBox.Text = "";
            diastolicTextBox.Text = "";
            temperatureTextBox.Text = "";
            pulseTextBox.Text = "";
            symptomsTextBox.Text = "";
            diagnosisTextBox.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Tests Private Helpers ////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Other Private Helpers ////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills info into our nurses combobox
        private void fillComboBoxes()
        {
            try
            {
                List<Person> nurses = nursesController.GetNurseList();
                nursesComboBox.DataSource = nurses;
                nursesComboBox.DisplayMember = "fullName";
                nursesComboBox.ValueMember = "nurseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Fills our patient info into the form
        private void fillAppointmentDoctorPatientInformation()
        {
            appointmentTests = appointmentsController.GetAppointmentTests(appointmentDate, doctorID, patientID);
            fillVitals();

            appointmentDateTextBox.Text = appointmentDate.ToString("ddd MMM d, yyyy");

            Person patient = patientsController.GetPatientByID(patientID);
            patientNameTextBox.Text = patient.firstName + " " + patient.lastName;

            Person doctor = doctorsController.GetDoctorByID(doctorID);
            doctorNameTextBox.Text = doctor.firstName + " " + doctor.lastName;
        }
    }
}
