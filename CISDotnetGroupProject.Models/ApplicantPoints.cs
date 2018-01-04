using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISDotnetGroupProject.Models
{
    public class ApplicantPoints : ApplicantScores
    {
        public int GREPoints { get; set; }
        public int IELTSPoints { get; set; }
        public int GraduationPoints { get; set; }
        public int UnderGraduationPoints { get; set; }
        public int AgebasedPoints { get; set; }
        public int WorkExperiencePoints { get; set; }

        public int TotalPoints { get; set; }

    }
}
