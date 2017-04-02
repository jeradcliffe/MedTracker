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
        //private Person patient;
        public int patientID;
        //private Person doctor;
        public int doctorID;
        private List<Appointment> appointmentTests;
        private Appointment appointmentVitals;
        public DateTime appointmentDate;

        public CheckUpForm()
        {
            InitializeComponent();
            doctorsController = new DoctorsController();
            patientsController = new PatientsController();
            appointmentsController = new AppointmentsController();
        }

        private void CheckUpForm_Load(object sender, EventArgs e)
        {
            fillAppointmentDoctorPatientInformation();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////// Private Helpers //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fills our patient info into the form
        private void fillAppointmentDoctorPatientInformation()
        {
            appointmentTests  = appointmentsController.GetAppointmentTests(appointmentDate, doctorID, patientID);
            appointmentVitals = appointmentsController.GetAppointmentVitals(appointmentDate, doctorID, patientID);
            appointmentDateTextBox.Text = appointmentDate.ToString("ddd MMM d, yyyy");

            Person patient = patientsController.GetPatientByID(patientID);
            patientNameTextBox.Text = patient.firstName + " " + patient.lastName;

            Person doctor = doctorsController.GetDoctorByID(doctorID);
            doctorNameTextBox.Text = doctor.firstName + " " + doctor.lastName;
        }


    }
}
