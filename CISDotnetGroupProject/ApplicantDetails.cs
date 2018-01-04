using System;
using System.Windows.Forms;
using CISDotnetGroupProject.DataAccessLayer;
using CISDotnetGroupProject.Models;
using System.Text;

namespace CISDotnetGroupProject
{
    public partial class ApplicantDetails : Form
    {
        public ApplicantDetails()
        {
            InitializeComponent();
        }

        public int _studentID = 0;
        public string dob;
        private void personalDetailsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(firstnameTextbox.Text)) { MessageBox.Show("Please Enter FirstName"); return; }
                if (string.IsNullOrEmpty(lastnameTextBox.Text))
                {
                    MessageBox.Show("Please Enter LastName"); return;
                }
                if (string.IsNullOrEmpty(dateOfBirthMonthCalendar.SelectionRange.Start.ToShortDateString()))
                {
                    MessageBox.Show("Please select a date"); return;
                }
                if (string.IsNullOrEmpty(emailidTextbox.Text)) { MessageBox.Show("Please Enter Email ID"); return; }
                if (string.IsNullOrEmpty(genderCombobox.SelectedItem.ToString())) { MessageBox.Show("Please Select Gender"); return; }
                if (string.IsNullOrEmpty(phonenumberTextbox.Text))
                {
                    MessageBox.Show("Please Enter Phone Number"); return;
                }
                if (string.IsNullOrEmpty(addressLine1TextBox.Text)) { MessageBox.Show("Please Enter details in Address Line 1"); return; }

                IStudentData _personalData = new StudentPersonalDetails();

                StudentDetails _studentDetails = new StudentDetails();
                _studentDetails.FirstName = firstnameTextbox.Text;
                _studentDetails.LastName = lastnameTextBox.Text;
                _studentDetails.DateOfBirth = dateOfBirthMonthCalendar.SelectionRange.Start.ToShortDateString();
                _studentDetails.Email = emailidTextbox.Text;
                _studentDetails.Gender = genderCombobox.SelectedItem.ToString();
                _studentDetails.AddressL1 = addressLine1TextBox.Text;
                _studentDetails.PhoneNo = phonenumberTextbox.Text;

                if (!string.IsNullOrEmpty(addressLine2TextBox.Text))
                {
                    _studentDetails.AddressL2 = addressLine2TextBox.Text;
                }
                else
                {
                    _studentDetails.AddressL2 = "Empty";
                }

                var insertResult = _personalData.InsertStudentDetails(_studentDetails);

