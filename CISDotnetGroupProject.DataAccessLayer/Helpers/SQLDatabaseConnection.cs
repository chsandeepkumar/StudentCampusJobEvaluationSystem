using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISDotnetGroupProject.DataAccessLayer.Helpers
{
    internal class StudentDatabaseConnection
    {
        SqlConnection _sqlConnection = null;
        private static String GetDatabaseConnectionstring()
        {
            var result= ConfigurationManager.ConnectionStrings["CISDotnetGroupProject.DataAccessLayer.Properties.Settings.CISStudentEvaluationSystemDatabase"];
            return result.ConnectionString;
        }

        internal SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetDatabaseConnectionstring());
        }

        internal SqlConnection OpenSQlDatabaseConnection()

        {
            _sqlConnection = new SqlConnection(GetDatabaseConnectionstring());
            _sqlConnection.Open();
            return _sqlConnection;
        }
        internal  void CloseSqlDatabaseConnection()
        {
            _sqlConnection.Close();
        }
        
    }
}
