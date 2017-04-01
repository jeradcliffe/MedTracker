using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;

namespace MedTracker.Controller
{
    class NursesController
    {
        public bool checkIfNurses(string username)
        {
            return NursesDAL.checkIfNurses(username);
        }
    }
}
