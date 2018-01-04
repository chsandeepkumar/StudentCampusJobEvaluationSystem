using CISDotnetGroupProject.Models;
using System.Collections.Generic;

namespace CISDotnetGroupProject.DataAccessLayer
{
    interface IApplicantDetails
    {
        List<ApplicantScores> GetApplicantScoreDetails();
        //void GetAllApplicationPointsDetails();
        

    }
}
