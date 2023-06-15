using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBillCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_MonthOutput.Text = Form1.month;
            tb_NameOutput.Text = Form1.name;
            tb_UnitRangeOutput.Text = Form1.unitRange;
            tb_UnitOutput.Text = Convert.ToString(Form1.units);
            tb_ServisechargeOutput.Text ="Rs. " + Convert.ToString(Form1.serviceCharge)+".00";
            tb_UsageChargeOutput.Text = "Rs. " + Convert.ToString(Form1.totalUsageCharge)+".00";
            tb_TotalbillOutput.Text= "Rs. " + Convert.ToString(Form1.totalBill)+".00";



        }
    }
}
