using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CISDotnetGroupProject.Models;

namespace CISDotnetGroupProject.DataAccessLayer
{
    public interface IStudentSkillsSet
    {

        string insertStudentSkillsSet(Technlogies tech);

        Technlogies getStudentSkillSetById(int Id);

        string UpDateTechDetails(Technlogies studentTechDetail);
        int DeleteStudentDetail(int studentId);


    }
}
