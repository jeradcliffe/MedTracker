using MedTracker.DBA;
using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Controller
{
    class TestsController
    {
        public List<Appointment> GetAppointmentTests(DateTime appointmentDate, int doctorID, int patientID)
        {
            return TestsDAL.GetAppointmentTests(appointmentDate, doctorID, patientID);
        }

        public List<Appointment> GetTests()
        {
            return TestsDAL.GetTests();
        }

        public bool AddTest(Appointment test)
        {
            return TestsDAL.AddTest(test);
        }

        public bool UpdateTestResults(Appointment oldTest, string newResults)
        {
            return TestsDAL.UpdateTestResults(oldTest, newResults);
        }
    }
}
