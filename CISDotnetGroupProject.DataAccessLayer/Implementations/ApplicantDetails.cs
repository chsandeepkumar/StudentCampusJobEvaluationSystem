using CISDotnetGroupProject.DataAccessLayer.Helpers;
using CISDotnetGroupProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public class ApplicantDetails : IApplicantDetails
    {
        StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();

        public List<ApplicantScores> GetApplicantScoreDetails()
        {
            try
            {
                var _connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                SqlCommand _sqlCommand = new SqlCommand("usp_GetAllApplicantPointDetails", _connection);

                _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                var _applicantDetailsreader = _sqlCommand.ExecuteReader();
                List<ApplicantScores> _listOfApplicants = new List<ApplicantScores>();

                while (_applicantDetailsreader.Read())
                {
                    ApplicantScores _applicantscores = new ApplicantScores
                    {
                        StudentId = int.Parse(_applicantDetailsreader["StudentID"].ToString()),
                        Name = _applicantDetailsreader["FirstName"].ToString(),
                        DateOfBirth = _applicantDetailsreader["DateOfBirth"].ToString(),
                        GREScore = Convert.ToDecimal((_applicantDetailsreader["GRE_Score"].ToString())),
                        IELTSScore = Convert.ToDecimal((_applicantDetailsreader["IELTS_Score"].ToString())),
                        GraduationGPA = Convert.ToDecimal((_applicantDetailsreader["Graduation_GPA"] == System.DBNull.Value) ? "0.00" : Convert.ToString(_applicantDetailsreader["Graduation_GPA"])),
                        UnderGradGPA = Convert.ToDecimal(((_applicantDetailsreader["UnderGrad_GPA"] == System.DBNull.Value) ? "0.00" : Convert.ToString(_applicantDetailsreader["UnderGrad_GPA"]))),
                        TotalYrsExperience = int.Parse(_applicantDetailsreader["TotalYrsExp"].ToString())
                    };
                    _listOfApplicants.Add(_applicantscores);
                }

                return _listOfApplicants;

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public void GetApplicantDetails(int applicationId)
        {
            throw new NotImplementedException();
        }


        public  DataTable GetGREPoints()
        {
            try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [Score],[Points] from GREScorepoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetIELTSpoints()
        {
             try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [Score],[Points] from IELTSScorePoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public DataTable GetAgebasedpoints()
        {
            try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [Age],[Points] from Agebasedpoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        
        public DataTable GetUnderGradPoints()
        {
            try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [GPA],[Points] from UnderGradGPAPoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public DataTable GetGradPoints()
        {
            try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [GPA],[Points] from GradGPAPoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }
        public DataTable GetWorkExperiencePoints()
        {
            try
            {
                var connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();
                string sqlCommand = "select [YearsOfExperience],[Points] from WorkExperienceScorePoints";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                DataSet datasetobject = new DataSet();
                adapter.Fill(datasetobject);
                return datasetobject.Tables[0];
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }
    }
}
