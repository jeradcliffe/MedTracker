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

            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");

            firstNameTextBox.Text     = patientToBeUpdated.firstName;
            lastNameTextBox.Text      = patientToBeUpdated.lastName;
            dobDateTimePicker.Value   = patientToBeUpdated.dateOfBirth;
            streetAddressTextBox.Text = patientToBeUpdated.streetAddress;
            cityTextBox.Text          = patientToBeUpdated.city;
            stateComboBox.Text        = patientToBeUpdated.state;
            zipTextBox.Text           = patientToBeUpdated.zip;
            phoneNumberTextBox.Text   = patientToBeUpdated.phoneNumber;
            genderComboBox.Text       = patientToBeUpdated.gender;
            ssnTextBox.Text           = patientToBeUpdated.ssn;

            if (stateComboBox.SelectedIndex < 0)
            {
                stateComboBox.SelectedIndex = 0;
            }

            if (genderComboBox.SelectedIndex < 0)
            {
                genderComboBox.SelectedIndex = 0;
            }

            dobDateTimePicker.MaxDate = DateTime.Today;
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {            
            if (this.allFieldsAreValid())
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
                updatedPatient.gender        = genderComboBox.Text;
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

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void zipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyNumbersKeyPress(e);
        }

        private void ssnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyNumbersKeyPress(e);            
        }

        private void allowOnlyNumbersKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool allFieldsAreValid()
        {
            if (firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                streetAddressTextBox.Text == "" ||
                cityTextBox.Text == "" ||
                zipTextBox.Text == "" ||
                phoneNumberTextBox.Text == "" ||
                ssnTextBox.Text == "")
            {
                MessageBox.Show("ALL fields are required! Do not leave any blank.");
                return false;
            }
            else if (firstNameTextBox.Text.Length > 45)
            {
                MessageBox.Show("First Name cannot be longer than 45 characters!", "Invalid First Name");
                return false;
            }
            else if (lastNameTextBox.Text.Length > 45)
            {
                MessageBox.Show("Last Name cannot be longer than 45 characters!", "Invalid Last Name");
                return false;
            }
            else if (streetAddressTextBox.Text.Length > 65)
            {
                MessageBox.Show("Street Address cannot be longer than 65 characters!", "Invalid Street Address");
                return false;
            }
            else if (cityTextBox.Text.Length > 45)
            {
                MessageBox.Show("City cannot be longer than 65 characters!", "Invalid City");
                return false;
            }
            else if (zipTextBox.Text.Length < 5 || zipTextBox.Text.Length > 5)
            {
                MessageBox.Show("Zip code must be exactly 5 digits!", "Invalid Zip Code");
                return false;
            }
            else if (phoneNumberTextBox.Text.Length < 10 || phoneNumberTextBox.Text.Length > 12)
            {
                MessageBox.Show("Phone Number must be between 10 and 12 digits!", "Invalid Phone Number");
                return false;
            }
            else if (ssnTextBox.Text.Length < 9 || ssnTextBox.Text.Length > 9)
            {
                MessageBox.Show("Social Security Number must be exactly 9 digits, using valid numbers only!", "Invalid SSN");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
