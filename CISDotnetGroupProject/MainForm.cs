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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void applicationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _applicantdetails = new ApplicantDetails { MdiParent = this };
            _applicantdetails.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var _loginForm = new LogIn();
            _loginForm.Show();
            this.Close();

        }

        private void viewApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewform = new View_Application { MdiParent = this };
            viewform.Show();
        }
    }
}
