using CISDotnetGroupProject.Models;
using System.Collections.Generic;
using System.Data;
using DataAccessLayerDataAccessLayer = CISDotnetGroupProject.DataAccessLayer;
using System;
using System.Linq;

namespace CISDotnetGroupProject.BusinessRules
{
    public class ScoreCalculation
    {
        static Dictionary<decimal, int> GREScorePointsDictionary = new Dictionary<decimal, int>();
        static Dictionary<decimal, int> IELTSScorePointsDictionary = new Dictionary<decimal, int>();
        static Dictionary<int, int> AgeScorePointsDictionary = new Dictionary<int, int>();
        static Dictionary<decimal, int> UnderGradGPApointsDictionary = new Dictionary<decimal, int>();
        static Dictionary<decimal, int> GradGPAPointsDictionary = new Dictionary<decimal, int>();
        static Dictionary<int, int> WorkexperienceDictionary = new Dictionary<int, int>();
        public static Dictionary<decimal, int> LoadGREscorePoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var GRePoints = _objApplicantdetails.GetGREPoints();

            foreach (DataRow item in GRePoints.Rows)
            {
                GREScorePointsDictionary.Add(decimal.Parse(item["Score"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return GREScorePointsDictionary;

        }
        public static Dictionary<decimal, int> LoadIELTSscorePoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var GRePoints = _objApplicantdetails.GetIELTSpoints();

            foreach (DataRow item in GRePoints.Rows)
            {
                IELTSScorePointsDictionary.Add(decimal.Parse(item["Score"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return IELTSScorePointsDictionary;

        }
        public static Dictionary<int, int> LoadAgebasedscorePoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var GRePoints = _objApplicantdetails.GetAgebasedpoints();

            foreach (DataRow item in GRePoints.Rows)
            {
                AgeScorePointsDictionary.Add(int.Parse(item["Age"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return AgeScorePointsDictionary;

        }
        public static Dictionary<decimal, int> LoadUndergradGPAPoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var underGradpoints = _objApplicantdetails.GetUnderGradPoints();

            foreach (DataRow item in underGradpoints.Rows)
            {
                UnderGradGPApointsDictionary.Add(decimal.Parse(item["GPA"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return UnderGradGPApointsDictionary;

        }
        public static Dictionary<decimal, int> LoadgradGPAPoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var gradPoints = _objApplicantdetails.GetGradPoints();

            foreach (DataRow item in gradPoints.Rows)
            {
                GradGPAPointsDictionary.Add(decimal.Parse(item["GPA"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return GradGPAPointsDictionary;

        }
        public static Dictionary<int, int> LoadWorkExperiencePoints()
        {
            DataAccessLayerDataAccessLayer.ApplicantDetails _objApplicantdetails = new DataAccessLayerDataAccessLayer.ApplicantDetails();
            var workExperiencepoints = _objApplicantdetails.GetWorkExperiencePoints();

            foreach (DataRow item in workExperiencepoints.Rows)
            {
                WorkexperienceDictionary.Add(int.Parse(item["YearsOfExperience"].ToString()), int.Parse(item["Points"].ToString()));
            }
            return WorkexperienceDictionary;

        }

        public List<ApplicantPoints> CalculatePoints(List<ApplicantScores> applicantScoreDetails)
        {
            List<ApplicantPoints> _applicantpointslist = new List<ApplicantPoints>();


            try
            {
                foreach (var applicant in applicantScoreDetails)
                {
                    ApplicantPoints _calculatedPoints = new ApplicantPoints();
                    _calculatedPoints.GREPoints = GetGREPointsForGiven(applicant.GREScore);
                    _calculatedPoints.IELTSPoints = GetIELTSPointsForGiven(applicant.IELTSScore);
                    _calculatedPoints.GraduationPoints = GetGradPointsForGiven(applicant.GraduationGPA);
                    _calculatedPoints.UnderGraduationPoints = GetUndergradPointsForGiven(applicant.UnderGradGPA);
                    _calculatedPoints.WorkExperiencePoints = GetWorkExperiencePointsForGiven(applicant.TotalYrsExperience);

                    _calculatedPoints.TotalPoints = _calculatedPoints.GREPoints + _calculatedPoints.IELTSPoints + _calculatedPoints.WorkExperiencePoints + _calculatedPoints.UnderGraduationPoints + _calculatedPoints.GraduationPoints;
                    _applicantpointslist.Add(_calculatedPoints);
                }

            }
            catch (System.Exception)
            {

                throw;
            }

            return _applicantpointslist;
        }

        private int GetGREPointsForGiven(decimal score)
        {
            if (GREScorePointsDictionary.ContainsKey(score))
                return GREScorePointsDictionary.Where(greScore => greScore.Key == score).Select(points => points.Value).Single();
            else return 0;
        }
        private int GetIELTSPointsForGiven(decimal score)
        {
            if (IELTSScorePointsDictionary.ContainsKey(score))
                return IELTSScorePointsDictionary.Where(greScore => greScore.Key == score).Select(points => points.Value).Single();
            else
                return 0;
        }
        private int GetAgebasedPointsForGiven(int age)
        {
            if (AgeScorePointsDictionary.ContainsKey(age))
                return AgeScorePointsDictionary.Where(AGE => AGE.Key == age).Select(points => points.Value).Single();
            else
                return 0;
        }
        private int GetUndergradPointsForGiven(decimal underGradgpa)
        {
            if (UnderGradGPApointsDictionary.ContainsKey(underGradgpa))
                return UnderGradGPApointsDictionary.Where(GPA => GPA.Key == underGradgpa).Select(points => points.Value).Single();
            else
                return 0;
        }
        private int GetGradPointsForGiven(decimal gradGpa)
        {
            if (GradGPAPointsDictionary.ContainsKey(gradGpa))
                return GradGPAPointsDictionary.Where(GPA => GPA.Key == gradGpa).Select(points => points.Value).Single();
            else
                return 0;
        }
        private int GetWorkExperiencePointsForGiven(int yearsOfExperience)
        {
            if (WorkexperienceDictionary.ContainsKey(yearsOfExperience))
                return WorkexperienceDictionary.Where(experience => experience.Key == yearsOfExperience).Select(points => points.Value).Single();
            else
                return 0;
        }
    }
}
