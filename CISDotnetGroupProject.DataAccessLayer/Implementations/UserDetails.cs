using System;
using CISDotnetGroupProject.Models;
using CISDotnetGroupProject.DataAccessLayer.Helpers;
using System.Data.SqlClient;

namespace CISDotnetGroupProject.DataAccessLayer
{
	public class UserDetails : IUserData
	{
		StudentDatabaseConnection _studentDatabaseConnection = new StudentDatabaseConnection();
		public UserLoginDetails GetUserlogInDetails(string userName, string passWord, int roleID)
		{

			try
			{
				var _reader = GetvalidUserdetails(userName, passWord, roleID);

				var _objUserLogindetails = new UserLoginDetails();

				while (_reader.Read())
				{
					_objUserLogindetails.UserName = _reader["UserName"].ToString();
					_objUserLogindetails.Password = _reader["Password"].ToString();
                    _objUserLogindetails.roleId = Convert.ToInt16(_reader["UserRoleId"]);
				}
				return _objUserLogindetails;

			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				_studentDatabaseConnection.CloseSqlDatabaseConnection();
			}
		}

		private SqlDataReader GetvalidUserdetails(string userName, string passWord, int roleID)
		{
			try
			{
				var _connection = _studentDatabaseConnection.OpenSQlDatabaseConnection();

				SqlCommand _userSqlCommand = new SqlCommand();
				_userSqlCommand.Connection = _connection;

				string _UsercommandText = @"Select  UserName, [PassWord],[UserRoleId] from Userlogin 
												where UserName =@UserName and
													[Password]=@Password and 
													 UserRoleId=@UserRoleId";

				_userSqlCommand.CommandText = _UsercommandText;
				_userSqlCommand.Parameters.AddWithValue("@UserName", userName);
				_userSqlCommand.Parameters.AddWithValue("@Password", passWord);
				_userSqlCommand.Parameters.AddWithValue("@UserRoleId", roleID);

				var _reader = _userSqlCommand.ExecuteReader();
				return _reader;
			}
			catch (Exception Ex) {
				throw Ex;
			}
		}
	}
}
