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
        private VitalsController vitalsController;
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
            vitalsController = new VitalsController();
            nursesController = new NursesController();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
        }

        private void CheckUpForm_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            fillAppointmentDoctorPatientInformation();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Vitals Actions/Helpers ///////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills all of the vitals informationo into the table if exists
        private void fillVitals()
        {
            appointmentVitals = vitalsController.GetAppointmentVitals(appointmentDate, doctorID, patientID);

            if (appointmentVitals != null)
            {
                nursesComboBox.SelectedIndex =
                        nursesComboBox.FindString(appointmentVitals.nurseFullName.ToString());
                systolicTextBox.Text = appointmentVitals.systolic;
                diastolicTextBox.Text = appointmentVitals.diastolic;
                temperatureTextBox.Text = appointmentVitals.temperature;
                pulseTextBox.Text = appointmentVitals.pulse;
                symptomsTextBox.Text = appointmentVitals.symptoms;
                diagnosisTextBox.Text = appointmentVitals.diagnosis;

                disableVitalsFieldsAndButtons();
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

        // Adds vitals to our database
        private void addVitalsButton_Click(object sender, EventArgs e)
        {
            if (vitalsAreValid())
            {
                try
                {
                    Appointment appointmentVitals = new Appointment();
                    appointmentVitals = putAppointmentVitals(appointmentVitals);
                    if (vitalsController.AddVitals(appointmentVitals))
                    {
                        messageLabel.Text = "Vitals successfully added.";
                        disableVitalsFieldsAndButtons();
                    }
                    else
                        messageLabel.Text = "Unable to add vitals to database. Please try again.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }



        // Puts vitals into an appointment 
        private Appointment putAppointmentVitals(Appointment appointmentVitals)
        {
            appointmentVitals.date = appointmentDate;
            appointmentVitals.doctorID = doctorID;
            appointmentVitals.patientID = patientID;
            appointmentVitals.nurseID = (int)nursesComboBox.SelectedValue;
            appointmentVitals.systolic = systolicTextBox.Text;
            appointmentVitals.diastolic = diastolicTextBox.Text;
            appointmentVitals.temperature = temperatureTextBox.Text;
            appointmentVitals.pulse = pulseTextBox.Text;
            appointmentVitals.symptoms = symptomsTextBox.Text;
            appointmentVitals.diagnosis = diagnosisTextBox.Text;
            return appointmentVitals;
        }

        // Disables all vitals fields or sets to read only 
        private void disableVitalsFieldsAndButtons()
        {
            nursesComboBox.Enabled = false;
            systolicTextBox.ReadOnly = true;
            diastolicTextBox.ReadOnly = true;
            temperatureTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            symptomsTextBox.ReadOnly = true;
            diagnosisTextBox.ReadOnly = true;

            clearVitalsButton.Enabled = false;
            addVitalsButton.Enabled = false;
        }

        // Checks if vitals are vaild
        private bool vitalsAreValid()
        {
            if (nursesComboBox.SelectedIndex != -1 &&
                !String.IsNullOrEmpty(systolicTextBox.Text) && isInt32(systolicTextBox) &&
                !String.IsNullOrEmpty(diastolicTextBox.Text) && isInt32(diastolicTextBox) &&
                !String.IsNullOrEmpty(temperatureTextBox.Text) && isInt32(temperatureTextBox) &&
                !String.IsNullOrEmpty(pulseTextBox.Text) && isInt32(temperatureTextBox) &&
                !String.IsNullOrEmpty(symptomsTextBox.Text) &&
                !String.IsNullOrEmpty(diagnosisTextBox.Text))
                return true;
            else
            {
                messageLabel.Text = "Invalid input. Please try again.";
                return false;
            }
        }

        private bool isInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch(FormatException ex)
            {
                textBox.Focus();
                return false;
            }
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
