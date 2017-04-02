using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedTracker.Model;

namespace MedTracker.DBA
{
    class NursesDAL
    {
        public static bool checkIfNurses(string username)
        {
            string selectStatement = "SELECT COUNT(*) FROM nurses " + 
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

        public static Nurses getNurse(string username)
        {
            Nurses nurse = new Nurses();
            string selectStatement = "SELECT * FROM nurses " +
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
                            int nurUsername = reader.GetOrdinal("userName");
                            if (reader.Read())
                            {
                                nurse.peopleID = (int)reader["peopleID"];
                                nurse.nurseID = (int)reader["nurseID"];
                                nurse.userName = reader.GetString(nurUsername);
                            }
                            else
                            {
                                nurse = null;
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
            return nurse;
        }

        /// <summary>
        /// Returns a list of nurses from our DB
        /// </summary>
        /// <returns>Returns nurseID and full name</returns>
        public static List<Person> GetNurseList()
        {
            List<Person> nurseList = new List<Person>();
            string selectStatement =
                @"SELECT n.nurseID, n.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'fullName'
                  FROM nurses n
	                 JOIN people p ON n.peopleID = p.peopleID ";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Person nurse = new Person();
                                nurse.nurseID = (int)reader["nurseID"];
                                nurse.fullName = reader["fullName"].ToString();
                                nurseList.Add(nurse);
                            }
                            reader.Close();
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
            return nurseList;
        }
    }
}
