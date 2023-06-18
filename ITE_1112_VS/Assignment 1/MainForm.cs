using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string moduleCode = moduleCodeTextBox.Text;
            string moduleName = moduleNameTextBox.Text;
            int caWeightage = int.Parse(caWeightageTextBox.Text);
            string studentName = studentNameTextBox.Text;
            string registrationNumber = registrationNumberTextBox.Text;
            int feMarks = int.Parse(feMarksTextBox.Text);
            int caMarks = int.Parse(caMarksTextBox.Text);
            int attendance = int.Parse(attendanceTextBox.Text);

            // Calculate total mark
            int totalMark = (feMarks * (100 - caWeightage) + caMarks * caWeightage) / 100;

            // Calculate grade based on total mark and attendance
            string grade;
            bool flag = false;

            if (attendance < 60)
            {
                grade = "F";
                flag = true;
            }
            else if (attendance < 80)
            {
                grade = "C";
            }
            else if (totalMark >= 85)
            {
                grade = "A";
            }
            else if (totalMark >= 65)
            {
                grade = "B";
            }
            else if (totalMark >= 50)
            {
                grade = "C";
            }
            else if (totalMark >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            // Display the results on a new form
            ResultForm resultForm = new ResultForm(moduleCode, moduleName, caWeightage, studentName, registrationNumber, feMarks, caMarks, totalMark, attendance, grade, flag);
            resultForm.Show();
        }
    }

    public partial class ResultForm : Form
    {
        public ResultForm(string moduleCode, string moduleName, int caWeightage, string studentName, string registrationNumber, int feMarks, int caMarks, int totalMark, int attendance, string grade, bool flag)
        {
            InitializeComponent();

            moduleCodeLabel.Text = moduleCode;
            moduleNameLabel.Text = moduleName;
            caWeightageLabel.Text = caWeightage.ToString();
            studentNameLabel.Text = studentName;
            registrationNumberLabel.Text = registrationNumber;
            feMarksLabel.Text = feMarks.ToString();
            caMarksLabel.Text = caMarks.ToString();
            attendanceLabel.Text = attendance.ToString();
            //totalMarkLabel.Text = totalMark.ToString();
            gradeLabel.Text = grade;

            if (flag)
            {
                flagLabel.Text = "Grade adjusted due to poor attendance";
            }
            else
            {
                flagLabel.Text = "";
            }
        }
    }
}