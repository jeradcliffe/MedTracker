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

        private List<Appointment> appointmentTests;
        private Appointment appointmentVitals;
        public DateTime appointmentDate;
        private bool vitalsPresent;
        public int patientID;
        public int doctorID;


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

        // Adds vitals to our database
        private void addVitalsButton_Click(object sender, EventArgs e)
        {
            if (vitalsAreValid())
            {
                DialogResult result 
                    = MessageBox.Show("Are you sure you would like to add vitals? "
                    + "Once you enter them you may not edit them in the future.", 
                    "Add Vitals?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Appointment vitals = putAppointmentVitals();
                        if (vitalsController.AddVitals(vitals))
                        {
                            vitalsMessageLabel.Text = "Vitals successfully added.";
                            toggleVitalsFieldsAndButtons(true);
                            this.appointmentVitals = vitals;
                            this.vitalsPresent = true;
                        }
                        else
                        {
                            vitalsMessageLabel.Text = "Unable to add vitals to database. Please try again.";
                            fillVitalFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    } 
                }
            }
        }

        // Updates the diagnosis for our vitals
        private void updateVitalsButton_Click(object sender, EventArgs e)
        {
            if (vitalsAreValid())
            {
                try
                {
                    if (vitalsController.UpdateVitalsDiagnosis(this.appointmentVitals, diagnosisTextBox.Text))
                        vitalsMessageLabel.Text = "Vitals successfully added.";
                    else
                    {
                        vitalsMessageLabel.Text = "Unable to update diagnosis in database. Please try again.";
                        fillVitalFields();
                    }
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
                isNotNullorEmpty(systolicTextBox) && isInt32(systolicTextBox) &&
                isNotNullorEmpty(diastolicTextBox) && isInt32(diastolicTextBox) &&
                isNotNullorEmpty(temperatureTextBox) && isInt32(temperatureTextBox) &&
                isNotNullorEmpty(pulseTextBox) && isInt32(temperatureTextBox) &&
                isNotNullorEmpty(symptomsTextBox) && !isInt32(symptomsTextBox) &&
                isNotNullorEmpty(diagnosisTextBox) && !isInt32(diagnosisTextBox))
                return true;
            else
            {
                vitalsMessageLabel.Text = "Invalid input. Please try again.";
                return false;
            }
        }

        // Puts vitals into an appointment 
        private Appointment putAppointmentVitals()
        {
            Appointment vitals  = new Appointment();
            vitals.date         = this.appointmentDate;
            vitals.doctorID     = this.doctorID;
            vitals.patientID    = this.patientID;
            vitals.nurseID      = (int)nursesComboBox.SelectedValue;
            vitals.systolic     = systolicTextBox.Text;
            vitals.diastolic    = diastolicTextBox.Text;
            vitals.temperature  = temperatureTextBox.Text;
            vitals.pulse        = pulseTextBox.Text;
            vitals.symptoms     = symptomsTextBox.Text;
            vitals.diagnosis    = diagnosisTextBox.Text;
            return vitals;
        }

        // Disables all vitals fields or sets to read only 
        private void toggleVitalsFieldsAndButtons(bool addNotUpdate)
        {
            // Vitals not yet added
            systolicTextBox.ReadOnly    = addNotUpdate;
            diastolicTextBox.ReadOnly   = addNotUpdate;
            temperatureTextBox.ReadOnly = addNotUpdate;
            pulseTextBox.ReadOnly       = addNotUpdate;
            symptomsTextBox.ReadOnly    = addNotUpdate;
            updateVitalsButton.Enabled  = addNotUpdate;

            // Vitals have been added, only allowing diagnosis update
            nursesComboBox.Enabled      = !addNotUpdate;
            clearVitalsButton.Enabled   = !addNotUpdate;
            addVitalsButton.Enabled     = !addNotUpdate;
        }

        // Clears our vitals fields if necessary
        private void clearVitalsButton_Click(object sender, EventArgs e)
        {
            nursesComboBox.SelectedIndex = -1;
            systolicTextBox.Text         = "";
            diastolicTextBox.Text        = "";
            temperatureTextBox.Text      = "";
            pulseTextBox.Text            = "";
            symptomsTextBox.Text         = "";
            diagnosisTextBox.Text        = "";
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Tests Private Helpers ////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                isValidDate(testDateDateTimePicker) &&
                isNotNullorEmpty(resultsTextBox) &&
                isNotNullorEmpty(resultsTextBox))
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
            test.date      = this.appointmentDate;
            test.doctorID  = this.doctorID;
            test.patientID = this.patientID;
            test.testCode  = testComboBox.SelectedValue.ToString();
            test.testDate  = testDateDateTimePicker.Value;
            test.results   = resultsTextBox.Text;
            return test;
        }

        // Disables our testing fields
        private void enableTestFields(bool shouldEnable)
        {
            testComboBox.Enabled            = shouldEnable;
            testDateDateTimePicker.Enabled  = shouldEnable;
            orderTestButton.Enabled         = shouldEnable;
            clearTestsButton.Enabled        = shouldEnable;

            resultsTextBox.ReadOnly         = !shouldEnable;
        }

        // Clears test info and sets time to original apt date
        private void clearTestsButton_Click(object sender, EventArgs e)
        {
            testComboBox.SelectedIndex   = -1;
            testDateDateTimePicker.Value = this.appointmentDate;
            resultsTextBox.Text          = "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Filler Helpers ///////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Fills our patient info into the form
        private void fillForm()
        {
            fillVitalFields();
            fillTestFields();
            fillComboBoxes();

            appointmentDateTextBox.Text = this.appointmentDate.ToString("ddd MMM d, yyyy");

            Person patient = patientsController.GetPatientByID(this.patientID);
            patientNameTextBox.Text = patient.firstName + " " + patient.lastName;

            Person doctor = doctorsController.GetDoctorByID(this.doctorID);
            doctorNameTextBox.Text = doctor.firstName + " " + doctor.lastName;
        }

        // Fills all of the vitals informationo into the table if exists
        private void fillVitalFields()
        {
            try
            {
                this.appointmentVitals = vitalsController.GetAppointmentVitals(this.appointmentDate, this.doctorID, this.patientID);

                if (this.appointmentVitals != null)
                {
                    nursesComboBox.SelectedIndex =
                            nursesComboBox.FindString(this.appointmentVitals.nurseFullName.ToString());
                    systolicTextBox.Text = this.appointmentVitals.systolic;
                    diastolicTextBox.Text = this.appointmentVitals.diastolic;
                    temperatureTextBox.Text = this.appointmentVitals.temperature;
                    pulseTextBox.Text = this.appointmentVitals.pulse;
                    symptomsTextBox.Text = this.appointmentVitals.symptoms;
                    diagnosisTextBox.Text = this.appointmentVitals.diagnosis;

                    this.vitalsPresent = true;
                    toggleVitalsFieldsAndButtons(true);
                }
                else
                {
                    this.vitalsPresent = false;
                    nursesComboBox.SelectedIndex = -1;
                    toggleVitalsFieldsAndButtons(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        // Fills all of our test fields
        private void fillTestFields()
        {
            try
            {
                if (vitalsPresent)
                {
                    // Fill tests that exist
                    this.appointmentTests = testsController.GetAppointmentTests(this.appointmentDate, this.doctorID, this.patientID);
                    testsDataGridView.DataSource = this.appointmentTests;
                    testDateDateTimePicker.Value = this.appointmentDate;

                    // Enable testing fields
                    enableTestFields(true);
                }
                else
                {
                    enableTestFields(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Form Validators //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool isNotNullorEmpty(TextBox textBox)
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

        private bool isValidDate(DateTimePicker date)
        {
            if (date.Value >= this.appointmentDate)
                return true;
            else
            {
                date.Focus();
                return false;
            }
        }
    }
}
