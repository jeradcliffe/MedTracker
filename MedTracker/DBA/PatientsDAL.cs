using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTracker.DBA
{
    class PatientsDAL
    {
        public static int CreatePatient(Person newPatient)
        {
            int exitStatus = 0;
            
            //first adding to person table
            int personCreationStatus = PersonDAL.CreatePerson(newPatient);            

            //if person creation is successful, proceed to create patient
            if (personCreationStatus == 0)
            {
                SqlConnection connection = DBConnection.GetConnection();

                string insertStatement =
                    "INSERT patients (peopleID) VALUES (@peopleID)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

                int newPersonsPeopleID = PersonDAL.getPeopleID(newPatient.firstName, newPatient.lastName, newPatient.dateOfBirth);

                insertCommand.Parameters.AddWithValue("@peopleID", newPersonsPeopleID);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    exitStatus = 0;
                }
                catch (SqlException ex)
                {
                    exitStatus = 1;
                    StringBuilder errorDetails = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorDetails.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "Error Number: " + ex.Errors[i].Number + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorDetails.ToString(), "SQL Exception");
                }
            }
            else
            {
                exitStatus = 1;
            }

            return exitStatus;
        }

        public static int UpdatePatient(Person patientWithOldData, Person updatedPatient)
        {
            int exitStatus = 1;
            bool personIsPatient = CheckIfPersonIsPatient(patientWithOldData);

            if (personIsPatient)
            {
                exitStatus = PersonDAL.UpdatePerson(patientWithOldData, updatedPatient);
            }

            return exitStatus;
        }

        public static bool CheckIfPersonIsPatient(Person possiblePatient)
        {
            bool personIsPatient = true;

            string selectStatement =
                "SELECT patientID " +
                "FROM patients " +
                "WHERE peopleID = @peopleID";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@peopleID", possiblePatient.peopleID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    string returnedPatientID = reader["patientID"].ToString();
                                }
                                catch (Exception ex)
                                {
                                    personIsPatient = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorDetails = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorDetails.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "Error Number: " + ex.Errors[i].Number + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorDetails.ToString(), "SQL Exception");
            }

            return personIsPatient;
        }

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
                                patient.ssn = reader["ssn"].ToString();
                                patient.gender = reader["gender"].ToString();
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
