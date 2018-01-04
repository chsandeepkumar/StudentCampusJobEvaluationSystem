using System;
using CISDotnetGroupProject.Models;
using CISDotnetGroupProject.DataAccessLayer.Helpers;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CISDotnetGroupProject.DataAccessLayer
{
   public class StudentPersonalDetails : IStudentData
    {

        StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();
        public StudentDetails InsertStudentDetails(StudentDetails studentDetails)
        {
            try {
                SqlCommand _userSqlCommand = new SqlCommand();

              
                string _userCommandText = @"Insert INTO Student_Details (FirstName, LastName, AddressL1, AddressL2, PhoneNo, Email, DateOfBirth,Department,Semister) values(@FName, @LName, @Addressl1, @Addressl2, @Phone, @Email, @DateOfBirth,@Department, @Semister) ";
                
                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@FName", studentDetails.FirstName );
                _userSqlCommand.Parameters.AddWithValue("@LName", studentDetails.LastName );
                //_userSqlCommand.Parameters.AddWithValue("@Gender", studentDetails.Gender);
                _userSqlCommand.Parameters.AddWithValue("@AddressL1", studentDetails.AddressL1);
                _userSqlCommand.Parameters.AddWithValue("@AddressL2", studentDetails.AddressL2);
                _userSqlCommand.Parameters.AddWithValue("@Phone", studentDetails.PhoneNo);
                _userSqlCommand.Parameters.AddWithValue("@Email", studentDetails.Email);
                _userSqlCommand.Parameters.AddWithValue("@DateOfBirth", studentDetails.DateOfBirth);
                _userSqlCommand.Parameters.AddWithValue("@Department", "Null");
                _userSqlCommand.Parameters.AddWithValue("@Semister", "Null");
                _userSqlCommand.ExecuteNonQuery();


                var _reader = newStudentID( studentDetails);

                var _objNewUserID = new StudentDetails();

                while (_reader.Read())
                {
                    _objNewUserID.StudentId = Convert.ToInt32(_reader["StudentId"]);
                }
                return _objNewUserID;

            }
            catch (Exception Ex)
            {
                throw Ex;
                
            }
            finally {

                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
            
        }

        public SqlDataReader newStudentID(StudentDetails studentDetails) {
        
            SqlCommand _userSqlCommand = new SqlCommand();

            string _userCommandText = @"Select StudentId from Student_Details where FirstName = @FName and LastName = @LName and Email = @Email ";

            _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

            _userSqlCommand.CommandText = _userCommandText;

            _userSqlCommand.Parameters.AddWithValue("@FName",  studentDetails.FirstName);
            _userSqlCommand.Parameters.AddWithValue("@LName", studentDetails.LastName);
            _userSqlCommand.Parameters.AddWithValue("@Email", studentDetails.Email);

            var _reader = _userSqlCommand.ExecuteReader();
            return _reader;
        }

        public int DeleteStudentDetail(int studentId)
        {
            throw new NotImplementedException();
        }

        public StudentDetails GetAllStudentDetails()
        {
            throw new NotImplementedException();
        }

        public StudentDetails GetStudentDetailsBy(int Id)
        {
            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();


                string _userCommandText = @"select * from Student_Details where StudentId = @StudentId ";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", Id);

                SqlDataReader _resultStudentDetails = _userSqlCommand.ExecuteReader();

                StudentDetails _studentDetails = new StudentDetails();

                while (_resultStudentDetails.Read()) {
                    _studentDetails.FirstName = _resultStudentDetails["FirstName"].ToString();
                    _studentDetails.LastName = _resultStudentDetails["LastName"].ToString();
                   // _studentDetails.Gender = _resultStudentDetails["Gender"].ToString();
                    _studentDetails.AddressL1 = _resultStudentDetails["AddressL1"].ToString();
                    if (!string.IsNullOrEmpty(_resultStudentDetails["AddressL2"].ToString())) { _studentDetails.AddressL2 =  _resultStudentDetails["AddressL2"].ToString(); }
                    _studentDetails.PhoneNo = _resultStudentDetails["PhoneNo"].ToString();
                    _studentDetails.Email = _resultStudentDetails["Email"].ToString();
                    _studentDetails.DateOfBirth = _resultStudentDetails["DateOfBirth"].ToString();

                }

                return _studentDetails;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally {

                _studentDatabaseConnection.CloseSqlDatabaseConnection();
            }
        }

        public string UpDateStudentDetails(StudentDetails studentDetail)
        {
            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();


                string _userCommandText = @"Update Student_Details set FirstName = @FirstName, 
                                                                     LastName = @LastName,
                                                                     Gender = @Gender,
                                                                     AddressL1 = @AddressL1,
                                                                     AddressL2 = @AddressL2,
                                                                     PhoneNo = @PhoneNo,
                                                                     Email = @Email,
                                                                     DateOfBirth = @DateOfBirth 
                                                                    where StudentId = @StudentId";

                _userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                _userSqlCommand.CommandText = _userCommandText;

                _userSqlCommand.Parameters.AddWithValue("@StudentId", studentDetail.StudentId);
                _userSqlCommand.Parameters.AddWithValue("@FirstName", studentDetail.FirstName);
                _userSqlCommand.Parameters.AddWithValue("@LastName", studentDetail.LastName);
                _userSqlCommand.Parameters.AddWithValue("@Gender", studentDetail.Email);
                _userSqlCommand.Parameters.AddWithValue("@AddressL1", studentDetail.AddressL1);
                _userSqlCommand.Parameters.AddWithValue("@AddressL2", studentDetail.AddressL2);
                _userSqlCommand.Parameters.AddWithValue("@PhoneNo", studentDetail.PhoneNo);
                _userSqlCommand.Parameters.AddWithValue("@Email", studentDetail.Email);
                _userSqlCommand.Parameters.AddWithValue("@DateOfBirth", studentDetail.DateOfBirth);

                _userSqlCommand.ExecuteNonQuery();

                return "Details Updated Successfully";

            }
            catch (Exception Ex){

                return Ex.Message;
            }
        }

        public List<DataSet> GetStudentCompleteDetails(int Id)
        {
            try
            {
                SqlCommand _userSqlCommand = new SqlCommand();

                List<DataSet> studentDetailsList = new List<DataSet>();

                string _userCommandText = @"select * from Student_Details where StudentId = " + "'" + Id + "'";
                string _eduCommandText = @"select * from Student_Education where StudentId = " + "'" + Id + "'"; ; 
                string _wrkExpCommandText = @"select * from Work_Experience where StudentId = " + "'" + Id + "'";
                string _techCommandText = @"select * from Technologies where StudentId =" + "'" + Id + "'"; ;

                //_userSqlCommand.Connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

                //_userSqlCommand.CommandText = _userCommandText;
                //_userSqlCommand.CommandText = _eduCommandText;
                //_userSqlCommand.CommandText = _wrkExpCommandText;
                //_userSqlCommand.CommandText = _techCommandText;

              //  _userSqlCommand.Parameters.AddWithValue("@StudentId", Id);

                DataSet _resultDetailsDataSet = new DataSet();


                //user details 
                SqlDataAdapter userDetailsDataAdap = new SqlDataAdapter(_userCommandText, _studentDatabaseConnection.GetSqlConnection());
                userDetailsDataAdap.Fill(_resultDetailsDataSet);

                studentDetailsList.Add(_resultDetailsDataSet);

                _resultDetailsDataSet.Clear();


                //education details
                SqlDataAdapter eduDataAdap = new SqlDataAdapter(_eduCommandText, _studentDatabaseConnection.GetSqlConnection());

                userDetailsDataAdap.Fill(_resultDetailsDataSet);

                studentDetailsList.Add(_resultDetailsDataSet);

                _resultDetailsDataSet.Clear();


                //work exp dataset
                SqlDataAdapter wrkExpDataAdap = new SqlDataAdapter(_wrkExpCommandText, _studentDatabaseConnection.GetSqlConnection());

                userDetailsDataAdap.Fill(_resultDetailsDataSet);

                studentDetailsList.Add(_resultDetailsDataSet);

                _resultDetailsDataSet.Clear();


                //technologies details
                SqlDataAdapter techDataAdap = new SqlDataAdapter(_techCommandText, _studentDatabaseConnection.GetSqlConnection());

                userDetailsDataAdap.Fill(_resultDetailsDataSet);

                studentDetailsList.Add(_resultDetailsDataSet);

                _resultDetailsDataSet.Clear();


                return studentDetailsList;
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
