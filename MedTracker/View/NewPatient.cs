using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class NewPatientForm : Form
    {
        private bool dateChosen;
        private PatientsController patientsController;

        public NewPatientForm()
        {
            InitializeComponent();
            this.patientsController = new PatientsController();
            this.dateChosen = false;
        }        

        private void NewPatientForm_Load(object sender, EventArgs e)
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

        private void createPatientButton_Click(object sender, EventArgs e)
        {            
            if (this.allFieldsAreValid())
            {
                Person newPatient = new Person();

                newPatient.firstName     = firstNameTextBox.Text;
                newPatient.lastName      = lastNameTextBox.Text;
                newPatient.dateOfBirth   = dobDateTimePicker.Value.Date;
                newPatient.streetAddress = streetAddressTextBox.Text;
                newPatient.city          = cityTextBox.Text;
                newPatient.state         = stateComboBox.Text;
                newPatient.zip           = zipTextBox.Text;
                newPatient.phoneNumber   = phoneNumberTextBox.Text;
                newPatient.gender        = genderComboBox.Text;
                newPatient.ssn           = ssnTextBox.Text;

                int statusOfCreate = patientsController.CreatePatient(newPatient);

                //if create patient was successful
                if (statusOfCreate == 0)
                {
                    MessageBox.Show("Patient was successfully created!");
                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
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

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            dateChosen = true;
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
                !dateChosen ||
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
                MessageBox.Show("Social Security Number must be exactly 9 digits!", "Invalid SSN");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
