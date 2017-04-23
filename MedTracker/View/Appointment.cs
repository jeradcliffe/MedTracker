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
    public partial class AppointmentForm : Form
    {
        private AppointmentsController appointmentsController;
        private PatientsController patientsController;
        private DoctorsController doctorsController;
        private List<Appointment> appointmentList;
        private Appointment currentAppointment;
        private DataGridViewRow row;
        private Person patient;
        public int patientID;
        public int nurseID;
        


        public AppointmentForm()
        {
            InitializeComponent();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
            appointmentDatePicker.MinDate = DateTime.Today;
            clearFields();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                fillDoctorsList();
                fillPatientInformation();
                fillAppointmentInformation();
                switch (appointmentList.Count)
                {
                    case 0:
                        messageLabel.Text = "No appointments found.";
                        break;
                    case 1:
                        messageLabel.Text = "One appointment found.";
                        break;
                    default:
                        messageLabel.Text = appointmentDataGridView.RowCount + " appointments found.";
                        break;
                }
            }
            catch (Exception)
            {
                messageLabel.Text = "No appointments scheduled for this patient.";
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Actions/Buttons //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Creates an appointment for our current patient. Highlights the row after
        /// to clearly show the changes that have been made. 
        /// </summary>
        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            if (isValidNewAppointment())
            {
                try
                {
                    currentAppointment = new Appointment();
                    putAppointmentData(currentAppointment);

                    if (appointmentsController.AddAppointment(currentAppointment))
                    {
                        messageLabel.Text = "Appointment successfully added.";
                        appointmentList.Add(currentAppointment);
                        fillAppointmentInformation();
                        clearFields();
                    }
                    
                }
                catch (Exception ex)
                {
                    messageLabel.Text = "Unable to add new appointment. Doctor and patient may not have overlapping times. ";
                }
            }
        }

        /// <summary>
        /// Updates our appointment and leaves the updated row highlighted so that the 
        /// user can see clearly where changes have been made.
        /// </summary>
        private void updateAppointmentButton_click(object sender, EventArgs e)
        {
            if (isValidNewAppointment())
            {
                try
                {
                    Appointment newAppointment = new Appointment();
                    putAppointmentData(newAppointment);

                    if (appointmentsController.UpdateAppointment(currentAppointment, newAppointment))
                    {
                        currentAppointment = newAppointment;
                        messageLabel.Text = "Successfully updated appointment.";
                        fillAppointmentInformation();
                    }
                        
                }
                catch (Exception ex)
                {
                    messageLabel.Text = "Unable to update the appointment. Please try again.";
                    fillAppointmentInformation();
                }
            }
        }

        /// <summary>
        /// If appoinment has passed, this will allow the user to add and view check
        /// up information for the user. This includes diagnostic and 
        /// </summary>
        private void checkupButton_Click(object sender, EventArgs e)
        {
            CheckUpForm checkUpForm = new CheckUpForm();
            checkUpForm.appointmentDate = currentAppointment.date;
            checkUpForm.patientID = this.patientID;
            checkUpForm.nurseID = this.nurseID;
            checkUpForm.doctorID = currentAppointment.doctorID;
            checkUpForm.ShowDialog();
        }

        /// <summary>
        /// Highlights the rows we are working with and will input appointment information
        /// into the correct fields in the case that an appointment has not past its due date.
        /// </summary>
        private void appointmentDataGridView_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            // Clear previously highlighted row
            if (row != null)
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
            }

            // Get row data and highlight it for user convenience
            // Return exception used to avoid OutOfBoundsException
            // in case user clicks header and not an actual row.
            try
            {
                int i = e.RowIndex;
                row = appointmentDataGridView.Rows[i];
                row.DefaultCellStyle.BackColor = SystemColors.Highlight;
                currentAppointment = (Appointment)row.DataBoundItem;
            }
            catch (Exception ex)
            {
                return;
            }

            // Fill apt info and enable update if apt isn't past current date
            // else clear fields and disable update button
            DateTime now = DateTime.Now;
            DateTime expirationDate = DateTime.Parse(row.Cells[0].Value.ToString());
            if (now < expirationDate)
            {
                appointmentDatePicker.Value = currentAppointment.date;
                appointmentTimePicker.Value = currentAppointment.date;
                doctorsComboBox.SelectedIndex = 
                        doctorsComboBox.FindString(currentAppointment.doctorFullName.ToString());
                reasonTextBox.Text = currentAppointment.reason;
                updateButton.Enabled = true;
                checkupButton.Enabled = false;
            }
            else
            {
                clearFields();
                updateButton.Enabled = false;
                checkupButton.Enabled = true;
            }
        }

        // Clears the fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            appointmentDatePicker.Value     = DateTime.Today;
            appointmentTimePicker.Value     = new DateTime(2000, 1, 1, 12, 0, 0);
            doctorsComboBox.SelectedValue   = -1;
            reasonTextBox.Text              = "";
            messageLabel.Text               = "";
            updateButton.Enabled            = false;
            checkupButton.Enabled           = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills our patient info into the form
        private void fillPatientInformation()
        {
            try
            {
                patient = patientsController.GetPatientByID(patientID);
                patientNameTextBox.Text = patient.firstName + " " + patient.lastName;
                phoneNumberTextBox.Text = patient.phoneNumber;
                cityTextBox.Text = patient.city;
                stateTextBox.Text = patient.state;
                zipTextBox.Text = patient.zip;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to fill aptient information. Please check connection to DB.", "Error");
            }
        }

        // Loads our DataGridView with appointment information
        private void fillAppointmentInformation()
        {
            try
            {
                appointmentList = appointmentsController.GetAppointmentsByPatient(patientID);
                appointmentDataGridView.DataSource = appointmentList;
                appointmentDataGridView.ClearSelection();

                // Clear any previously highlighted rows
                if (row != null)
                    row.DefaultCellStyle.BackColor = SystemColors.Window;

                foreach (DataGridViewRow gridRow in appointmentDataGridView.Rows)
                {
                    DateTime expirationDate = DateTime.Now;
                    DateTime rowDate = DateTime.Parse(gridRow.Cells[0].Value.ToString());
                    string rowDoctor = gridRow.Cells[7].Value.ToString();

                    // Gray out any past due appointments
                    if (expirationDate >= rowDate)
                        gridRow.DefaultCellStyle.ForeColor = Color.Red;

                    // Highlight current appointment that we are working with
                    if (currentAppointment != null && 
                        currentAppointment.date == rowDate &&
                        currentAppointment.doctorFullName.Equals(rowDoctor))
                    {
                        row = gridRow;
                        row.DefaultCellStyle.BackColor = SystemColors.Highlight;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Loads our doctors into the comboBox
        private void fillDoctorsList()
        {
            try
            {
                List<Person> doctorList         = doctorsController.GetDoctorList();
                doctorsComboBox.DataSource      = doctorList;
                doctorsComboBox.DisplayMember   = "fullName";
                doctorsComboBox.ValueMember     = "doctorID";
                doctorsComboBox.SelectedIndex   = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Creates an appointment via the form information
        private void putAppointmentData(Appointment appointment)
        {
            appointment.patientID = patient.patientID; 
            appointment.doctorID  = (int)doctorsComboBox.SelectedValue;
            appointment.reason    = reasonTextBox.Text;
            appointment.doctorFullName = ((Person)doctorsComboBox.SelectedItem).fullName;
            
            DateTime date = appointmentDatePicker.Value.Date;
            TimeSpan ts = new TimeSpan(
                appointmentTimePicker.Value.Hour, appointmentTimePicker.Value.Minute, 0);
            appointment.date = date + ts;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Form Validators //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Checks if new appointment has valid data
        private Boolean isValidNewAppointment()
        {
            if (isValidDate(appointmentDatePicker, appointmentTimePicker) &&
                isValidCbox(doctorsComboBox) &&
                isNotEmptyOrNull(reasonTextBox) &&
                !isInt32(reasonTextBox))
                return true;
            else
            {
                return false;
            }
        }

        private bool isNotEmptyOrNull(TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrWhiteSpace(textBox.Text))
                return true;
            else
            {
                textBox.Focus();
                messageLabel.Text = "Field must be filled in.";
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

        private bool isValidDate(DateTimePicker date, DateTimePicker time)
        {
            DateTime apptDate = date.Value.Date;
            TimeSpan ts = new TimeSpan(
                appointmentTimePicker.Value.Hour, appointmentTimePicker.Value.Minute, 0);
            apptDate = apptDate + ts;
            if (apptDate >= DateTime.Now)
                return true;
            else
            {
                time.Focus();
                messageLabel.Text = "Appointment may not be from a past time.";
                return false;
            }
        }

        private bool isValidCbox(ComboBox cbox) 
        {
            if (cbox.SelectedIndex != -1)
                return true;
            else
            {
                cbox.Focus();
                messageLabel.Text = "Please choose a vaild doctor.";
                return false;
            }
        }

    }
}
