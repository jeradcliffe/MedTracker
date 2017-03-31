using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;
using MedTracker.Model;

namespace MedTracker.Controller
{
    class ClinicEmployeesController
       
    {
        public bool checkLoginCredentials(string username, string password)
        {
            return ClinicEmployeesDAL.checkLoginCredentials(username, password);
        }
    }
}
