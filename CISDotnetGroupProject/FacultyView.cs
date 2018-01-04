using CISDotnetGroupProject.BusinessRules;
using CISDotnetGroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataAccessLayer = CISDotnetGroupProject.DataAccessLayer;

namespace CISDotnetGroupProject
{
    public partial class FacultyViewForm : Form
    {
        public FacultyViewForm()
        {
            InitializeComponent();
            LoadScoreDetails();
        }

        private void LoadScoreDetails()
        {
            try
            {
                ScoreCalculation.LoadGREscorePoints();
                ScoreCalculation.LoadIELTSscorePoints();
                ScoreCalculation.LoadAgebasedscorePoints();
                ScoreCalculation.LoadgradGPAPoints();
                ScoreCalculation.LoadUndergradGPAPoints();
                ScoreCalculation.LoadWorkExperiencePoints();
            }
            catch
            {
                throw;
            }
        }

        private void labelApplicantDetails_Click(object sender, EventArgs e)
        {

        }

        private void FacultyViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataAccessLayer.ApplicantDetails _applicantDetails = new dataAccessLayer.ApplicantDetails();
                var allApplicants = _applicantDetails.GetApplicantScoreDetails();

                List<ApplicantPoints> _applicantsPoints = new List<ApplicantPoints>();
                ScoreCalculation _scoreCalculation = new ScoreCalculation();

                var calculatedPointsForAllApplicants = _scoreCalculation.CalculatePoints(allApplicants);


                applicantDetailsdataGridView.DataSource = calculatedPointsForAllApplicants;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Loading Applicant Details", ex.Message);
            }
        }
    }
}
