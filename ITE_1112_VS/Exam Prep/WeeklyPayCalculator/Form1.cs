using System;
using System.Windows.Forms;

namespace WeeklyPayCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int hoursWorked;
            double hourlyRate;

            // Parse user input
            if (!int.TryParse(hoursWorkedTextBox.Text, out hoursWorked) ||
                !double.TryParse(hourlyRateTextBox.Text, out hourlyRate))
            {
                MessageBox.Show("Invalid input! Please enter valid numeric values.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate hours worked
            if (hoursWorked < 20)
            {
                MessageBox.Show("Please work at least 20 hours per week.", "Call for Explanation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (hoursWorked > 50)
            {
                MessageBox.Show("You cannot work more than 50 hours per week.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate weekly pay
            double weeklyPay;
            if (hoursWorked <= 40)
            {
                weeklyPay = hoursWorked * hourlyRate;
            }
            else if (hoursWorked <= 45)
            {
                weeklyPay = (40 * hourlyRate) + ((hoursWorked - 40) * (hourlyRate * 1.5));
            }
            else
            {
                weeklyPay = (40 * hourlyRate) + (5 * (hourlyRate * 1.5)) + ((hoursWorked - 45) * (hourlyRate * 2));
            }

            // Display the result
            resultLabel.Text = $"Weekly Pay: LKR {weeklyPay:F2}";
        }
    }
}
