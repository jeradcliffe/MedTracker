using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class TestsDAL
    {
        public static List<Appointment> GetAppointmentTests(DateTime appointmentDate, int doctorID, int patientID)
        {
            List<Appointment> testList = new List<Appointment>();
            string selectStatement =
                  @"SELECT aht.*
                    FROM appointment_has_tests aht
                    WHERE aht.appointment_patientID = @patientID
	                  AND aht.appointment_doctorID  = @doctorID
	                  AND aht.appointment_date      = @appointmentDate; ";
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
                        selectCommand.Parameters.AddWithValue("@doctorID", doctorID);
                        selectCommand.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        using (reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment test = new Appointment();
                                test.date      = (DateTime)reader["appointment_date"];
                                test.doctorID  = (int)reader["appointment_doctorID"];
                                test.patientID = (int)reader["appointment_patientID"];
                                test.testCode  = reader["tests_testCode"].ToString();
                                test.testDate  = (DateTime)reader["testDate"];
                                test.results   = reader["results"].ToString();
                                testList.Add(test);
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
            return testList;
        }

        public static bool UpdateTestResults(Appointment oldTest, string newResults)
        {
            string updateStatement =
                @"UPDATE appointment_has_tests SET
	                results = @newResults
                  WHERE appointment_date        = @oldApptDate
                    AND appointment_doctorID    = @oldApptDoctorID
                    AND appointment_patientID   = @oldApptPatientID
                    AND tests_testCode          = @oldTestCode
                    AND testDate                = @oldTestDate
                    AND results                 = @oldResults; ";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@oldApptDate", oldTest.date);
                        updateCommand.Parameters.AddWithValue("@oldApptDoctorID", oldTest.doctorID);
                        updateCommand.Parameters.AddWithValue("@oldApptPatientID", oldTest.patientID);
                        updateCommand.Parameters.AddWithValue("@oldTestCode", oldTest.testCode);
                        updateCommand.Parameters.AddWithValue("@oldTestDate", oldTest.testDate);
                        updateCommand.Parameters.AddWithValue("@oldResults", oldTest.results);

                        updateCommand.Parameters.AddWithValue("@newResults", newResults);

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
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
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static List<Appointment> GetTests()
        {
            List<Appointment> testList = new List<Appointment>();
            string selectStatement =
                @"SELECT * FROM tests; ";
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
                                Appointment test = new Appointment();
                                test.testCode = reader["testCode"].ToString();
                                test.testName = reader["testName"].ToString();
                                testList.Add(test);
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
            return testList;
        }

        public static bool AddTest(Appointment appointmentTest)
        {
            string insertStatement =
                                @"INSERT INTO appointment_has_tests
	                              VALUES (@aptDate, @doctorID, @patientID, @testCode, @testDate, @results)";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@aptDate", appointmentTest.date);
                        insertCommand.Parameters.AddWithValue("@doctorID", appointmentTest.doctorID);
                        insertCommand.Parameters.AddWithValue("@patientID", appointmentTest.patientID);
                        insertCommand.Parameters.AddWithValue("@testCode", appointmentTest.testCode);
                        insertCommand.Parameters.AddWithValue("@testDate", appointmentTest.testDate);
                        insertCommand.Parameters.AddWithValue("@results", appointmentTest.results);

                        int count = insertCommand.ExecuteNonQuery();
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
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
