using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WaterBillCalculator
{
    public partial class MainForm : Form
    {
        private Dictionary<string, double> tariffTable = new Dictionary<string, double>()
        {
            { "00 - 05", 12.00 },
            { "06 - 10", 16.00 },
            { "11 - 15", 20.00 },
            { "16 - 20", 40.00 },
            { "21 - 25", 58.00 },
            { "26 - 30", 88.00 },
            { "31 - 40", 105.00 },
            { "41 - 50", 120.00 },
            { "51 - 75", 130.00 },
            { "Over 75", 140.00 }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            string[] customers = txtCustomers.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] usages = txtUsages.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Clear previous results
            lstResults.Items.Clear();

            // Display results for each customer
            for (int i = 0; i < customers.Length; i++)
            {
                string customer = customers[i].Trim();
                int usage;

                if (!int.TryParse(usages[i], out usage))
                {
                    MessageBox.Show("Invalid usage value for customer: " + customer);
                    continue;
                }

                double usageCharge = GetUsageCharge(usage);
                double serviceCharge = GetServiceCharge();
                double totalBill = usageCharge + serviceCharge;

                string result = string.Format("Month: {0} | Customer: {1} | Usage: {2} | Usage Charge: {3} | Service Charge: {4} | Total Bill: {5}",
                    month, customer, usage, usageCharge, serviceCharge, totalBill);

                lstResults.Items.Add(result);
            }
        }

        private double GetUsageCharge(int usage)
        {
            if (usage >= 0 && usage <= 5)
                return 12.00;
            else if (usage >= 6 && usage <= 10)
                return 16.00;
            else if (usage >= 11 && usage <= 15)
                return 20.00;
            else if (usage >= 16 && usage <= 20)
                return 40.00;
            else if (usage >= 21 && usage <= 25)
                return 58.00;
            else if (usage >= 26 && usage <= 30)
                return 88.00;
            else if (usage >= 31 && usage <= 40)
                return 105.00;
            else if (usage >= 41 && usage <= 50)
                return 120.00;
            else if (usage >= 51 && usage <= 75)
                return 130.00;
            else
                return 140.00;
        }

        private double GetServiceCharge()
        {
            if (tariffTable.Count > 0)
                return tariffTable.Values.Max();
            else
                return 0.00;
        }
    }
}
