using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class PatientDAL
    {
        public static List<Patient> GetSelectedPatients(DateTime dateOfBirth, string firstName, string lastName)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = DBConnection.GetConnection();
            string selectStatement =
                "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            // Note: DOB is saved as string in DB. However, date selector 
            // may be easier to use when asking for user input, so conversion
            // is necessary. Check to make sure that string comparison doesn't 
            // create any bugs. 
            selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToString("yyyy-MM-dd"));
            selectCommand.Parameters.AddWithValue("@firstName", firstName + "%");
            selectCommand.Parameters.AddWithValue("@lastName", lastName + "%");
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.peopleID      = (int)reader["peopleID"];
                    patient.patientID     = (int)reader["patientID"];
                    patient.firstName     = reader["firstName"].ToString();
                    patient.lastName      = reader["lastName"].ToString();
                    patient.dateOfBirth   = reader["dateOfBirth"].ToString();
                    patient.streetAddress = reader["streetAddress"].ToString();
                    patient.city          = reader["city"].ToString();
                    patient.state         = reader["state"].ToString();
                    patient.zip           = reader["zip"].ToString();
                    patient.phoneNumber   = reader["phoneNumber"].ToString();
                    patientList.Add(patient);
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return patientList;
        }

    }
}
