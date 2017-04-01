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
        private Appointment appointment;
        private Boolean dateChosen = false;


        public AppointmentForm()
        {
            InitializeComponent();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
            clearFields();
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


        ///////////////////////////////////////////////////////////////
        /////////////////////// Actions/Buttons ///////////////////////
        ///////////////////////////////////////////////////////////////

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            if (isValidNewAppointment())
            {
                try
                {
                    appointment = new Appointment();
                    putAppointmentData(appointment);

                    if (appointmentsController.AddApointment(appointment))
                    {
                        messageLabel.Text = "Appointment successfully added.";
                        appointmentList.Add(appointment);
                        fillAppointmentInformation();
                    }
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        ///////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers ///////////////////////
        ///////////////////////////////////////////////////////////////

        // Fills our patient info into the form
        private void fillPatientInformation()
        {
            patient = patientsController.GetPatientByID(patientID);
            firstNameTextBox.Text   = patient.firstName + " " + patient.lastName;
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
            appointment.date      = appointmentDatePicker.Value.Date +
                    appointmentTimePicker.Value.TimeOfDay;
        }

        // Checks if new appointment has valid data
        private Boolean isValidNewAppointment()
        {

            if (dateChosen &&
                doctorsComboBox.SelectedIndex != -1 &&
                !String.IsNullOrEmpty(reasonTextBox.Text))
                return true;
            else
            {
                messageLabel.Text = "Date, time, doctor, and reason are needed for new appointment.";
                return false;
            }
                
        }

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            appointmentDatePicker.CustomFormat = ("ddd MMM d, yyyy");
            dateChosen = true;
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
            dateChosen = false;
            doctorsComboBox.SelectedValue = -1;
            reasonTextBox.Text = "";
        }

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
                return appointmentDatePicker.Value.ToString("yyyy-MM-dd");
            else
                return "";
        }
    }
}
