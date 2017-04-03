using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class NewPatient : Form
    {
        private bool dateChosen;
        private PatientsController patController;

        public NewPatient()
        {
            InitializeComponent();
            patController = new PatientsController();
            dateChosen = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                !dateChosen ||
                streetAddressTextBox.Text == "" ||
                cityTextBox.Text == "" ||
                zipTextBox.Text == "" ||
                phoneNumberTextBox.Text == "")
            {
                MessageBox.Show("ALL fields are required! Do not leave any blank.");
            }
            else
            {
                Person newPatient = new Person();

                newPatient.firstName = firstNameTextBox.Text;
                newPatient.lastName = lastNameTextBox.Text;
                newPatient.dateOfBirth = dobDateTimePicker.Value.ToString("yyyy-MM-dd");
                newPatient.streetAddress = streetAddressTextBox.Text;
                newPatient.city = cityTextBox.Text;
                newPatient.state = stateTextBox.Text;
                newPatient.zip = zipTextBox.Text;
                newPatient.phoneNumber = phoneNumberTextBox.Text;

                int statusOfCreate = patController.createPatient(newPatient);

                //if create patient was successful
                if (statusOfCreate == 0)
                {
                    MessageBox.Show("Patient was successfully created!");
                    this.Close();
                }
            }
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            dateChosen = true;
        }
    }
}
