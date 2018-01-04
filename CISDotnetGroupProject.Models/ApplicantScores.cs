namespace CISDotnetGroupProject.Models
{
    public class ApplicantScores
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public decimal GREScore { get; set; }
        public decimal IELTSScore { get; set; }
        public decimal GraduationGPA { get; set; }
        public decimal UnderGradGPA { get; set; }
        public int TotalYrsExperience { get; set; }
        public string DateOfBirth { get; set; }
    }
}
