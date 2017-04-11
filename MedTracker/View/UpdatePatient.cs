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
            string[] states = new string[]
            {
                "AL", "AK", "AZ", "AR", "CA",
                "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA",
                "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO",
                "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH",
                "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT",
                "VA", "WA", "WV", "WI", "WY"
            };

            foreach (string state in states)
            {
                stateComboBox.Items.Add(state);
            }

            firstNameTextBox.Text     = patientToBeUpdated.firstName;
            lastNameTextBox.Text      = patientToBeUpdated.lastName;
            dobDateTimePicker.Value   = patientToBeUpdated.dateOfBirth;
            streetAddressTextBox.Text = patientToBeUpdated.streetAddress;
            cityTextBox.Text          = patientToBeUpdated.city;
            stateComboBox.Text        = patientToBeUpdated.state;
            zipTextBox.Text           = patientToBeUpdated.zip;
            phoneNumberTextBox.Text   = patientToBeUpdated.phoneNumber;
            genderTextBox.Text        = patientToBeUpdated.gender;
            ssnTextBox.Text           = patientToBeUpdated.ssn;
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                genderTextBox.Text == "" ||
                streetAddressTextBox.Text == "" ||
                cityTextBox.Text == "" ||
                stateComboBox.Text == "" ||
                zipTextBox.Text == "" ||
                phoneNumberTextBox.Text == "" ||
                ssnTextBox.Text == "")
            {
                MessageBox.Show("ALL fields are required! Do not leave any blank.");
            }
            else if (ssnTextBox.Text.Length < 9 || ssnTextBox.Text.Length > 9)
            {
                MessageBox.Show("Social Security Number must be exactly 9 digits, using valid numbers only!", "Invalid SSN");
            }
            else
            {
                Person updatedPatient = new Person();

                updatedPatient.firstName     = firstNameTextBox.Text;
                updatedPatient.lastName      = lastNameTextBox.Text;
                updatedPatient.dateOfBirth   = dobDateTimePicker.Value;
                updatedPatient.streetAddress = streetAddressTextBox.Text;
                updatedPatient.city          = cityTextBox.Text;
                updatedPatient.state         = stateComboBox.Text;
                updatedPatient.zip           = zipTextBox.Text;
                updatedPatient.phoneNumber   = phoneNumberTextBox.Text;
                updatedPatient.gender        = genderTextBox.Text;
                updatedPatient.ssn           = ssnTextBox.Text;

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

        private void ssnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Used to validate for numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
