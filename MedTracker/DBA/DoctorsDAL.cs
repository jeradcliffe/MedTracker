using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MedTracker.Model;

namespace MedTracker.DBA
{
    class DoctorsDAL
    {
        public static bool checkIfDoctors(string username)
        {
            string selectStatement = "SELECT COUNT(*) FROM doctors " +
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
        public static Doctors getDoctor(string username)
        {
            Doctors doctor = new Doctors();
            string selectStatement = "SELECT * FROM doctors " +
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
                            int doctUsername = reader.GetOrdinal("userName");
                            if (reader.Read())
                            {
                                doctor.peopleID = (int)reader["peopleID"];
                                doctor.doctorID = (int)reader["doctorID"];
                                doctor.userName = reader.GetString(doctUsername);
                            }
                            else
                            {
                                doctor = null;
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
            return doctor;
        }

        /// <summary>
        /// Returns a list of doctors from our DB
        /// </summary>
        /// <returns>Returns doctorID and full name</returns>
        public static List<Person> GetDoctorList()
        {
            List<Person> doctorList = new List<Person>();
            string selectStatement =
                @"SELECT d.doctorID, d.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'fullName'
                  FROM doctors d
	                 JOIN people p ON d.peopleID = p.peopleID ";
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
                                Person doctor = new Person();
                                doctor.doctorID = (int)reader["doctorID"];
                                doctor.fullName = reader["fullName"].ToString();
                                doctorList.Add(doctor);
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
            return doctorList;
        }

        // Gets doctor information by doctorID
        public static Person GetDoctorByID(int doctorID)
        {
            Person doctor = new Person();
            string selectStatement =
                    @"SELECT ppl.*, d.doctorID 
                        FROM doctors d
	                        JOIN people ppl ON ppl.peopleID = d.peopleID 
                        WHERE doctorID = @doctorID; ";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@doctorID", doctorID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                doctor.peopleID  = (int)reader["peopleID"];
                                doctor.doctorID  = (int)reader["doctorID"];
                                doctor.firstName = reader["firstName"].ToString();
                                doctor.lastName  = reader["lastName"].ToString();
                            }
                            else
                            {
                                doctor = null;
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
            return doctor;
        }
    }
}
