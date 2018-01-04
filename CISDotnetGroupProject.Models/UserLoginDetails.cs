using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISDotnetGroupProject.Models
{
    public class UserLoginDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int roleId { get; set; }
        public DateTime LastLoggedInDateTime { get; set; }
    }
}
