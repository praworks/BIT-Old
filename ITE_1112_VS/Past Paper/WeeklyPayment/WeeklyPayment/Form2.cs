using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyPayment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_WeeklyHrsOutput.Text = Convert.ToString(Form1.workedHrs);
            tb_PaymentRateOutput.Text = Convert.ToString(Form1.rate);
            tb_otHrsOutput.Text = Convert.ToString(Form1.otHrs);
            tb_OtPayOutput.Text = Convert.ToString(Form1.otPay);
            tb_TotalOutput.Text = Convert.ToString(Form1.total);
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