                if (!string.IsNullOrEmpty(insertResult.StudentId.ToString()))
                {
                    _studentID = insertResult.StudentId;
                    MessageBox.Show(_studentID.ToString());

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured in Personal details tab " + ex.Message);
            }

        }

        private void eduDetailsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                IApplicantEducationalDetails _studentData = new StudentEducationDetails();

                EducationDetails eduDetails = new EducationDetails();

                eduDetails.StudentId = _studentID;
                eduDetails.UnderGrad_University = (string.IsNullOrEmpty(undergraduateGpaTextbox.Text) == false) ?
                     undergradUniversityTextbox.Text : "NA";

                eduDetails.UnderGrad_Department = (string.IsNullOrEmpty(undergraduateStreamTextbox.Text) == false) ?
                    undergraduateStreamTextbox.Text : "NA";

                eduDetails.UnderGrad_Year = (string.IsNullOrEmpty(undergraduateYearTextBox.Text) == false) ?
                   Convert.ToInt32(undergraduateYearTextBox.Text) : 0;

                eduDetails.UnderGrad_GPA = (string.IsNullOrEmpty(undergraduateGpaTextbox.Text) == false) ?
                Convert.ToDecimal(undergraduateGpaTextbox.Text) : 0.0m;

                eduDetails.Graduation_University = (string.IsNullOrEmpty(graduateUniversityTextBox.Text) == false) ?
                    graduateUniversityTextBox.Text : "NA";

                eduDetails.Graduation_Department = (string.IsNullOrEmpty(graduationStreamTextBox.Text) == false) ?
                    graduationStreamTextBox.Text : "NA";


                eduDetails.Graduation_Year = (string.IsNullOrEmpty(graduationYearTextBox.Text) == true)
                    ? 0 : Convert.ToInt32(graduationYearTextBox.Text);


                eduDetails.Graduation_GPA = (string.IsNullOrEmpty(graduationGpaTextbox.Text) == true)
                    ? 0.0m : Convert.ToDecimal(graduationGpaTextbox.Text);


                eduDetails.GRE_Score = (string.IsNullOrEmpty(greTextbox.Text) == true)
                    ? 0.0m : Convert.ToDecimal(greTextbox.Text);

                eduDetails.IELTS_Score = (string.IsNullOrEmpty(ieltstoeflTextbox.Text) == true)
                    ? 0.0m : Convert.ToDecimal(ieltstoeflTextbox.Text);



                var _numberOfRowsEffected = _studentData.insertEducationDetails(eduDetails);

                if (_numberOfRowsEffected > 0)
                    MessageBox.Show("Details Submitted Successfully");
                else
                    MessageBox.Show("Details not Submitted Successfully, Please contact administrator");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured in Education Details Tab: " + ex.Message);

            }
        }

        //Function to save work experience details of student
        private void workExpDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkExperienceDetails _workExpDetails = new studentWorkExpDetails();

                WorkExperienceDetails _studentWorkExpDetails = new WorkExperienceDetails();

                if (!NoneRadioButton.Checked)
                {

                    _studentWorkExpDetails.StudentId = _studentID;
                    _studentWorkExpDetails.RecentCompanyYear = (string.IsNullOrEmpty(yearsTextbox.Text) == false) ?
                    yearsTextbox.Text : "NA";
                    _studentWorkExpDetails.RecentCompanyName = (string.IsNullOrEmpty(companyTextbox.Text) == false) ?
                        companyTextbox.Text : "NA";
                    _studentWorkExpDetails.TotalYrsExp = (string.IsNullOrEmpty(totalYearsExperienceTextbox.Text) == false) ?
                        Convert.ToInt32(totalYearsExperienceTextbox.Text) : 0;

                    _studentWorkExpDetails.PreviousGA = (string.IsNullOrEmpty(previousGATextbox.Text) == false) ?
                        previousGATextbox.Text : "NA";
                    _studentWorkExpDetails.PreGAFaculty = (string.IsNullOrEmpty(prevGAFacultyTextbox.Text) == false) ?
                        prevGAFacultyTextbox.Text : "NA";
                    _studentWorkExpDetails.FacultyRef = (string.IsNullOrEmpty(facultyReferenceTextbox.Text) == false) ?
                        facultyReferenceTextbox.Text : "NA";

                }
                else
                {
                    _studentWorkExpDetails.StudentId = _studentID;
                    _studentWorkExpDetails.RecentCompanyYear = "No Expereience";
                    _studentWorkExpDetails.RecentCompanyName = "No Expereience";
                    _studentWorkExpDetails.TotalYrsExp = 0;
                    _studentWorkExpDetails.PreviousGA = "No Expereience";
                    _studentWorkExpDetails.PreGAFaculty = "No Expereience";
                    _studentWorkExpDetails.FacultyRef = "No Expereience";

                }

                string _resultWorkExp = _workExpDetails.insertWorkExperience(_studentWorkExpDetails);

                MessageBox.Show(_resultWorkExp);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void saveSkillsButton_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentSkillsSet _skills = new StudentSkillsSet();

                Technlogies tech = new Technlogies();

                StringBuilder _stringBuild = new StringBuilder();
                int count = 0;

                tech.StudentId = _studentID;

                foreach (var programmlangs in programmingCheckedListBox.CheckedItems)
                {
                    count++;

                    _stringBuild.Append(programmlangs);
                }

                if (_stringBuild.Length > 0)
                    tech.ProgrammingLang = _stringBuild.ToString();
                else tech.ProgrammingLang = "None";
                _stringBuild.Clear();


                foreach (var clientLangs in uiLanguagesCheckedListBox.CheckedItems)
                {
                    count++;
                    _stringBuild.Append(clientLangs);
                }

                if (_stringBuild.Length > 0)
                    tech.UIProgramming = _stringBuild.ToString();
                else tech.UIProgramming = "None";

                _stringBuild.Clear();

                foreach (var dbLangs in dbLanguagesCheckedListBox.CheckedItems)
                {
                    count++;
                    _stringBuild.Append(dbLangs);
                }

                if (_stringBuild.Length > 0)
                    tech.DbProgramming = _stringBuild.ToString();
                else tech.DbProgramming = " None";
                _stringBuild.Clear();


                if (!string.IsNullOrEmpty(tools1TextBox.Text))
                {
                    count++;
                    _stringBuild.Append(tools1TextBox.Text);
                    if (!string.IsNullOrEmpty(tools2TextBox.Text))
                    {
                        count++;
                        _stringBuild.Append(",");
                        _stringBuild.Append(tools2TextBox.Text);
                    }
                }

                if (_stringBuild.Length > 0)
                    tech.Tools = _stringBuild.ToString();
                else tech.Tools = " None";
                _stringBuild.Clear();

                if (!string.IsNullOrEmpty(Certifications1TextBox.Text))
                {
                    count++;
                    _stringBuild.Append(Certifications1TextBox.Text);
                    if (!string.IsNullOrEmpty(certification2TextBox.Text))
                    {
                        count++;
                        _stringBuild.Append(certification2TextBox.Text);
                    }

                    tech.Certificates = _stringBuild.ToString();
                    _stringBuild.Clear();
                }
                else tech.Certificates = "None";

                if (!string.IsNullOrEmpty(OthersTextBox.Text)) { tech.Others = OthersTextBox.Text; }
                else { tech.Others = "none"; }

                if (!string.IsNullOrEmpty(commentsTextBox.Text)) { tech.Comments = commentsTextBox.Text; }
                else { tech.Comments = "none"; }

                tech.TotalScore = count;

                string _result = _skills.insertStudentSkillsSet(tech);

                MessageBox.Show(_result);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //update student personla details
        private void updatePersonalDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(firstnameTextbox.Text)) { MessageBox.Show("Please Enter FirstName"); return; }
                if (string.IsNullOrEmpty(lastnameTextBox.Text))
                {
                    MessageBox.Show("Please Enter LastName"); return;
                }
                if (string.IsNullOrEmpty(emailidTextbox.Text)) { MessageBox.Show("Please Enter Email ID"); return; }
                if (string.IsNullOrEmpty(genderCombobox.SelectedItem.ToString())) { MessageBox.Show("Please Select Gender"); return; }
                if (string.IsNullOrEmpty(phonenumberTextbox.Text)) { MessageBox.Show("Please Enter Phone Number"); return; }
                if (string.IsNullOrEmpty(addressLine1TextBox.Text)) { MessageBox.Show("Please Enter details in Address Line 1"); return; }

                IStudentData _personalData = new StudentPersonalDetails();

                StudentDetails _studentDetails = new StudentDetails();
                _studentDetails.FirstName = firstnameTextbox.Text;
                _studentDetails.LastName = lastnameTextBox.Text;

                if (string.IsNullOrEmpty(dateOfBirthMonthCalendar.SelectionRange.Start.ToShortDateString()))
                    _studentDetails.DateOfBirth = dateOfBirthMonthCalendar.SelectionRange.Start.ToShortDateString();
                else _studentDetails.DateOfBirth = dob;

                _studentDetails.Email = emailidTextbox.Text;
                _studentDetails.Gender = genderCombobox.SelectedItem.ToString();
                _studentDetails.PhoneNo = phonenumberTextbox.Text;
                _studentDetails.AddressL1 = addressLine1TextBox.Text;
                _studentDetails.StudentId = _studentID;
                if (!string.IsNullOrEmpty(addressLine2TextBox.Text))
                {
                    _studentDetails.AddressL2 = addressLine2TextBox.Text;
                }
                else
                {
                    _studentDetails.AddressL2 = "Empty";
                }

                string updateResult = _personalData.UpDateStudentDetails(_studentDetails);

                MessageBox.Show(updateResult);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured in Personal details tab " + ex.Message);
            }

        }

        //get personal details button
        private void getDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentData _studentData = new StudentPersonalDetails();

                _studentID = 700;
                StudentDetails _studentPersonalDetails = _studentData.GetStudentDetailsBy(_studentID);


                firstnameTextbox.Text = string.IsNullOrEmpty(_studentPersonalDetails.FirstName) == true ?
                    "Empty" : _studentPersonalDetails.FirstName;
                lastnameTextBox.Text = _studentPersonalDetails.LastName;
                dob = _studentPersonalDetails.DateOfBirth;
                displayDOBlabel.Text = "D.O.B.  " + dob;
                //genderCombobox.SelectedItem = _studentPersonalDetails.Gender;
                //genderCombobox.SelectedText = _studentPersonalDetails.Gender;
                genderCombobox.SelectedText = "Female";// _studentPersonalDetails.Gender.ToString();
                
               // genderCombobox.SelectedIndex = 0;
                emailidTextbox.Text = _studentPersonalDetails.Email;
                phonenumberTextbox.Text = _studentPersonalDetails.PhoneNo;
                addressLine1TextBox.Text = _studentPersonalDetails.AddressL1;
                if (!string.IsNullOrEmpty(addressLine2TextBox.Text)) { addressLine2TextBox.Text = _studentPersonalDetails.AddressL2; }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void getEduDetailsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                IApplicantEducationalDetails _studentEduDetails = new StudentEducationDetails();

                _studentID = 700;
                EducationDetails _resultEduDetails = _studentEduDetails.GetStudentEduDetailsBy(_studentID);

                undergradUniversityTextbox.Text = _resultEduDetails.UnderGrad_University;
                undergraduateStreamTextbox.Text = _resultEduDetails.UnderGrad_Department;
                undergraduateYearTextBox.Text = Convert.ToString(_resultEduDetails.UnderGrad_Year);
                undergraduateGpaTextbox.Text = Convert.ToString(_resultEduDetails.UnderGrad_GPA);
                graduateUniversityTextBox.Text = _resultEduDetails.Graduation_University;
                graduationStreamTextBox.Text = _resultEduDetails.Graduation_Department;
                graduationYearTextBox.Text = Convert.ToString(_resultEduDetails.Graduation_Year);
                graduationGpaTextbox.Text = Convert.ToString(_resultEduDetails.Graduation_GPA);
                if (!string.IsNullOrEmpty(_resultEduDetails.GRE_Score.ToString())) { greTextbox.Text = Convert.ToString(_resultEduDetails.GRE_Score); }
                if (!string.IsNullOrEmpty(_resultEduDetails.IELTS_Score.ToString())) { ieltstoeflTextbox.Text = Convert.ToString(_resultEduDetails.IELTS_Score); }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void updateEduDetailsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                IApplicantEducationalDetails _updateStudentEduData = new StudentEducationDetails();

                EducationDetails eduDetails = new EducationDetails();

                eduDetails.StudentId = _studentID;
                eduDetails.UnderGrad_University = undergradUniversityTextbox.Text;
                eduDetails.UnderGrad_Department = undergraduateStreamTextbox.Text;
                eduDetails.UnderGrad_Year = Convert.ToInt32(undergraduateYearTextBox.Text);
                eduDetails.UnderGrad_GPA = Convert.ToDecimal(undergraduateGpaTextbox.Text);
                eduDetails.Graduation_University = graduateUniversityTextBox.Text;
                eduDetails.Graduation_Department = graduationStreamTextBox.Text;
                eduDetails.Graduation_Year = Convert.ToInt32(graduationYearTextBox.Text);
                eduDetails.Graduation_GPA = Convert.ToDecimal(graduationGpaTextbox.Text);

                if (!string.IsNullOrEmpty(greTextbox.Text) && !string.IsNullOrEmpty(ieltstoeflTextbox.Text))
                {

                    eduDetails.GRE_Score = Convert.ToDecimal(greTextbox.Text);
                    eduDetails.IELTS_Score = Convert.ToDecimal(ieltstoeflTextbox.Text);

                }
                else
                {

                    eduDetails.GRE_Score = 0.00m;
                    eduDetails.IELTS_Score = 0.00m;
                }
                _updateStudentEduData.UpDateStudentEduDetails(eduDetails);

                MessageBox.Show("Details Submitted Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured in  details Updating education details tab " + ex.Message);
            }


        }

        //get request to display work experience details
        private void getWorkExpButton_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkExperienceDetails _workExpDetails = new studentWorkExpDetails();

                _studentID = 700;
                WorkExperienceDetails _resultWorkExpDetails = _workExpDetails.GetStudentWrkExpDetailsBy(_studentID);

                companyTextbox.Text = _resultWorkExpDetails.RecentCompanyName;
                yearsTextbox.Text = _resultWorkExpDetails.RecentCompanyYear;
                totalYearsExperienceTextbox.Text = Convert.ToString(_resultWorkExpDetails.TotalYrsExp);
                previousGATextbox.Text = _resultWorkExpDetails.PreviousGA;
                prevGAFacultyTextbox.Text = _resultWorkExpDetails.PreGAFaculty;
                facultyReferenceTextbox.Text = _resultWorkExpDetails.FacultyRef;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Function to update Work Experience Details
        private void updateWorkExpButton_Click(object sender, EventArgs e)
        {

            try
            {
                IWorkExperienceDetails _workExpDetails = new studentWorkExpDetails();

                WorkExperienceDetails _studentWorkExpDetails = new WorkExperienceDetails();

                if (!NoneRadioButton.Checked)
                {
                    _studentWorkExpDetails.StudentId = 700;//_studentID;
                    _studentWorkExpDetails.RecentCompanyYear = yearsTextbox.Text;
                    _studentWorkExpDetails.RecentCompanyName = companyTextbox.Text;
                    _studentWorkExpDetails.TotalYrsExp = Convert.ToInt32(totalYearsExperienceTextbox.Text);
                    _studentWorkExpDetails.PreviousGA = previousGATextbox.Text;
                    _studentWorkExpDetails.PreGAFaculty = prevGAFacultyTextbox.Text;
                    _studentWorkExpDetails.FacultyRef = facultyReferenceTextbox.Text;
                }
                else
                {

                    _studentWorkExpDetails.StudentId = _studentID;
                    _studentWorkExpDetails.RecentCompanyYear = "No Expereience";
                    _studentWorkExpDetails.RecentCompanyName = "No Expereience";
                    _studentWorkExpDetails.TotalYrsExp = 0;
                    _studentWorkExpDetails.PreviousGA = "No Expereience";
                    _studentWorkExpDetails.PreGAFaculty = "No Expereience";
                    _studentWorkExpDetails.FacultyRef = "No Expereience";

                }

                string _resultWorkExp = _workExpDetails.UpDateStudentWrkExpDetails(_studentWorkExpDetails);

                MessageBox.Show(_resultWorkExp);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        //Get skills Request Button
        private void getSkillsKnownButton_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentSkillsSet _studentSkillSet = new StudentSkillsSet();

                _studentID = 700;
                Technlogies _resultTechDetails = _studentSkillSet.getStudentSkillSetById(_studentID);

                displayUIProgLangLabel.Text = (_resultTechDetails.UIProgramming);
                displayProgrammingLangsLable.Text = _resultTechDetails.ProgrammingLang;
                displayDBLangLabel.Text = _resultTechDetails.DbProgramming;
                tools1TextBox.Text = _resultTechDetails.Tools;
                Certifications1TextBox.Text = _resultTechDetails.Certificates;
                commentsTextBox.Text = _resultTechDetails.Comments;
                OthersTextBox.Text = _resultTechDetails.Others;

                 programmingCheckedListBox.ClearSelected();
                uiLanguagesCheckedListBox.ClearSelected();
                dbLanguagesCheckedListBox.ClearSelected();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Function to update Skills Button
        private void updateSkillsButton_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentSkillsSet _skills = new StudentSkillsSet();

                Technlogies tech = new Technlogies();

                StringBuilder _stringBuild = new StringBuilder();
                int count = 0;

                tech.StudentId = _studentID;

                foreach (var programmlangs in programmingCheckedListBox.CheckedItems)
                {
                    count++;

                    _stringBuild.Append(programmlangs);
                }

                if (_stringBuild.Length > 0)
                    tech.ProgrammingLang = _stringBuild.ToString();
                else tech.ProgrammingLang = "None";
                _stringBuild.Clear();


                foreach (var clientLangs in uiLanguagesCheckedListBox.CheckedItems)
                {
                    count++;
                    _stringBuild.Append(clientLangs);
                }

                if (_stringBuild.Length > 0)
                    tech.UIProgramming = _stringBuild.ToString();
                else tech.UIProgramming = "None";

                _stringBuild.Clear();

                foreach (var dbLangs in dbLanguagesCheckedListBox.CheckedItems)
                {
                    count++;
                    _stringBuild.Append(dbLangs);
                }

                if (_stringBuild.Length > 0)
                    tech.DbProgramming = _stringBuild.ToString();
                else tech.DbProgramming = " None";
                _stringBuild.Clear();


                if (!string.IsNullOrEmpty(tools1TextBox.Text))
                {
                    count++;
                    _stringBuild.Append(tools1TextBox.Text);
                    if (!string.IsNullOrEmpty(tools2TextBox.Text))
                    {
                        count++;
                        _stringBuild.Append(",");
                        _stringBuild.Append(tools2TextBox.Text);
                    }
                }

                if (_stringBuild.Length > 0)
                    tech.Tools = _stringBuild.ToString();
                else tech.Tools = " None";
                _stringBuild.Clear();

                if (!string.IsNullOrEmpty(Certifications1TextBox.Text))
                {
                    count++;
                    _stringBuild.Append(Certifications1TextBox.Text);
                    if (!string.IsNullOrEmpty(certification2TextBox.Text))
                    {
                        count++;
                        _stringBuild.Append(certification2TextBox.Text);
                    }

                    tech.Certificates = _stringBuild.ToString();
                    _stringBuild.Clear();
                }
                else tech.Certificates = "None";

                if (!string.IsNullOrEmpty(OthersTextBox.Text)) { tech.Others = OthersTextBox.Text; }
                else { tech.Others = "none"; }

                if (!string.IsNullOrEmpty(commentsTextBox.Text)) { tech.Comments = commentsTextBox.Text; }
                else { tech.Comments = "none"; }

                tech.TotalScore = count;

                string _result = _skills.UpDateTechDetails(tech);

                MessageBox.Show(_result);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
