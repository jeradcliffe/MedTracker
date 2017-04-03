using MedTracker.DBA;
using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Controller
{
    class AppointmentsController
    {
        public List<Appointment> GetAppointmentsByPatient(int patientID)
        {
            return AppointmentsDAL.GetAppointmentsByPatient(patientID);
        }

        public Boolean AddAppointment (Appointment appointment)
        {
            return AppointmentsDAL.AddAppointment(appointment);
        }

        public Boolean UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            return AppointmentsDAL.UpdateAppointment(oldAppointment, newAppointment);
        }

        public Appointment GetAppointmentVitals(DateTime appointmentDate, int doctorID, int patientID)
        {
            return AppointmentsDAL.GetAppointmentVitals(appointmentDate, doctorID, patientID);
        }

        public List<Appointment> GetAppointmentTests(DateTime appointmentDate, int doctorID, int patientID)
        {
            return AppointmentsDAL.GetAppointmentTests(appointmentDate, doctorID, patientID);
        }
    }
}
