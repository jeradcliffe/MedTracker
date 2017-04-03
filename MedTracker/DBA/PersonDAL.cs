using System;
using MedTracker.Model;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MedTracker.DBA
{
    class PersonDAL
    {
        public static int createPerson(Person newPerson)
        {
            int exitStatus = 0;

            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                "INSERT people " +
                    "(lastName, firstName, dateOfBirth, streetAddress, city, " +
                    "state, zip, phoneNumber)" +
                "VALUES " +
                    "(@lastName, @firstName, @dateOfBirth, @streetAddress, @city, " +
                    "@state, @zip, @phoneNumber)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@lastName", newPerson.lastName);
            insertCommand.Parameters.AddWithValue("@firstName", newPerson.firstName);
            insertCommand.Parameters.AddWithValue("@dateOfBirth", newPerson.dateOfBirth);
            insertCommand.Parameters.AddWithValue("@streetAddress", newPerson.streetAddress);
            insertCommand.Parameters.AddWithValue("@city", newPerson.city);
            insertCommand.Parameters.AddWithValue("@state", newPerson.state);
            insertCommand.Parameters.AddWithValue("@zip", newPerson.zip);
            insertCommand.Parameters.AddWithValue("@phoneNumber", newPerson.phoneNumber);

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
                for (int i = 0; i < ex.Errors.Count; i++)
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

        public static Person getPerson(int peopleID)
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
