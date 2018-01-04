using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CISDotnetGroupProject.Models;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public interface IStudentData
    {
        StudentDetails InsertStudentDetails(StudentDetails studentDetails );
        StudentDetails GetAllStudentDetails();
        StudentDetails GetStudentDetailsBy(int Id);
        string UpDateStudentDetails(StudentDetails studentDetail);
        int DeleteStudentDetail(int studentId);

        List<DataSet> GetStudentCompleteDetails(int Id);
    }
}
