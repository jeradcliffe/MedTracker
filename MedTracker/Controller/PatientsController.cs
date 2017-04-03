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
        public int CreatePatient(Person newPatient)
        {
            return PatientsDAL.CreatePatient(newPatient);
        }

        public int UpdatePatient(Person patientWithOldData, Person updatedPatient)
        {
            return PatientsDAL.UpdatePatient(patientWithOldData, updatedPatient);
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
