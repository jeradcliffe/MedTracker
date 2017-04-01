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
    }
}
