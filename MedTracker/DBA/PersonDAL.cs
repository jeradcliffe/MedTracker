using System;
using MedTracker.Model;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace MedTracker.DBA
{
    class PersonDAL
    {
        public static int CreatePerson(Person newPerson)
        {
            int exitStatus = 0;

            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                "INSERT people " +
                    "(lastName, firstName, dateOfBirth, streetAddress, city, " +
                    "state, zip, phoneNumber, gender, ssn)" +
                "VALUES " +
                    "(@lastName, @firstName, @dateOfBirth, @streetAddress, @city, " +
                    "@state, @zip, @phoneNumber, @gender, @ssn)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@lastName", newPerson.lastName);
            insertCommand.Parameters.AddWithValue("@firstName", newPerson.firstName);
            insertCommand.Parameters.AddWithValue("@dateOfBirth", newPerson.dateOfBirth);
            insertCommand.Parameters.AddWithValue("@streetAddress", newPerson.streetAddress);
            insertCommand.Parameters.AddWithValue("@city", newPerson.city);
            insertCommand.Parameters.AddWithValue("@state", newPerson.state);
            insertCommand.Parameters.AddWithValue("@zip", newPerson.zip);
            insertCommand.Parameters.AddWithValue("@phoneNumber", newPerson.phoneNumber);
            insertCommand.Parameters.AddWithValue("@gender", newPerson.gender);
            insertCommand.Parameters.AddWithValue("@ssn", newPerson.ssn);

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

            return exitStatus;
        }

        public static int UpdatePerson(Person personWithOldData, Person updatedPerson)
        {
            int exitStatus = 1;
            SqlConnection connection = DBConnection.GetConnection();
            SqlTransaction updateTran = null;
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = connection;

            updateCommand.CommandText =
                "UPDATE people " +
                "SET firstName = @updatedFirstName, " +
                  "lastName = @updatedLastName, " +
                  "dateOfBirth = @updatedDateOfBirth, " +
                  "streetAddress = @updatedStreetAddress, " +
                  "city = @updatedCity, " +
                  "state = @updatedState, " +
                  "zip = @updatedZip, " +
                  "phoneNumber = @updatedPhoneNumber, " +
                  "gender = @updatedGender, " +
                  "ssn = @updatedSSN " +
                "WHERE peopleID = @peopleID";

            updateCommand.Parameters.AddWithValue("@updatedFirstName", updatedPerson.firstName);
            updateCommand.Parameters.AddWithValue("@updatedLastName", updatedPerson.lastName);
            updateCommand.Parameters.AddWithValue("@updatedDateOfBirth", updatedPerson.dateOfBirth);
            updateCommand.Parameters.AddWithValue("@updatedStreetAddress", updatedPerson.streetAddress);
            updateCommand.Parameters.AddWithValue("@updatedCity", updatedPerson.city);
            updateCommand.Parameters.AddWithValue("@updatedState", updatedPerson.state);
            updateCommand.Parameters.AddWithValue("@updatedZip", updatedPerson.zip);
            updateCommand.Parameters.AddWithValue("@updatedPhoneNumber", updatedPerson.phoneNumber);
            updateCommand.Parameters.AddWithValue("@peopleID", personWithOldData.peopleID);
            updateCommand.Parameters.AddWithValue("@updatedGender", updatedPerson.gender);
            updateCommand.Parameters.AddWithValue("@updatedSSN", updatedPerson.ssn);

            try
            {
                connection.Open();
                updateTran = connection.BeginTransaction(IsolationLevel.Serializable);
                updateCommand.Transaction = updateTran;

                int successfulUpdatesCount = updateCommand.ExecuteNonQuery();

                if (successfulUpdatesCount > 0)
                {
                    updateTran.Commit();
                    exitStatus = 0;
                }
                else
                {
                    updateTran.Rollback();
                    exitStatus = 1;
                }
            }
            catch (SqlException ex)
            {
                exitStatus = 2;
                if (updateTran != null)
                {
                    updateTran.Rollback();
                }

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
            finally
            {
                connection.Close();
            }

            return exitStatus;
        }

        public static int getPeopleID(string firstName, string lastName, string dateOfBirth)
        {
            int matchingPeopleID = 0;

            string selectStatement =
                "SELECT peopleID " +
                "FROM people " +
                "WHERE firstName = @firstName " +
                    "AND lastName = @lastName " +
                    "AND dateOfBirth = @dateOfBirth";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@firstName", firstName);
                        selectCommand.Parameters.AddWithValue("@lastName", lastName);
                        selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string peopleIDAsString = reader["peopleID"].ToString();
                                Int32.TryParse(peopleIDAsString, out matchingPeopleID);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorDetails = new StringBuilder();
                for (int i = 0; i<ex.Errors.Count; i++)
                {
                    errorDetails.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "Error Number: " + ex.Errors[i].Number + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorDetails.ToString(), "SQL Exception");
            }

            return matchingPeopleID;
        }

        public static Person GetPerson(int peopleID)
        {
            Person person = new Model.Person();
            string selectStatement = "SELECT * FROM people " +
                "WHERE peopleID = @peopleID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@peopleID", peopleID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            int perLastName = reader.GetOrdinal("lastName");
                            int perFirstName = reader.GetOrdinal("firstName");
                            int perDateOfBirth = reader.GetOrdinal("dateOfBirth");
                            int perStreetAddress = reader.GetOrdinal("streetAddress");
                            int perCity = reader.GetOrdinal("city");
                            int perState = reader.GetOrdinal("state");
                            int perZip = reader.GetOrdinal("zip");
                            int perPhoneNumber = reader.GetOrdinal("phoneNumber");
                            int perGender = reader.GetOrdinal("gender");
                            int perSSN = reader.GetOrdinal("ssn");

                            if (reader.Read())
                            {
                                person.peopleID = (int)reader["peopleID"];
                                person.lastName = reader.GetString(perLastName);
                                person.firstName = reader.GetString(perFirstName);
                                person.dateOfBirth = reader.GetString(perDateOfBirth);
                                person.streetAddress = reader.GetString(perStreetAddress);
                                person.city = reader.GetString(perCity);
                                person.state = reader.GetString(perState);
                                person.zip = reader.GetString(perZip);
                                person.phoneNumber = reader.GetString(perPhoneNumber);
                                person.gender = reader.GetString(perGender);
                                person.ssn = reader.GetString(perSSN);
                            }
                            else
                            {
                                person = null;
                            }
                            connection.Close();
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
            return person;
        }   
    }
}
