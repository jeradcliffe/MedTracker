using MedTracker.DBA;
using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Controller
{
    class VitalsController
    {
        public Appointment GetAppointmentVitals(DateTime appointmentDate, int doctorID, int patientID)
        {
            return VitalsDAL.GetAppointmentVitals(appointmentDate, doctorID, patientID);
        }

        public bool AddVitals(Appointment appointmentVitals)
        {
            return VitalsDAL.AddVitals(appointmentVitals);
        }

        public bool UpdateVitalsDiagnosis(Appointment appointmentVitals, string text)
        {
            return VitalsDAL.UpdateVitalsDiagnosis(appointmentVitals, text);
        }
    }
}
