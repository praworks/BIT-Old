using System;
using System.Windows.Forms;

namespace WeeklyPayCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            intializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int hoursWorked;
            double hourlyRate;
            // Parse user input
            if (!int.TryParse(hoursWorkedTextBox.Text, out hoursWorked)||!double.TryParse(hourlyRateTextBox.Text, out hourlyRate))






        }









    }
}