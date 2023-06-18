using System;
using System.Windows.Forms;

namespace SGPA_Calculator
{
    public partial class MainForm : Form
    {
        private const int MinimumCreditRating = 3;
        private const int MaximumCreditRating = 5;
        private const double MinSatisfactorySGPA = 2.0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            string registrationNumber = registrationNumberTextBox.Text;
            int[] credits = new int[5];
            double[] gradePoints = new double[5];

            // Read credits and grade points for each module
            for (int i = 0; i < 5; i++)
            {
                TextBox creditsTextBox = Controls.Find($"module{i + 1}CreditsTextBox", true)[0] as TextBox;
                TextBox gradeTextBox = Controls.Find($"module{i + 1}GradeTextBox", true)[0] as TextBox;

                if (int.TryParse(creditsTextBox.Text, out int credit) && double.TryParse(gradeTextBox.Text, out double grade))
                {
                    if (credit >= MinimumCreditRating && credit <= MaximumCreditRating)
                    {
                        credits[i] = credit;
                        gradePoints[i] = grade;
                    }
                    else
                    {
                        MessageBox.Show($"Credit rating for Module {i + 1} should be between {MinimumCreditRating} and {MaximumCreditRating}.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid input for Module {i + 1}.");
                    return;
                }
            }

            // Calculate SGPA
            double totalCredits = 0;
            double totalGradePoints = 0;

            for (int i = 0; i < 5; i++)
            {
                totalCredits += credits[i];
                totalGradePoints += credits[i] * gradePoints[i];
            }

            double sgpa = totalGradePoints / totalCredits;

            // Display SGPA
            sgpaLabel.Text = $"SGPA: {sgpa:F2}";

            // Check if performance is satisfactory
            if (sgpa < MinSatisfactorySGPA)
            {
                MessageBox.Show("Warning: Student's performance is not satisfactory.");
            }
        }
    }
}
