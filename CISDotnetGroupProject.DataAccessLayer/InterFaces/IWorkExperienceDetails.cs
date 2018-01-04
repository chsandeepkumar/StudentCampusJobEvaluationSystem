using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CISDotnetGroupProject.Models;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public interface IWorkExperienceDetails
    {
        string insertWorkExperience(WorkExperienceDetails workExpDetails);

        WorkExperienceDetails GetStudentWrkExpDetailsBy(int Id);
        string UpDateStudentWrkExpDetails(WorkExperienceDetails studentWrkExpDetail);
        int DeleteStudentDetail(int studentId);
    }
}
