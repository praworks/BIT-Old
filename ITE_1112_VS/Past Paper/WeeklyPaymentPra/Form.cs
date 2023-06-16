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
            // Get user input
            int hours;
            if (!int.TryParse(hoursTextBox.Text, out hours))
            {
                MessageBox.Show("Invalid input for hours worked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double rate;
            if (!double.TryParse(rateTextBox.Text, out rate))
            {
                MessageBox.Show("Invalid input for hourly rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate weekly pay
            double weeklyPay = CalculateWeeklyPay(hours, rate);

            // Display the result
            resultLabel.Text = "Weekly pay: $" + weeklyPay.ToString("0.00");
        }

        private double CalculateWeeklyPay(int hoursWorked, double hourlyRate)
        {
            if (hoursWorked < 20)
            {
                throw new Exception("Insufficient hours worked. Please work at least 20 hours per week.");
            }
            else if (hoursWorked > 50)
            {
                throw new Exception("Exceeded maximum hours allowed. Please work no more than 50 hours per week.");
            }

            int regularHours = Math.Min(hoursWorked, 40);
            int overtimeHours1 = Math.Min(Math.Max(hoursWorked - 40, 0), 5);
            int overtimeHours2 = Math.Max(hoursWorked - 45, 0);

            double regularPay = regularHours * hourlyRate;
            double overtimePay1 = overtimeHours1 * hourlyRate * 1.5;
            double overtimePay2 = overtimeHours2 * hourlyRate * 2;

            double totalPay = regularPay + overtimePay1 + overtimePay2;
            return totalPay;
        }
    }
}
