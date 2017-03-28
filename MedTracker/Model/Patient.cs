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
        public string firstName     { get; set; }
        public string lastName      { get; set; }
        public string dateOfBirth   { get; set; }
        public string streetAddress { get; set; }
        public string city          { get; set; }
        public string state         { get; set; }
        public string zip           { get; set; }
        public string phoneNumber   { get; set; }
    }
}
