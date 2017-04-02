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
        public static List<Person> GetSelectedPatients(string dateOfBirth, string firstName, string lastName)
        {
            List<Person> patientList = new List<Person>();
            string selectStatement =
                    @"SELECT ppl.*,  pt.patientID
                      FROM patients pt
                        JOIN people ppl ON ppl.peopleID = pt.peopleID
                      WHERE ppl.firstName LIKE @firstName
                        AND ppl.lastName  LIKE @lastName
                        AND ppl.dateOfBirth LIKE @dateOfBirth
                      ORDER BY ppl.lastName, ppl.firstName; ";            
            SqlDataReader reader = null;
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth + "%");
                        selectCommand.Parameters.AddWithValue("@firstName", firstName + "%");
                        selectCommand.Parameters.AddWithValue("@lastName", lastName + "%");

                        using (reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Person patient = new Person();
                                patient.peopleID = (int)reader["peopleID"];
                                patient.patientID = (int)reader["patientID"];
                                patient.firstName = reader["firstName"].ToString();
                                patient.lastName = reader["lastName"].ToString();
                                patient.dateOfBirth = reader["dateOfBirth"].ToString();
                                patient.streetAddress = reader["streetAddress"].ToString();
                                patient.city = reader["city"].ToString();
                                patient.state = reader["state"].ToString();
                                patient.zip = reader["zip"].ToString();
                                patient.phoneNumber = reader["phoneNumber"].ToString();
                                patientList.Add(patient);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
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

        /// <summary>
        /// Used to retrieve a patient from the DB according to their PatientID
        /// </summary>
        /// <returns>A single patient.</returns>
        public static Person GetPatientByID(int patientID)
        {
            Person patient = new Person();
            string selectStatement =
                    @"SELECT ppl.*, pt.patientID 
                        FROM patients pt
	                        JOIN people ppl ON ppl.peopleID = pt.peopleID 
                        WHERE patientID = @patientID; ";
            SqlDataReader reader = null;
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientID", patientID);
                        using (reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
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
                            }
                            else
                            {
                                patient = null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return patient;
        }

    }
}
