using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class PatientDAL
    {
        public static List<Patient> GetSelectedPatients(DateTime dateOfBirth, string firstName, string lastName)
        {
            List<Patient> patientList = new List<Patient>();
            SqlConnection connection = DBConnection.GetConnection();
            // '@' sign is used to refer to a verbatim string literal
            // https://msdn.microsoft.com/en-us/library/aa691090(v=vs.71).aspx
            // Used to replace usual strings with the constant '+' sign at each new line
            string selectStatement = @"
                    SELECT  ppl.peopleID,
	                        pt.patientID,
	                        ppl.firstName,
	                        ppl.lastName,
	                        ppl.dateOfBirth,
	                        ppl.streetAddress,
	                        ppl.city,
	                        ppl.state,
	                        ppl.zip,
	                        ppl.phoneNumber
                    FROM patients pt 
	                    JOIN people ppl ON ppl.peopleID = pt.peopleID
                    WHERE (ppl.dateOfBirth LIKE @dateOfBirth) 
                        AND (ppl.firstName LIKE @firstName) 
                        AND (pp.lastName   LIKE @lastName)
                    ORDER BY ppl.lastName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            // Note: DOB is string in DOB, but searched by Date in forms
            selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToString("yyyy-MM-dd"));
            selectCommand.Parameters.AddWithValue("@firstName", firstName + "%");
            selectCommand.Parameters.AddWithValue("@lastName", lastName + "%");
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.peopleID      = (int)reader["peopleID"];
                    patient.patientID     = (int)reader["patientID"];
                    patient.firstName     = reader["firstName"].ToString();
                    patient.lastName      = reader["lastName"].ToString();
                    patient.dateOfBirth   = reader["dateOfBirth"].ToString();
                    patient.streetAddress = reader["streetAddress"].ToString();
                    patient.city          = reader["city"].ToString();
                    patient.state         = reader["state"].ToString();
                    patient.zip           = reader["zip"].ToString();
                    patient.phoneNumber   = reader["phoneNumber"].ToString();
                    patientList.Add(patient);
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return patientList;
        }

    }
}
