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
        private Person patient;
        public int patientID;
        private Appointment currentAppointment;
        private Boolean dateChosen = false;
        private DataGridViewRow row;


        public AppointmentForm()
        {
            InitializeComponent();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
            clearFields();
            updateButton.Enabled = false;
            checkupButton.Enabled = false;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
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
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
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
                    messageLabel.Text = "Unable to update information. Please try again.";
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
            appointmentDatePicker.CustomFormat = " ";
            appointmentDatePicker.Format = DateTimePickerFormat.Custom;
            appointmentTimePicker.Value = new DateTime(2000, 1, 1, 12, 0, 0);
            dateChosen = false;
            doctorsComboBox.SelectedValue = -1;
            reasonTextBox.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills our patient info into the form
        private void fillPatientInformation()
        {
            patient = patientsController.GetPatientByID(patientID);
            patientNameTextBox.Text = patient.firstName + " " + patient.lastName;
            phoneNumberTextBox.Text = patient.phoneNumber;
            cityTextBox.Text        = patient.city;
            stateTextBox.Text       = patient.state;
            zipTextBox.Text         = patient.zip;
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
                {
                    row.DefaultCellStyle.BackColor = SystemColors.Window;
                }


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

                        MessageBox.Show(currentAppointment.doctorFullName, "title");
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

        // Checks if new appointment has valid data
        private Boolean isValidNewAppointment()
        {
            if (dateChosen && 
                isValidDate(appointmentDatePicker, appointmentTimePicker) &&
                isValidCbox(doctorsComboBox) &&
                isNotEmptyOrNull(reasonTextBox) &&
                !isInt32(reasonTextBox))
                return true;
            else
            {
                messageLabel.Text = doctorsComboBox.SelectedIndex.ToString();
                //messageLabel.Text = "Date, time, doctor, and reason are needed for new appointment.";
                return false;
            }     
        }

        // Changes the date time to specified format when value has been chosen
        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            appointmentDatePicker.CustomFormat = ("ddd MMM d, yyyy");
            dateChosen = true;
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Form Validators //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool isNotEmptyOrNull(TextBox textBox)
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
                date.Focus();
                return false;
            }
        }

        private bool isValidCbox(ComboBox cbox) 
        {
            if (cbox.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                cbox.Focus();
                return false;
            }
        }

    }
}
