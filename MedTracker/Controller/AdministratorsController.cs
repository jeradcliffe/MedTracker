using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;
using MedTracker.Model;

namespace MedTracker.Controller
{
    class AdministratorsController
    {
        public bool checkIfAdministrators(string username)
        {
            return AdministratorsDAL.checkIfAdministrators(username);
        }

        public Administrators getAdministrator(string username)
        {
            return AdministratorsDAL.getAdministrator(username);
        }
    }
}
