using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;

namespace MedTracker.Controller
{
    class DoctorsController
    {
        public bool checkIfDoctors(string username)
        {
            return DoctorsDAL.checkIfDoctors(username);
        }
    }
}
