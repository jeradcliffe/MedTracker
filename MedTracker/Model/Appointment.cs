using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Model
{
    class Appointment
    {
        public DateTime date      { get; set; }
        public int      doctorID  { get; set; }
        public int      patientID { get; set; }
        public string   reason    { get; set; }

        // From appointment has tests
        public string testCode { get; set; } //PK
        public string testDate { get; set; }
        public string results  { get; set; }

        // From vitals
        public int nurseID        { get; set; } //PK
        public string systolic    { get; set; }
        public string diastolic   { get; set; }
        public string temperature { get; set; }
        public string pulse       { get; set; }
        public string symptoms    { get; set; }
        public string diagnosis   { get; set; }


        // So user can see doctor name instead of just ID
        public string doctorFullName { get; set; }
        public string nurseFullName  { get; set; }
    }
}
