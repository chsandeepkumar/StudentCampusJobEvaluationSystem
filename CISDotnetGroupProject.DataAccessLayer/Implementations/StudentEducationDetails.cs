using System;
using CISDotnetGroupProject.Models;
using CISDotnetGroupProject.DataAccessLayer.Helpers;
using System.Data.SqlClient;


namespace CISDotnetGroupProject.DataAccessLayer
{
    public class StudentEducationDetails : IApplicantEducationalDetails
    {


        StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();

        public int DeleteStudentEduDetail(int studentId)
        {
            throw new NotImplementedException();
        }

        public StudentEducationDetails GetAllStudentEduDetails()
        {
            throw new NotImplementedException();
        }

        public EducationDetails GetStudentEduDetailsBy(int Id)
        {

            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                string _userCommandText = @"select *from Student_Education where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", Id);

                SqlDataReader _resultStudentEduDetails = _userSqlCommand.ExecuteReader();

                EducationDetails _studentEduDetails = new EducationDetails();

                while (_resultStudentEduDetails.Read())
                {
                    _studentEduDetails.UnderGrad_Department = _resultStudentEduDetails["UnderGrad_Department"].ToString();
                    _studentEduDetails.UnderGrad_Year = (int)_resultStudentEduDetails["UnderGrad_Year"];
                    _studentEduDetails.UnderGrad_University = _resultStudentEduDetails["UnderGrad_University"].ToString();
                    _studentEduDetails.UnderGrad_GPA = Convert.ToDecimal(_resultStudentEduDetails["UnderGrad_GPA"]);
                    //  if (!string.IsNullOrEmpty(_resultStudentEduDetails["AddressL2"].ToString())) { _studentDetails.AddressL2 = _resultStudentEduDetails["AddressL2"].ToString(); }
                    _studentEduDetails.Graduation_Department = _resultStudentEduDetails["Graduation_Department"].ToString();
                    _studentEduDetails.Graduation_Year = (int)_resultStudentEduDetails["Graduation_Year"];
                    _studentEduDetails.Graduation_University = _resultStudentEduDetails["Graduation_University"].ToString();
                    _studentEduDetails.Graduation_GPA = Convert.ToDecimal(_resultStudentEduDetails["Graduation_GPA"]);
                    _studentEduDetails.GRE_Score = Convert.ToDecimal(_resultStudentEduDetails["GRE_Score"].ToString());
                    _studentEduDetails.IELTS_Score = Convert.ToDecimal(_resultStudentEduDetails["IELTS_Score"].ToString());
                }

                return _studentEduDetails;

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

        public int insertEducationDetails(EducationDetails eduDetails)
        {
            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                string _userCommandText = @"Insert INTO Student_Education ( StudentId, UnderGrad_Department, UnderGrad_Year, UnderGrad_University, UnderGrad_GPA, Graduation_Department, Graduation_Year, Graduation_University, Graduation_GPA , GRE_Score, IELTS_Score ) 
                                                values(  @StudentId , @UnderGradDepartment, @UnderGradYear, @UnderGradUniversity, @UnderGradGPA, @GraduationDepartment, @GraduationYear, @GraduationUniversity,@GraduationGPA ,@GREScore, @IELTSScore) ";

                _userSqlCommand.CommandText = _userCommandText;



                _userSqlCommand.Parameters.AddWithValue("@StudentId", eduDetails.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradDepartment", eduDetails.UnderGrad_Department);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradYear", Convert.ToInt32(eduDetails.UnderGrad_Year));
                _userSqlCommand.Parameters.AddWithValue("@UnderGradUniversity", eduDetails.UnderGrad_University);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradGPA", Convert.ToDecimal(eduDetails.UnderGrad_GPA));
                _userSqlCommand.Parameters.AddWithValue("@GraduationDepartment", eduDetails.Graduation_Department);
                _userSqlCommand.Parameters.AddWithValue("@GraduationYear", Convert.ToInt16(eduDetails.Graduation_Year));
                _userSqlCommand.Parameters.AddWithValue("@GraduationUniversity", eduDetails.Graduation_University);
                _userSqlCommand.Parameters.AddWithValue("@GraduationGPA", Convert.ToDecimal(eduDetails.Graduation_GPA));
                _userSqlCommand.Parameters.AddWithValue("@GREScore", Convert.ToDecimal(eduDetails.GRE_Score));
                _userSqlCommand.Parameters.AddWithValue("@IELTSScore", Convert.ToDecimal(eduDetails.IELTS_Score));

                return _userSqlCommand.ExecuteNonQuery();


            }
            catch (Exception Ex)
            {
                throw;
            }
            finally
            {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }

        }

        public string UpDateStudentEduDetails(EducationDetails studentEduDetail)
        {
            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                string _userCommandText = @"Update Student_Education set UnderGrad_Department = @UnderGradDepartment,
                                                                         UnderGrad_Year = @UnderGradYear,
                                                                         UnderGrad_University = @UnderGradUniversity,
                                                                         UnderGrad_GPA = @UnderGradGPA,
                                                                         Graduation_Department = @GraduationDepartment ,
                                                                         Graduation_Year = @GraduationYear ,
                                                                         Graduation_University = @GraduationUniversity ,
                                                                         Graduation_GPA = @GraduationGPA  ,
                                                                         GRE_Score = @GREScore ,
                                                                         IELTS_Score = @IELTSScore 
                                                                   where StudentId = @StudentId ";

                _userSqlCommand.CommandText = _userCommandText;



                _userSqlCommand.Parameters.AddWithValue("@StudentId", studentEduDetail.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradDepartment", studentEduDetail.UnderGrad_Department);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradYear", Convert.ToInt32(studentEduDetail.UnderGrad_Year));
                _userSqlCommand.Parameters.AddWithValue("@UnderGradUniversity", studentEduDetail.UnderGrad_University);
                _userSqlCommand.Parameters.AddWithValue("@UnderGradGPA", Convert.ToDecimal(studentEduDetail.UnderGrad_GPA));
                _userSqlCommand.Parameters.AddWithValue("@GraduationDepartment", studentEduDetail.Graduation_Department);
                _userSqlCommand.Parameters.AddWithValue("@GraduationYear", Convert.ToInt16(studentEduDetail.Graduation_Year));
                _userSqlCommand.Parameters.AddWithValue("@GraduationUniversity", studentEduDetail.Graduation_University);
                _userSqlCommand.Parameters.AddWithValue("@GraduationGPA", Convert.ToDecimal(studentEduDetail.Graduation_GPA));
                _userSqlCommand.Parameters.AddWithValue("@GREScore", Convert.ToDecimal(studentEduDetail.GRE_Score));
                _userSqlCommand.Parameters.AddWithValue("@IELTSScore", Convert.ToDecimal(studentEduDetail.IELTS_Score));

                _userSqlCommand.ExecuteNonQuery();

                return "Education details Updated successfully";

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


    }
}
