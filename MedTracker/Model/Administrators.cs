using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Model
{
    public class Administrators
    {
        public Administrators()
        {

        }

        public int adminID { get; set; }
        public int peopleID { get; set; }
        public string userName { get; set; }
    }
}
