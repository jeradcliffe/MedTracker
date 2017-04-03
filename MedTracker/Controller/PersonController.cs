using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;
using MedTracker.Model;

namespace MedTracker.Controller
{
    class PersonController
    {
        public Person GetPerson(int peopleID)
        {
            return PersonDAL.GetPerson(peopleID);
        }
    }
}
