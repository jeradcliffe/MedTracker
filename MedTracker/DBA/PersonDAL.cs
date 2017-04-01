using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.Model;
using System.Data.SqlClient;

namespace MedTracker.DBA
{
    class PersonDAL
    {
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
