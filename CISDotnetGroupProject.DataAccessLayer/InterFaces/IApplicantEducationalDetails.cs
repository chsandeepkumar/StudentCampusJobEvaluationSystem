using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CISDotnetGroupProject.Models;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public interface IApplicantEducationalDetails
    {

        int insertEducationDetails(EducationDetails eduDetails);

        StudentEducationDetails GetAllStudentEduDetails();

       EducationDetails GetStudentEduDetailsBy(int Id);
        string UpDateStudentEduDetails(EducationDetails studentDetail);
        int DeleteStudentEduDetail(int studentId);

    }
}
