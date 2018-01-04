using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CISDotnetGroupProject.Models;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public interface IUserData
    {
        UserLoginDetails GetUserlogInDetails(string userName,string passWord,int roleId);
       // bool IsUserValid(string userName);
        
    }
}
