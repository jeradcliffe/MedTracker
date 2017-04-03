using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class VitalsDAL
    {
        /// <summary>
        /// Gets all of our vitals information from the appointment
        /// </summary>
        /// <returns></returns>
        public static Appointment GetAppointmentVitals(DateTime appointmentDate, int doctorID, int patientID)
        {
            Appointment vitals = new Appointment();
            string selectStatement =
                  @"SELECT v.*, CONCAT(ppl.firstName, ' ', ppl.lastName) AS 'Nurse'
                    FROM vitals v
	                    JOIN nurses n ON v.nurses_nurseID = n.nurseID
	                    JOIN people ppl ON n.peopleID = ppl.peopleID
                    WHERE v.appointment_patientID = @patientID
	                  AND v.appointment_doctorID  = @doctorID
	                  AND v.appointment_date      = @appointmentDate; ";
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
                            if (reader.Read())
                            {
                                vitals.systolic = reader["systolic"].ToString();
                                vitals.diastolic = reader["diastolic"].ToString();
                                vitals.temperature = reader["temperature"].ToString();
                                vitals.pulse = reader["pulse"].ToString();
                                vitals.symptoms = reader["symptoms"].ToString();
                                vitals.diagnosis = reader["diagnosis"].ToString();
                                vitals.nurseFullName = reader["Nurse"].ToString();

                            }
                            else
                            {
                                vitals = null;
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

            return vitals;
        }

        internal static bool AddVitals(Appointment appointmentVitals)
        {
            string insertStatement =
                    @"INSERT INTO vitals
	                    VALUES (@date, @doctorID, @patientID, @nurseID, @systolic, @diastolic, @temperature, @pulse, @symptoms, @diagnosis)";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@date", appointmentVitals.date);
                        insertCommand.Parameters.AddWithValue("@doctorID", appointmentVitals.doctorID);
                        insertCommand.Parameters.AddWithValue("@patientID", appointmentVitals.patientID);
                        insertCommand.Parameters.AddWithValue("@nurseID", appointmentVitals.nurseID);
                        insertCommand.Parameters.AddWithValue("@systolic", appointmentVitals.systolic);
                        insertCommand.Parameters.AddWithValue("@diastolic", appointmentVitals.diastolic);
                        insertCommand.Parameters.AddWithValue("@temperature", appointmentVitals.temperature);
                        insertCommand.Parameters.AddWithValue("@pulse", appointmentVitals.pulse);
                        insertCommand.Parameters.AddWithValue("@symptoms", appointmentVitals.symptoms);
                        insertCommand.Parameters.AddWithValue("@diagnosis", appointmentVitals.diagnosis);

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
