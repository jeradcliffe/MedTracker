using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class UpdatePatientForm : Form
    {
        private Person patientToBeUpdated;
        private PatientsController patientsController;

        public UpdatePatientForm(Person patientToBeUpdated)
        {
            InitializeComponent();
            this.patientToBeUpdated = patientToBeUpdated;
            this.patientsController = new PatientsController();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void UpdatePatient_Load(object sender, System.EventArgs e)
        {
            bool dateParsedSuccessfully = false;
            DateTime parsedDateOfBirth = DateTime.Today;

            try
            {
                parsedDateOfBirth = DateTime.Parse(patientToBeUpdated.dateOfBirth);
                dateParsedSuccessfully = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            if (dateParsedSuccessfully)
            {
                firstNameTextBox.Text     = patientToBeUpdated.firstName;
                lastNameTextBox.Text      = patientToBeUpdated.lastName;
                dobDateTimePicker.Value   = parsedDateOfBirth;
                streetAddressTextBox.Text = patientToBeUpdated.streetAddress;
                cityTextBox.Text          = patientToBeUpdated.city;
                stateTextBox.Text         = patientToBeUpdated.state;
                zipTextBox.Text           = patientToBeUpdated.zip;
                phoneNumberTextBox.Text   = patientToBeUpdated.phoneNumber;
            }
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                streetAddressTextBox.Text == "" ||
                cityTextBox.Text == "" ||
                stateTextBox.Text == "" ||
                zipTextBox.Text == "" ||
                phoneNumberTextBox.Text == "")
            {
                MessageBox.Show("ALL fields are required! Do not leave any blank.");
            }
            else
            {
                Person updatedPatient = new Person();

                updatedPatient.firstName = firstNameTextBox.Text;
                updatedPatient.lastName = lastNameTextBox.Text;
                updatedPatient.dateOfBirth = dobDateTimePicker.Value.ToString("yyyy-MM-dd");
                updatedPatient.streetAddress = streetAddressTextBox.Text;
                updatedPatient.city = cityTextBox.Text;
                updatedPatient.state = stateTextBox.Text;
                updatedPatient.zip = zipTextBox.Text;
                updatedPatient.phoneNumber = phoneNumberTextBox.Text;

                int statusOfUpdate = patientsController.UpdatePatient(patientToBeUpdated, updatedPatient);

                if (statusOfUpdate == 0)
                {
                    MessageBox.Show("Patient Information was successfully updated!", "Patient Update");
                    this.Close();
                }

                if (statusOfUpdate == 1)
                {
                    MessageBox.Show("The selected person is not a patient!", "Patient Update Failed");
                }
            }
        }
    }
}
