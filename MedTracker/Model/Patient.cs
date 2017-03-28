using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Model
{
    class Patient
    {
        public int peopleID  { get; set; }
        public int patientID { get; set; }

        // Pulled from the peoples table but most relavant to this class
        public string fName   { get; set; }
        public string lName   { get; set; }
        public string DOB     { get; set; }
        public string address { get; set; }
        public string city    { get; set; }
        public string state   { get; set; }
        public int    zip     { get; set; }
        public string phone   { get; set; }
    }
}
