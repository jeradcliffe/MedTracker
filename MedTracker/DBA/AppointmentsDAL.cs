using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class AppointmentsDAL
    {
        /// <summary>
        /// Used to retrieve all appointments relative to a particular patient
        /// </summary>
        public static List<Appointment> GetAppointmentsByPatient(int patientID)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            string selectStatement =
                    @"SELECT apt.*, CONCAT(p.firstName, ' ', p.lastName) AS 'Doctor'
                    FROM appointment apt
	                    JOIN patients pt ON apt.patientID = pt.patientID
	                    JOIN doctors d   ON d.doctorID    = apt.doctorID
	                    JOIN people p    ON p.peopleID    = d.peopleID
                    WHERE pt.patientID = @patientID
                    ORDER BY apt.date DESC; ";
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
                        using (reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment appointment = new Appointment();
                                appointment.date           = (DateTime)reader["date"];
                                appointment.doctorID       = (int)reader["doctorID"];
                                appointment.doctorFullName = reader["Doctor"].ToString();
                                appointment.patientID      = (int)reader["patientID"];
                                appointment.reason         = reader["reasonForVisit"].ToString();
                                appointmentList.Add(appointment);

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
            return appointmentList;
        }

        /// <summary>
        /// Used to retrieve add an appointment to the DB
        /// </summary>
        public static Boolean AddAppointment(Appointment appointment)
        {
            string insertStatement =
                    @"INSERT INTO appointment
	                    VALUES (@date, @doctorID, @patientID, @reason)";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@date",      appointment.date);
                        insertCommand.Parameters.AddWithValue("@doctorID",  appointment.doctorID);
                        insertCommand.Parameters.AddWithValue("@patientID", appointment.patientID);
                        insertCommand.Parameters.AddWithValue("@reason",    appointment.reason);

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
        /// Used to update an appointment in our DB
        /// </summary>
        /// <param name="oldAppointment">Original appointment information.</param>
        /// <param name="newAppointment">Appointment information we want to update our DB with.</param>
        /// <returns></returns>
        public static bool UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            string updateStatement =
                @"UPDATE appointment SET
	                date = @newdate,
	                doctorID = @newdoctorID,
	                patientID = @newpatientID, 
	                reasonForVisit = @newreason
                  WHERE date = @olddate
	                AND doctorID = @olddoctorID
	                AND patientID = @oldpatientID 
	                AND reasonForVisit = @oldreason; ";
            SqlConnection connection = null;
            try
            {
                using (connection = DBConnection.GetConnection()) {
                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@olddate", oldAppointment.date);
                        updateCommand.Parameters.AddWithValue("@olddoctorID", oldAppointment.doctorID);
                        updateCommand.Parameters.AddWithValue("@oldpatientID", oldAppointment.patientID);
                        updateCommand.Parameters.AddWithValue("@oldreason", oldAppointment.reason);

                        updateCommand.Parameters.AddWithValue("@newdate", newAppointment.date);
                        updateCommand.Parameters.AddWithValue("@newdoctorID", newAppointment.doctorID);
                        updateCommand.Parameters.AddWithValue("@newpatientID", newAppointment.patientID);
                        updateCommand.Parameters.AddWithValue("@newreason", newAppointment.reason);

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
                                //vitals.date         = (DateTime)reader["appointment_date"];
                                //vitals.doctorID     = (int)reader["appointment_doctorID"];
                                //vitals.patientID    = (int)reader["appointment_patientID"];
                                //vitals.nurseID      = (int)reader["nurses_nurseID"];
                                vitals.systolic     = reader["systolic"].ToString();
                                vitals.diastolic    = reader["diastolic"].ToString();
                                vitals.temperature  = reader["temperature"].ToString();
                                vitals.pulse        = reader["pulse"].ToString();
                                vitals.symptoms     = reader["symptoms"].ToString();
                                vitals.diagnosis    = reader["diagnosis"].ToString();
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
                                test.testCode = reader["tests_testCode"].ToString();
                                test.testCode = reader["testDate"].ToString();
                                test.testCode = reader["results"].ToString();
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
    }
}
