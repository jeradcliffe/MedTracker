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
        private Appointment currentVitals;
        private Appointment currentTest;
        public DateTime appointmentDate;
        private DataGridViewRow currentRow;
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
                            enableVitalsFields(false);
                            enableTestFields(true);
                            this.currentVitals = vitals;
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
                    if (vitalsController.UpdateVitalsDiagnosis(this.currentVitals, diagnosisTextBox.Text))
                        vitalsMessageLabel.Text = "Vitals successfully updated.";
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
        private void enableVitalsFields(bool enable)
        {
            // All textboxes are readonly?
            systolicTextBox.ReadOnly    = !enable;
            diastolicTextBox.ReadOnly   = !enable;
            temperatureTextBox.ReadOnly = !enable;
            pulseTextBox.ReadOnly       = !enable;
            symptomsTextBox.ReadOnly    = !enable;
            
            // Enable buttons? 
            nursesComboBox.Enabled      = enable;
            clearVitalsButton.Enabled   = enable;
            addVitalsButton.Enabled     = enable;

            updateVitalsButton.Enabled = !enable;
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
                DialogResult result
                    = MessageBox.Show("Are you sure you would like to order this test? "
                    + "Once you enter it you may not edit them it the future.",
                    "Add Test?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Appointment test = putTest(new Appointment());
                        if (testsController.AddTest(test))
                        {
                            testsMessageLabel.Text = "Test successfully added.";
                            this.currentTest = test;
                            clearTestFields();
                            fillTestFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        testsMessageLabel.Text = "Unable to order test. Please make sure it isn't a duplicate.";
                    }
                }
            }
        }

        private void updateTestButton_Click(object sender, EventArgs e)
        {
            if (testIsValid())
            {
                try
                {
                    String newResults = "";
                    if (normalRadioBtn.Checked == true)
                        newResults = "Normal";
                    else
                        newResults = "Abnormal";

                    if (testsController.UpdateTestResults(this.currentTest, newResults))
                    {
                        testsMessageLabel.Text = "Test successfully updated.";
                        this.currentTest.results = newResults;
                        fillTestFields();
                    }
                    else
                    {
                        testsMessageLabel.Text = "Unable to update test in database. Please try again.";
                        fillTestFields();
                    }
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
            if (testsComboBox.SelectedIndex != -1 &&
                isValidDate(testDateTimePicker))
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
            test.testCode  = testsComboBox.SelectedValue.ToString();
            test.testDate  = testDateTimePicker.Value;
            if (normalRadioBtn.Checked == true)
                test.results = "Normal";
            else if (abnormalRadioBtn.Checked == true)
                test.results = "Abnormal";
            else
                test.results = "";
            return test;
        }

        // Disables our testing fields
        private void enableTestFields(bool enable)
        {
            testsComboBox.Enabled       = enable;
            testDateTimePicker.Enabled  = enable;
            orderTestButton.Enabled     = enable;
            clearTestsButton.Enabled    = enable;
            normalRadioBtn.Enabled      = enable;
            abnormalRadioBtn.Enabled    = enable;
        }

        /// <summary>
        /// Highlights the rows we are working with and will input test information
        /// into the correct fields.
        /// </summary>
        private void testsDataGridView_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            // Clear previously highlighted row
            if (this.currentRow != null)
                this.currentRow.DefaultCellStyle.BackColor = SystemColors.Window;

            try
            {
                // Highlight row and assign row to variable
                int i = e.RowIndex;
                this.currentRow = testsDataGridView.Rows[i];
                this.currentRow.DefaultCellStyle.BackColor = SystemColors.Highlight;
                this.currentTest = (Appointment)this.currentRow.DataBoundItem;

                // Place data into test fields
                testsComboBox.SelectedValue = this.currentTest.testCode;
                testDateTimePicker.Value    = this.currentTest.testDate;
                if (this.currentTest.results.Equals("normal", StringComparison.InvariantCultureIgnoreCase))
                    normalRadioBtn.Checked = true;
                else
                    abnormalRadioBtn.Checked = true;

                // Only allow update of selected tests to avoid duplicate PK entries
                enableTestFields(false);
                updateTestButton.Enabled = true;
                clearTestsButton.Enabled = true;
                normalRadioBtn.Enabled   = true;
                abnormalRadioBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                return;
            }

            MessageBox.Show("Appointment date" + appointmentDate + "\n\n" +
                "Test date" + currentTest.testDate + "\n\n" , "DATES");
        }

        // Clears test info and sets time to original apt date
        private void clearTestsButton_Click(object sender, EventArgs e)
        {
            clearTestFields();
        }

        private void clearTestFields()
        {
            testsComboBox.SelectedIndex = -1;
            testDateTimePicker.Value = this.appointmentDate;
            normalRadioBtn.Checked = false;
            abnormalRadioBtn.Checked = false;
            testsMessageLabel.Text = "";

            enableTestFields(true);
            updateTestButton.Enabled = false;
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
                this.currentVitals = vitalsController.GetAppointmentVitals(this.appointmentDate, this.doctorID, this.patientID);

                if (this.currentVitals != null)
                {
                    nursesComboBox.SelectedIndex =
                            nursesComboBox.FindString(this.currentVitals.nurseFullName.ToString());
                    systolicTextBox.Text    = this.currentVitals.systolic;
                    diastolicTextBox.Text   = this.currentVitals.diastolic;
                    temperatureTextBox.Text = this.currentVitals.temperature;
                    pulseTextBox.Text       = this.currentVitals.pulse;
                    symptomsTextBox.Text    = this.currentVitals.symptoms;
                    diagnosisTextBox.Text   = this.currentVitals.diagnosis;

                    this.vitalsPresent = true;
                    enableVitalsFields(false);
                }
                else
                {
                    this.vitalsPresent = false;
                    nursesComboBox.SelectedIndex = -1;
                    enableVitalsFields(true);
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
                    this.appointmentTests        = testsController.GetAppointmentTests(this.appointmentDate, this.doctorID, this.patientID);
                    testsDataGridView.DataSource = this.appointmentTests;
                    testDateTimePicker.Value     = this.appointmentDate;
                    testsDataGridView.ClearSelection();

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
                List<Person> nurses          = nursesController.GetNurseList();
                nursesComboBox.DataSource    = nurses;
                nursesComboBox.DisplayMember = "fullName";
                nursesComboBox.ValueMember   = "nurseID";

                List<Appointment> tests      = testsController.GetTests();
                testsComboBox.DataSource     = tests;
                testsComboBox.DisplayMember  = "testName";
                testsComboBox.ValueMember    = "testCode";
                testsComboBox.SelectedIndex  = -1;
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
            if (date.Value.Date >= this.appointmentDate.Date)
                return true;
            else
            {
                date.Focus();
                return false;
            }
        }


    }
}
