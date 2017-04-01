using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedTracker.Model;

namespace MedTracker.DBA
{
    class AdministratorsDAL
    {
        public static bool checkIfAdministrators(string username)
        {
            string selectStatement = "SELECT COUNT(*) FROM administrators " +
                "WHERE userName = @username";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        int count = (int)selectCommand.ExecuteScalar();
                        if (count == 1)
                            return true;
                        else
                            return false;
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

        public static Administrators getAdministrator(string username)
        {
            Administrators adminstrator = new Administrators();
            string selectStatement = "SELECT * FROM administrators " +
                "WHERE userName = @username";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            int adminPeopleID = reader.GetOrdinal("peopleID");
                            int adminAdminID = reader.GetOrdinal("adminID");
                            int adminUsername = reader.GetOrdinal("userName");
                            if (reader.Read())
                            {
                                adminstrator.peopleID = (int)reader["adminPeopleID"];
                                adminstrator.adminID = (int)reader["adminAdminID"];
                                adminstrator.userName = reader.GetString(adminUsername);
                            }
                            else
                            {
                                adminstrator = null;
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
            return adminstrator;
        }
    }
}
