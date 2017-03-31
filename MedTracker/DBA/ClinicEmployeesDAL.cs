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

            SqlConnection connection = DBConnection.GetConnection();

            string selectStatement = "SELECT userName FROM clinicemployees " +
                "WHERE userName = @username && password = @password";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                int count = selectCommand.ExecuteNonQuery();
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
