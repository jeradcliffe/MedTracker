using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class PatientsDAL
    {
        /// <summary>
        /// Used to search for patients in the database according to the DOB, first name, and last name.
        /// </summary>
        /// <returns>A list of patients matching the search results.</returns>
        public static List<Patient> GetSelectedPatients(string dateOfBirth, string firstName, string lastName)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = DBConnection.GetConnection();
            string selectStatement =
                    @"SELECT ppl.*,  pt.patientID
                      FROM patients pt
                        JOIN people ppl ON ppl.peopleID = pt.peopleID
                      WHERE ppl.firstName LIKE @firstName
                        AND ppl.lastName  LIKE @lastName
                        AND ppl.dateOfBirth LIKE @dateOfBirth
                      ORDER BY ppl.lastName; ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth + "%");
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
