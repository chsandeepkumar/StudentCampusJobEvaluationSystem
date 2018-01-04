using System;
using CISDotnetGroupProject.Models;
using CISDotnetGroupProject.DataAccessLayer.Helpers;
using System.Data.SqlClient;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public class StudentSkillsSet : IStudentSkillsSet
    {
        StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();
        public int DeleteStudentDetail(int studentId)
        {
            throw new NotImplementedException();
        }

        public Technlogies getStudentSkillSetById(int Id)
        {
            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();


                string _userCommandText = @"select *from Technologies where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", Id);

                SqlDataReader _resultSkillsDetails = _userSqlCommand.ExecuteReader();

                Technlogies _studentSkillsDetails = new Technlogies();

                while (_resultSkillsDetails.Read())
                {
                    _studentSkillsDetails.UIProgramming = _resultSkillsDetails["UIProgramming"].ToString();
                    _studentSkillsDetails.ProgrammingLang= _resultSkillsDetails["ProgrammingLang"].ToString();
                    _studentSkillsDetails.DbProgramming = _resultSkillsDetails["DbProgramming"].ToString();
                    _studentSkillsDetails.Tools = _resultSkillsDetails["Tools"].ToString();
                    _studentSkillsDetails.Certificates = _resultSkillsDetails["Certificates"].ToString();
                    _studentSkillsDetails.Others = _resultSkillsDetails["Others"].ToString();
                                                     
                }

                return _studentSkillsDetails;
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

        public string insertStudentSkillsSet(Technlogies tech)
        {
           

            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                string _userCommandText = @"Insert INTO Technologies (StudentId, UIProgramming, ProgrammingLang,  DbProgramming, Tools, Certificates, TotalScore,  Others, Comments) 
                                                                     values(@StudentId, @UIProgramming, @ProgrammingLang,  @DbProgramming, @Tools,@Certificates,  @TotalScore,  @Others, @Comments) ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                tech.StudentId = 700;
                _userSqlCommand.Parameters.AddWithValue("@StudentID",tech.StudentId );
                _userSqlCommand.Parameters.AddWithValue("@UIProgramming",tech.UIProgramming );
                _userSqlCommand.Parameters.AddWithValue("@ProgrammingLang",tech.ProgrammingLang );
                _userSqlCommand.Parameters.AddWithValue("@DbProgramming",tech.DbProgramming );
                _userSqlCommand.Parameters.AddWithValue("@Tools", tech.Tools );
                _userSqlCommand.Parameters.AddWithValue("@Certificates", tech.Certificates);
                _userSqlCommand.Parameters.AddWithValue("@TotalScore",tech.TotalScore );
                _userSqlCommand.Parameters.AddWithValue("@Others",tech.Others );
                _userSqlCommand.Parameters.AddWithValue("@Comments", tech.Comments);

                _userSqlCommand.ExecuteNonQuery();

                return "Details added Successfully";
            }
            catch(Exception Ex)
            {
                return Ex.Message;

            }
            finally {
                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public string UpDateTechDetails(Technlogies studentTechDetail)
        {
           

            try
            {

                SqlCommand _userSqlCommand = new SqlCommand();

                string _userCommandText = @"Update Technologies Set 
                                                                 UIProgramming = @UIProgramming,
                                                                 ProgrammingLang = @ProgrammingLang,
                                                                 DbProgramming = @DbProgramming,
                                                                    Tools = @Tools, 
                                                                    Certificates = @Certificates,
                                                                TotalScore = @TotalScore,
                                                                    Others = @Others ,
                                                                    Comments = @Comments
                                                                    where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                studentTechDetail.StudentId = 700;
                _userSqlCommand.Parameters.AddWithValue("@StudentID", studentTechDetail.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@UIProgramming", studentTechDetail.UIProgramming);
                _userSqlCommand.Parameters.AddWithValue("@ProgrammingLang", studentTechDetail.ProgrammingLang);
                _userSqlCommand.Parameters.AddWithValue("@DbProgramming", studentTechDetail.DbProgramming);
                _userSqlCommand.Parameters.AddWithValue("@Tools", studentTechDetail.Tools);
                _userSqlCommand.Parameters.AddWithValue("@Certificates", studentTechDetail.Certificates);
                _userSqlCommand.Parameters.AddWithValue("@TotalScore", studentTechDetail.TotalScore);
                _userSqlCommand.Parameters.AddWithValue("@Others", studentTechDetail.Others);
                _userSqlCommand.Parameters.AddWithValue("@Comments", studentTechDetail.Comments);

                _userSqlCommand.ExecuteNonQuery();

                return "Details added Successfully";
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
