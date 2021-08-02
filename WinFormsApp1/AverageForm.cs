using AverageLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AverageCalculator : System.Windows.Forms.Form
    {
        private List<CourseModel> availableCourses = GlobalConfig.Connection.GetCourse_All();
        private List<CourseModel> selectedCourses = new List<CourseModel>();
        private double average = 0;
        public AverageCalculator()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectCourseDropDown.DataSource = null;
            coursesListBox.DataSource = null;

            selectCourseDropDown.DataSource = availableCourses;
            selectCourseDropDown.DisplayMember = "Name";

            coursesListBox.DataSource = selectedCourses;
            coursesListBox.DisplayMember = "CompleteInformation";

            calculateAverageButton.Visible = true;
            averageValueLabel.Text = "";
        }

        private void addNewCourseButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                CourseModel c = new CourseModel();

                c.Name = courseNameValue.Text;

                int ects = 0;
                int.TryParse(ectsValue.Text, out ects);
                c.Ects = ects;

                float grade = 0;
                float.TryParse(gradeValue.Text, out grade);
                c.Grade = grade;
                
                if(addNewCourseButton.Text == "Add New Course")
                {
                    c = GlobalConfig.Connection.CreateCourse(c, CreateModify.Create);
                }
                else if(addNewCourseButton.Text == "Modify")
                {
                    c = GlobalConfig.Connection.CreateCourse(c, CreateModify.Modify);
                    addNewCourseButton.Text = "Add New Course";
                    courseNameValue.Enabled = true;
                }

                selectedCourses.Add(c);

                courseNameValue.Text = "";
                ectsValue.Text = "";
                gradeValue.Text = "";

                WireUpLists();
            }
            else
            {
                MessageBox.Show("Fill all the fields!");
            }
        }
        private bool ValidateForm()
        {
            if(courseNameValue.Text.Length == 0)
            {
                return false;
            }
            if(ectsValue.Text.Length == 0)
            {
                return false;
            }
            if(gradeValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            CourseModel course = (CourseModel)selectCourseDropDown.SelectedItem;

            if (course != null)
            {
                availableCourses.Remove(course);
                selectedCourses.Add(course);
                WireUpLists();
            }
            
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            CourseModel course = (CourseModel)coursesListBox.SelectedItem;

            if(course != null)
            {
                availableCourses.Add(course);
                selectedCourses.Remove(course);
                WireUpLists();
            }
        }

        private void modifyCourseButton_Click(object sender, EventArgs e)
        {
            if(selectCourseDropDown.SelectedItem != null)
            {
                CourseModel course = (CourseModel)selectCourseDropDown.SelectedItem;

                if(course != null)
                {
                    courseNameValue.Text = course.Name;
                    ectsValue.Text = course.Ects.ToString();
                    gradeValue.Text = course.Grade.ToString();
                }

                addNewCourseButton.Text = "Modify";
                courseNameValue.Enabled = false;
                availableCourses.Remove(course);
            }
        }

        private void calculateAverageButton_Click(object sender, EventArgs e)
        {
            double gradesSum = 0;
            int ectsSum = 0;

            foreach(CourseModel c in selectedCourses)
            {
                gradesSum += c.Grade * c.Ects;
                ectsSum += c.Ects;
            }

            if(ectsSum == 0)
            {
                MessageBox.Show("Invalid values!");
            }
            else
            {
                average = gradesSum / ectsSum;
                average = Math.Round(average, 2);

                calculateAverageButton.Visible = false;
                averageValueLabel.Text = average.ToString();
            }
        }
    }
}
