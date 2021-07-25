
namespace WinFormsApp1
{
    partial class AverageCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectCourseDropDown = new System.Windows.Forms.ComboBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.modifyCourseButton = new System.Windows.Forms.Button();
            this.addNewCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.addNewCourseButton = new System.Windows.Forms.Button();
            this.gradeValue = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.ectsValue = new System.Windows.Forms.TextBox();
            this.ectsLabel = new System.Windows.Forms.Label();
            this.courseNameValue = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageValueLabel = new System.Windows.Forms.Label();
            this.calculateAverageButton = new System.Windows.Forms.Button();
            this.addNewCourseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCourseDropDown
            // 
            this.selectCourseDropDown.FormattingEnabled = true;
            this.selectCourseDropDown.Location = new System.Drawing.Point(83, 88);
            this.selectCourseDropDown.Name = "selectCourseDropDown";
            this.selectCourseDropDown.Size = new System.Drawing.Size(395, 36);
            this.selectCourseDropDown.TabIndex = 0;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.courseLabel.Location = new System.Drawing.Point(83, 31);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(121, 45);
            this.courseLabel.TabIndex = 1;
            this.courseLabel.Text = "Course";
            // 
            // modifyCourseButton
            // 
            this.modifyCourseButton.BackColor = System.Drawing.Color.Silver;
            this.modifyCourseButton.Location = new System.Drawing.Point(345, 145);
            this.modifyCourseButton.Name = "modifyCourseButton";
            this.modifyCourseButton.Size = new System.Drawing.Size(133, 50);
            this.modifyCourseButton.TabIndex = 3;
            this.modifyCourseButton.Text = "Modify";
            this.modifyCourseButton.UseVisualStyleBackColor = false;
            // 
            // addNewCourseGroupBox
            // 
            this.addNewCourseGroupBox.Controls.Add(this.addNewCourseButton);
            this.addNewCourseGroupBox.Controls.Add(this.gradeValue);
            this.addNewCourseGroupBox.Controls.Add(this.gradeLabel);
            this.addNewCourseGroupBox.Controls.Add(this.ectsValue);
            this.addNewCourseGroupBox.Controls.Add(this.ectsLabel);
            this.addNewCourseGroupBox.Controls.Add(this.courseNameValue);
            this.addNewCourseGroupBox.Controls.Add(this.courseNameLabel);
            this.addNewCourseGroupBox.Location = new System.Drawing.Point(53, 253);
            this.addNewCourseGroupBox.Name = "addNewCourseGroupBox";
            this.addNewCourseGroupBox.Size = new System.Drawing.Size(467, 343);
            this.addNewCourseGroupBox.TabIndex = 4;
            this.addNewCourseGroupBox.TabStop = false;
            this.addNewCourseGroupBox.Text = "Add New Course";
            // 
            // addNewCourseButton
            // 
            this.addNewCourseButton.BackColor = System.Drawing.Color.Silver;
            this.addNewCourseButton.Location = new System.Drawing.Point(105, 256);
            this.addNewCourseButton.Name = "addNewCourseButton";
            this.addNewCourseButton.Size = new System.Drawing.Size(256, 50);
            this.addNewCourseButton.TabIndex = 5;
            this.addNewCourseButton.Text = "Add New Course";
            this.addNewCourseButton.UseVisualStyleBackColor = false;
            // 
            // gradeValue
            // 
            this.gradeValue.Location = new System.Drawing.Point(173, 171);
            this.gradeValue.Name = "gradeValue";
            this.gradeValue.Size = new System.Drawing.Size(113, 34);
            this.gradeValue.TabIndex = 6;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gradeLabel.Location = new System.Drawing.Point(44, 172);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(76, 31);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Grade";
            // 
            // ectsValue
            // 
            this.ectsValue.Location = new System.Drawing.Point(173, 105);
            this.ectsValue.Name = "ectsValue";
            this.ectsValue.Size = new System.Drawing.Size(113, 34);
            this.ectsValue.TabIndex = 3;
            // 
            // ectsLabel
            // 
            this.ectsLabel.AutoSize = true;
            this.ectsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ectsLabel.Location = new System.Drawing.Point(48, 106);
            this.ectsLabel.Name = "ectsLabel";
            this.ectsLabel.Size = new System.Drawing.Size(64, 31);
            this.ectsLabel.TabIndex = 2;
            this.ectsLabel.Text = "ECTS";
            // 
            // courseNameValue
            // 
            this.courseNameValue.Location = new System.Drawing.Point(173, 59);
            this.courseNameValue.Name = "courseNameValue";
            this.courseNameValue.Size = new System.Drawing.Size(273, 34);
            this.courseNameValue.TabIndex = 1;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseNameLabel.Location = new System.Drawing.Point(16, 60);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(151, 31);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name";
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 28;
            this.coursesListBox.Location = new System.Drawing.Point(587, 88);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(389, 508);
            this.coursesListBox.TabIndex = 5;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(83, 145);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(256, 50);
            this.addCourseButton.TabIndex = 2;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.Location = new System.Drawing.Point(1005, 145);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(128, 50);
            this.removeCourseButton.TabIndex = 6;
            this.removeCourseButton.Text = "Remove";
            this.removeCourseButton.UseVisualStyleBackColor = true;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.averageLabel.Location = new System.Drawing.Point(374, 674);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(207, 59);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Text = "Average: ";
            // 
            // averageValueLabel
            // 
            this.averageValueLabel.AutoSize = true;
            this.averageValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.averageValueLabel.ForeColor = System.Drawing.Color.Crimson;
            this.averageValueLabel.Location = new System.Drawing.Point(594, 656);
            this.averageValueLabel.Name = "averageValueLabel";
            this.averageValueLabel.Size = new System.Drawing.Size(0, 81);
            this.averageValueLabel.TabIndex = 8;
            // 
            // calculateAverageButton
            // 
            this.calculateAverageButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateAverageButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.calculateAverageButton.FlatAppearance.BorderSize = 4;
            this.calculateAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateAverageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateAverageButton.ForeColor = System.Drawing.Color.Black;
            this.calculateAverageButton.Location = new System.Drawing.Point(587, 666);
            this.calculateAverageButton.Name = "calculateAverageButton";
            this.calculateAverageButton.Size = new System.Drawing.Size(235, 83);
            this.calculateAverageButton.TabIndex = 9;
            this.calculateAverageButton.Text = "Calculate";
            this.calculateAverageButton.UseVisualStyleBackColor = false;
            // 
            // AverageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 801);
            this.Controls.Add(this.calculateAverageButton);
            this.Controls.Add(this.averageValueLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.removeCourseButton);
            this.Controls.Add(this.coursesListBox);
            this.Controls.Add(this.addNewCourseGroupBox);
            this.Controls.Add(this.modifyCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.selectCourseDropDown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AverageCalculator";
            this.Text = "Average Calculator";
            this.addNewCourseGroupBox.ResumeLayout(false);
            this.addNewCourseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCourseDropDown;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Button modifyCourseButton;
        private System.Windows.Forms.GroupBox addNewCourseGroupBox;
        private System.Windows.Forms.Button addNewCourseButton;
        private System.Windows.Forms.TextBox gradeValue;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox ectsValue;
        private System.Windows.Forms.Label ectsLabel;
        private System.Windows.Forms.TextBox courseNameValue;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageValueLabel;
        private System.Windows.Forms.Button calculateAverageButton;
    }
}

