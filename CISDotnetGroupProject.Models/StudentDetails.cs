using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISDotnetGroupProject.Models
{
    public class StudentDetails
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Gender { get; set; }
        public string AddressL1 { get; set; }
        public string AddressL2 { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }

        public string Department { get; set; }
        public string Semister { get; set; }

       
    }
}
