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
                                vitals.date          = (DateTime)reader["appointment_date"];
                                vitals.doctorID      = (int)reader["appointment_doctorID"];
                                vitals.patientID     = (int)reader["appointment_patientID"];
                                vitals.nurseID       = (int)reader["nurses_nurseID"];
                                vitals.systolic      = reader["systolic"].ToString();
                                vitals.diastolic     = reader["diastolic"].ToString();
                                vitals.temperature   = reader["temperature"].ToString();
                                vitals.pulse         = reader["pulse"].ToString();
                                vitals.symptoms      = reader["symptoms"].ToString();
                                vitals.diagnosis     = reader["diagnosis"].ToString();
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

        public static bool AddVitals(Appointment appointmentVitals)
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

        /// <summary>
        /// Used to update diagnosis in the Vitals table in our DB
        /// </summary>
        /// <param name="oldAppointment">Original vitals information.</param>
        /// <param name="newAppointment">New diagnosis.</param>
        /// <returns></returns>
        public static bool UpdateVitalsDiagnosis(Appointment oldVitals, string newDiagnosis)
        {
            string updateStatement =
                @"UPDATE vitals SET
	                diagnosis = @newDiagnosis
                  WHERE appointment_date        = @oldApptDate
                    AND appointment_doctorID    = @oldApptDoctorID
                    AND appointment_patientID   = @oldApptPatientID
                    AND nurses_nurseID          = @oldApptNurseID
                    AND systolic                = @oldSystolic
                    AND diastolic               = @oldDiastolic
                    AND temperature             = @oldTemperature
                    AND pulse                   = @oldPulse
                    AND symptoms                = @oldSymptoms
                    AND diagnosis               = @oldDiagnosis; ";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@oldApptDate", oldVitals.date);
                        updateCommand.Parameters.AddWithValue("@oldApptDoctorID", oldVitals.doctorID);
                        updateCommand.Parameters.AddWithValue("@oldApptPatientID", oldVitals.patientID);
                        updateCommand.Parameters.AddWithValue("@oldApptNurseID", oldVitals.nurseID);
                        updateCommand.Parameters.AddWithValue("@oldSystolic", oldVitals.systolic);
                        updateCommand.Parameters.AddWithValue("@oldDiastolic", oldVitals.diastolic);
                        updateCommand.Parameters.AddWithValue("@oldTemperature", oldVitals.temperature);
                        updateCommand.Parameters.AddWithValue("@oldPulse", oldVitals.pulse);
                        updateCommand.Parameters.AddWithValue("@oldSymptoms", oldVitals.symptoms);
                        updateCommand.Parameters.AddWithValue("@oldDiagnosis", oldVitals.diagnosis);

                        updateCommand.Parameters.AddWithValue("@newDiagnosis", newDiagnosis);

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
    }
}
