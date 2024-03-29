﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.DBA;
using MedTracker.Model;

namespace MedTracker.Controller
{
    class NursesController
    {
        public bool checkIfNurses(string username)
        {
            return NursesDAL.checkIfNurses(username);
        }
        public Nurses getNurse(string username)
        {
            return NursesDAL.getNurse(username);
        }
        public List<Person> GetNurseList()
        {
            return NursesDAL.GetNurseList();
        }
    }
}
