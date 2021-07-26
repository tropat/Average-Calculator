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
        public AverageCalculator()
        {
            InitializeComponent();
        }

        private void addNewCourseButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                CourseModel p = new CourseModel();

                p.Name = courseNameValue.Text;

                int ects = 0;
                int.TryParse(ectsValue.Text, out ects);
                p.Ects = ects;

                float grade = 0;
                float.TryParse(gradeValue.Text, out grade);
                p.Grade = grade;

                p = GlobalConfig.Connection.CreateCourse(p);

                courseNameValue.Text = "";
                ectsValue.Text = "";
                gradeValue.Text = "";
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
    }
}
