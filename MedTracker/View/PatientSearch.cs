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
    public partial class PatientSearch : Form
    {
        public Person patient;
        private List<Person> patientList;
        private PatientsController patientsController;
        private Boolean dateChosen;

        // Initialize the form
        public PatientSearch()
        {
            InitializeComponent();
            patientsController = new PatientsController();
            clearFields();
        }

        ///////////////////////////////////////////////////////////////
        /////////////////////// Actions/Buttons ///////////////////////
        ///////////////////////////////////////////////////////////////

        // Search for a patient
        private void searchButton_Click(object sender, EventArgs e)
        {
            string dateOfBirth = formatDateOfBirth(dateOfBirthDateTimePicker);
            string firstName   = firstNameTextBox.Text;
            string lastName    = lastNameTextBox.Text;

            if (searchValid(dateOfBirth, firstName, lastName))
            {
                try
                {
                    patientList = patientsController.GetSelectedPatients(dateOfBirth, firstName, lastName);
                    patientDataGridView.DataSource = patientList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                switch (patientList.Count)
                {
                    case 0:
                        messageLabel.Text = "No patients found.";
                        break;
                    case 1:
                        messageLabel.Text = "One patient found.";
                        break;
                    default:
                        messageLabel.Text = patientDataGridView.RowCount + " patients found.";
                        break;
                }
            }
        }

        // Clears the fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            dateOfBirthDateTimePicker.CustomFormat = " ";
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            dateChosen = false;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            patientDataGridView.DataSource = null;
            messageLabel.Text = "Please enter your search criteria.";
        }

        /// <summary>
        /// This button is only available in the DataGridView. When clicked
        /// it will transfer us to a form that allows to add, edit, and view
        /// all of the patients appointments.
        /// </summary>
        private void patientDataGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int i = e.RowIndex;
                DataGridViewRow row = patientDataGridView.Rows[i];
                Person patientSelected = (Person)row.DataBoundItem;

                AppointmentForm appointmentForm = new AppointmentForm();
                appointmentForm.patientID = patientSelected.patientID;
                appointmentForm.ShowDialog();
            }
        }

        ///////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers ///////////////////////
        ///////////////////////////////////////////////////////////////

        /// <summary>
        /// Formats the DOB as a result of whether or not someone has chosen one 
        /// for their search feature. This has to be done because the date time picker
        /// auto-chooses the current date as a default. 
        /// </summary>
        /// <param name="datePicker"></param>
        /// <returns></returns>
        private string formatDateOfBirth(DateTimePicker datePicker)
        {
            if (dateChosen)
                return dateOfBirthDateTimePicker.Value.ToString("yyyy-MM-dd");
            else
                return ""; 
        }

        // Changes the date format
        private void dateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirthDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            dateChosen = true;
        }

        /// <summary>
        /// Used for validation of the fields. Will display a message to the user
        /// guiding them to fill in our DOB, first name, and last name fields correctly
        /// when searching for a patient. 
        /// 
        /// Guidelines: 
        /// 1-DOB only may be searched
        /// 2-DOB and last name may be searched
        /// 3-First and Last name may be searched
        /// </summary>
        private Boolean searchValid(string dob, string firstName, string lastName)
        {
            // DOB only is ok
            if (!String.IsNullOrWhiteSpace(dob) && 
                String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName))
                return true;
            // DOB and last name is ok
            else if (!String.IsNullOrWhiteSpace(dob) &&
                      String.IsNullOrWhiteSpace(firstName) &&
                     !String.IsNullOrWhiteSpace(lastName))
                return true;
            // last name and first name only is ok
            else if (String.IsNullOrWhiteSpace(dob) &&
                     !String.IsNullOrWhiteSpace(firstName) &&
                     !String.IsNullOrWhiteSpace(lastName))
                return true;
            else
                messageLabel.Text = "You may only search by DOB, " +
                    " DOB and last name, or first name and last name";
            return false;
        }

    }
}
