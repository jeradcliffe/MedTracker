using MedTracker.Model;
using MedTracker.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Controller
{
    class PatientsController
    {
        public int createPatient(Person newPatient)
        {
            return PatientsDAL.CreatePatient(newPatient);
        }

        public List<Person> GetSelectedPatients(string dateOfBirth, string firstName, string lastName)
        {
            return PatientsDAL.GetSelectedPatients(dateOfBirth, firstName, lastName);
        }

        public Person GetPatientByID(int patientID)
        {
            return PatientsDAL.GetPatientByID(patientID);
        } 
    }
}
