using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;
using MedTracker.Model;

namespace MedTracker.Controller
{
    class DoctorsController
    {
        public bool checkIfDoctors(string username)
        {
            return DoctorsDAL.checkIfDoctors(username);
        }

        public Doctors getDoctor(string username)
        {
            return DoctorsDAL.getDoctor(username);
        }

        public List<Person> GetDoctorList()
        {
            return DoctorsDAL.GetDoctorList();
        }

        public Person GetDoctorByID(int doctorID)
        {
            return DoctorsDAL.GetDoctorByID(doctorID);
        }
    }
}
