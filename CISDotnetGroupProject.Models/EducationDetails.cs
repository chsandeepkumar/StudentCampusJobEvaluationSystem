using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISDotnetGroupProject.Models
{
    public class EducationDetails
    {
        public int StudentId { get; set; }
        public string UnderGrad_Department { get; set; }
        public int UnderGrad_Year { get; set; }

        public string UnderGrad_University { get; set; }
        public decimal UnderGrad_GPA { get; set; }
        public string Graduation_Department { get; set; }
        public int Graduation_Year { get; set; }
        public string Graduation_University { get; set; }
        public decimal Graduation_GPA { get; set; }
        public decimal GRE_Score { get; set; }
        public decimal IELTS_Score { get; set; }


       
      
    }
}
