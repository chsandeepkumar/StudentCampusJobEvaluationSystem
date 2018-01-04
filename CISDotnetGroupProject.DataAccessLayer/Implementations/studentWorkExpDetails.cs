using System;
using CISDotnetGroupProject.Models;
using CISDotnetGroupProject.DataAccessLayer.Helpers;
using System.Data.SqlClient;


namespace CISDotnetGroupProject.DataAccessLayer
{
    public class studentWorkExpDetails : IWorkExperienceDetails
    {
        StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();
        public int DeleteStudentDetail(int studentId)
        {
            throw new NotImplementedException();
        }

        public WorkExperienceDetails GetStudentWrkExpDetailsBy(int Id)
        {
            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                string _userCommandText = @"select *from Work_Experience where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", Id);

                SqlDataReader _resultStudentWrkExpDetails = _userSqlCommand.ExecuteReader();

                WorkExperienceDetails _studentWrkExpDetails = new WorkExperienceDetails();

                while (_resultStudentWrkExpDetails.Read())
                {
                    _studentWrkExpDetails.RecentCompanyYear = _resultStudentWrkExpDetails["RecentCompanyYear"].ToString();
                    _studentWrkExpDetails.RecentCompanyName = _resultStudentWrkExpDetails["RecentCompanyName"].ToString();
                    _studentWrkExpDetails.TotalYrsExp = (int)_resultStudentWrkExpDetails["TotalYrsExp"];
                    _studentWrkExpDetails.PreviousGA = _resultStudentWrkExpDetails["PreviousGA"].ToString();
                    _studentWrkExpDetails.PreGAFaculty = _resultStudentWrkExpDetails["PreGAFaculty"].ToString();
                    _studentWrkExpDetails.FacultyRef = _resultStudentWrkExpDetails["FacultyRef"].ToString();
                }

                return _studentWrkExpDetails;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public string insertWorkExperience(WorkExperienceDetails workExpDetails)
        {
           

            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();

                
                string _userCommandText = @"Insert INTO Work_Experience (StudentId, RecentCompanyYear, RecentCompanyName, TotalYrsExp,  PreviousGA,  PreGAFaculty,FacultyRef) values(@StudentId, @RecentCompanyYear, @RecentCompanyName, @TotalYrsExp,  @PreviousGA,  @PreGAFaculty, @FacultyRef) ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", workExpDetails.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@RecentCompanyYear", workExpDetails.RecentCompanyYear);
                _userSqlCommand.Parameters.AddWithValue("@RecentCompanyName", workExpDetails.RecentCompanyName);
                _userSqlCommand.Parameters.AddWithValue("@TotalYrsExp", Convert.ToInt32(workExpDetails.TotalYrsExp));
                _userSqlCommand.Parameters.AddWithValue("@PreviousGA", workExpDetails.PreviousGA);
                _userSqlCommand.Parameters.AddWithValue("@PreGAFaculty", workExpDetails.PreGAFaculty);
                _userSqlCommand.Parameters.AddWithValue("@FacultyRef", workExpDetails.FacultyRef);

                _userSqlCommand.ExecuteNonQuery();

                return "Details Entered Successfully";
            }
            catch (Exception Ex)
            {
                return Ex.Message;

            }
            finally {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }

        }

        public string UpDateStudentWrkExpDetails(WorkExperienceDetails studentWrkExpDetail)
        {

            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();


                string _userCommandText = @"Update Work_Experience Set
                                                        RecentCompanyYear = @RecentCompanyYear,
                                                        RecentCompanyName = @RecentCompanyName,
                                                        TotalYrsExp = @TotalYrsExp,
                                                        PreviousGA = @PreviousGA,
                                                        PreGAFaculty = @PreGAFaculty,
                                                        FacultyRef = @FacultyRef 
                                                    where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", studentWrkExpDetail.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@RecentCompanyYear", studentWrkExpDetail.RecentCompanyYear);
                _userSqlCommand.Parameters.AddWithValue("@RecentCompanyName", studentWrkExpDetail.RecentCompanyName);
                _userSqlCommand.Parameters.AddWithValue("@TotalYrsExp", Convert.ToInt32(studentWrkExpDetail.TotalYrsExp));
                _userSqlCommand.Parameters.AddWithValue("@PreviousGA", studentWrkExpDetail.PreviousGA);
                _userSqlCommand.Parameters.AddWithValue("@PreGAFaculty", studentWrkExpDetail.PreGAFaculty);
                _userSqlCommand.Parameters.AddWithValue("@FacultyRef", studentWrkExpDetail.FacultyRef);

                _userSqlCommand.ExecuteNonQuery();

                return "Details Entered Successfully";
            }
            catch (Exception Ex)
            {
                return Ex.Message;

            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }
    }
}
