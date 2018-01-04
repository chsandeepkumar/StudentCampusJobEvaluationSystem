using CISDotnetGroupProject.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISDotnetGroupProject
{
    public partial class View_Application : Form
    {
        public View_Application()
        {
            InitializeComponent();
        }

        private void View_Application_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var _studentId = Convert.ToInt16(textBoxStudentId.Text);

            var studenData = new StudentPersonalDetails();
            var result = studenData.GetStudentCompleteDetails(_studentId);

            personalDetailsDataGridView.DataSource = result[0].Tables[0];
            educationDetailsDataGridView.DataSource = result[1].Tables[0];
            experienceDataGridView.DataSource = result[1].Tables[0];
            technologiesDataGridView.DataSource = result[3].Tables[0];

        }
    }
}
