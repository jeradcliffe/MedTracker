using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.Model
{
    /// <summary>
    /// Tried to keep the same names as they are posted in the DB
    /// to avoid any future confusion within the application.
    /// </summary>
    public class Person
    {

        // Type int in the DB
        public int peopleID         { get; set; }
        // Type varchar(45) in the DB
        public string firstName     { get; set; }
        // Type varchar(45) in the DB
        public string lastName      { get; set; }
        // Type varchar(45) in the DB
        public string dateOfBirth   { get; set; }
        // Type varchar(75) in the DB
        public string streetAddress { get; set; }
        // Type varchar(65) in the DB
        public string city          { get; set; }
        // Type varchar(2)  in the DB
        public string state         { get; set; }
        // Type varchar(5)  in the DB
        public string zip           { get; set; }
        // Type varchar(12) in the DB
        public string phoneNumber   { get; set; }

        public string ssn { get; set; }

        public string gender { get; set; }

        // IDs used by other tables that are linked
        // to the people table

        // Type int in the DB
        public int patientID        { get; set; }
        // Type int in the DB
        public int doctorID         { get; set; }
        // Type int in the DB
        public int nurseID          { get; set; }
        // Type int in the DB
        public int administratorID  { get; set; }

        // Full name of a person
        public string fullName      { get; set; }
    }
}
