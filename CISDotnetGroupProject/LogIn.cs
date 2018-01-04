using System;
using System.Windows.Forms;
using CISDotnetGroupProject.DataAccessLayer;

namespace CISDotnetGroupProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
               // rolecomboBox.SelectedIndex = 1;
                //usernameTextbox.Text = "Sandeep";
                //passwordTextbox.Text = "abc@123";

                if (string.IsNullOrWhiteSpace(usernameTextbox.Text))
                {
                    MessageBox.Show("Please enter user User name");
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
                {
                    MessageBox.Show("Please enter valid passWord");
                    return;
                }
                if (rolecomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select a  valid user role");
                    return;
                }

                IUserData _userdata = new UserDetails();

                var result = _userdata.GetUserlogInDetails(usernameTextbox.Text, passwordTextbox.Text, GetRoleId(rolecomboBox.SelectedItem));

                if (result != null && !string.IsNullOrWhiteSpace(result.UserName))
                {
                    if (result.roleId == Constants.Studentrole)
                    {
                        this.Hide();
                        MainForm _mainform = new MainForm();
                        _mainform.Show();
                    }
                    else if (result.roleId == Constants.FacultyRole)
                    {
                        this.Hide();
                        FacultyViewForm _facultyviewForm = new FacultyViewForm();
                        _facultyviewForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show($"There is no user exist with user name {0} ", usernameTextbox.Text);
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show($"Exception occured while login into the application", exception.Message);
            }

        }

        private int GetRoleId(object selectedItem)
        {
            return (selectedItem.ToString() == "Faculty") ? 1 : 2;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact System UCM International office for Account creation");
        }

        private void forgotButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password can be reset by calling UCM technology office +1-123456");
        }
    }
}
