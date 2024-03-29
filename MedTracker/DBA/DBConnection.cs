﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTracker.DBA
{
    class DBConnection
    {

        /// <summary>
        /// Method to build an SqlConnection to allow access to our DB.
        /// </summary>
        /// <returns>SqlConnection to TechSupport DB</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "CS6232-g3";
            builder.IntegratedSecurity = true;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }

    }
}
