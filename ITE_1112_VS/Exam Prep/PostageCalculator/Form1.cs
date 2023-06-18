using System;
using System.Windows.Forms;

namespace PostageCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get user input
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            int weight = Convert.ToInt32(txtWeight.Text);

            // Calculate postage
            double postage = CalculatePostage(selectedCategory, weight);

            // Display results
            MessageBox.Show($"Letter Weight: {weight}g\nDestination Country Category: {selectedCategory}\nPostage: LKR {postage}");

            // Check if the letter is 100g or more
            if (weight >= 100)
            {
                DialogResult result = MessageBox.Show("Would you like to send it as a small packet?", "Send as Small Packet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Handle sending as a small packet
                }
            }
        }

        private double CalculatePostage(string category, int weight)
        {
            double postage = 0.0;

            switch (category)
            {
                case "A":
                    postage = 55.00 + ((weight - 20) / 10) * 15.00;
                    break;
                case "B":
                    postage = 60.00 + ((weight - 20) / 10) * 15.00;
                    break;
                case "C":
                    postage = 65.00 + ((weight - 20) / 10) * 20.00;
                    break;
                case "D":
                    postage = 70.00 + ((weight - 20) / 10) * 20.00;
                    break;
                case "E":
                    postage = 75.00 + ((weight - 20) / 10) * 25.00;
                    break;
                case "F":
                    postage = 80.00 + ((weight - 20) / 10) * 25.00;
                    break;
                case "G":
                    postage = 85.00 + ((weight - 20) / 10) * 30.00;
                    break;
                case "H":
                    postage = 110.00 + ((weight - 20) / 10) * 40.00;
                    break;
            }

            return postage;
        }
    }
}
