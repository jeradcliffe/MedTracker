using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTracker.Model;
using System.Data.SqlClient;


namespace MedTracker.DBA
{
    class ClinicEmployeesDAL
    {
        public static bool checkLoginCredentials(string username, string password)
        {

            string selectStatement = "SELECT COUNT(*) AS 'count' FROM clinicemployees " +
                "WHERE username = @username AND passwords = @password";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        selectCommand.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            //int count = selectCommand.ExecuteReader().FieldCount;
                            int count = 0;
                            if (reader.Read())
                            {
                                count = (int)reader["count"];
                            }

                            if (count == 1)
                                return true;
                            else
                                return false;
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
        }
    }
}