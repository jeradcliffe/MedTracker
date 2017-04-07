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
        private TestsController testsController;
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
            testsController = new TestsController();
            vitalsController = new VitalsController();
            nursesController = new NursesController();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
        }

        private void CheckUpForm_Load(object sender, EventArgs e)
        {
            fillForm();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Vitals Actions/Helpers ///////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills all of the vitals informationo into the table if exists
        private void fillVitalFields()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
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
                    Appointment appointmentVitals = putAppointmentVitals(new Appointment());
                    if (vitalsController.AddVitals(appointmentVitals))
                    {
                        vitalsMessageLabel.Text = "Vitals successfully added.";
                        disableVitalsFieldsAndButtons();
                    }
                    else
                        vitalsMessageLabel.Text = "Unable to add vitals to database. Please try again.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // Checks if vitals are vaild
        private bool vitalsAreValid()
        {
            if (nursesComboBox.SelectedIndex != -1 &&
                stringExists(systolicTextBox) && isInt32(systolicTextBox) &&
                stringExists(diastolicTextBox) && isInt32(diastolicTextBox) &&
                stringExists(temperatureTextBox) && isInt32(temperatureTextBox) &&
                stringExists(pulseTextBox) && isInt32(temperatureTextBox) &&
                stringExists(symptomsTextBox) &&
                stringExists(diagnosisTextBox))
                return true;
            else
            {
                vitalsMessageLabel.Text = "Invalid input. Please try again.";
                return false;
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Tests Private Helpers ////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void fillTestFields()
        {
            try
            {
                appointmentTests                   = testsController.GetAppointmentTests(appointmentDate, doctorID, patientID);
                testsDataGridView.DataSource = appointmentTests;
                testDateDateTimePicker.Value       = appointmentDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Clears test info and sets time to original apt date
        private void clearTestsButton_Click(object sender, EventArgs e)
        {
            testComboBox.SelectedIndex   = -1;
            testDateDateTimePicker.Value = appointmentDate;
            resultsTextBox.Text          = "";
        }

        // Adds new test to order
        private void orderTestButton_Click(object sender, EventArgs e)
        {
            if (testIsValid())
            {
                try
                {
                    Appointment test = putTest(new Appointment());
                    if (testsController.AddTest(test))
                    {
                        testsMessageLabel.Text = "Test successfully added.";
                        fillTestFields();
                    }
                    else
                        testsMessageLabel.Text = "Unable to add test to database. Please try again.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // Check of test data is valid
        private bool testIsValid()
        {
            if (testComboBox.SelectedIndex != -1 &&
                isDateValid(testDateDateTimePicker) &&
                stringExists(resultsTextBox) &&
                stringExists(resultsTextBox))
                return true;
            else
            {
                testsMessageLabel.Text = "Invalid input. Please try again.";
                return false;
            }
        }

        // Puts test info into object 
        private Appointment putTest(Appointment test)
        {
            test.date      = appointmentDate;
            test.doctorID  = doctorID;
            test.patientID = patientID;
            test.testCode  = testComboBox.SelectedValue.ToString();
            test.testDate  = testDateDateTimePicker.Value;
            test.results   = resultsTextBox.Text;
            return test;
        }



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

                List<Appointment> tests = testsController.GetTests();
                testComboBox.DataSource = tests;
                testComboBox.DisplayMember = "testName";
                testComboBox.ValueMember = "testCode";
                testComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Fills our patient info into the form
        private void fillForm()
        {
            fillVitalFields();
            fillTestFields();
            fillComboBoxes();

            appointmentDateTextBox.Text = appointmentDate.ToString("ddd MMM d, yyyy");
            Person patient              = patientsController.GetPatientByID(patientID);
            patientNameTextBox.Text     = patient.firstName + " " + patient.lastName;
            Person doctor               = doctorsController.GetDoctorByID(doctorID);
            doctorNameTextBox.Text      = doctor.firstName + " " + doctor.lastName;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Form Validators //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool stringExists(TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
                return true;
            else
            {
                textBox.Focus();
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
            catch (FormatException ex)
            {
                textBox.Focus();
                return false;
            }
        }

        private bool isDateValid(DateTimePicker date)
        {
            if (date.Value >= appointmentDate)
                return true;
            else
            {
                date.Focus();
                return false;
            }
        }


    }
}
