using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_practical_exam_august
{
    public partial class frmSalaryCalculator : Form
    {
        public frmSalaryCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hoursworked;
            double payrate;

            hoursworked = Convert.ToDouble(txtHoursWorked.Text);
            payrate = Convert.ToDouble(txtPayRate.Text);

            double salary = 0;
            if (hoursworked <= 40)
            {
                salary = (hoursworked * payrate);
                if (hoursworked < 20)
                {
                    MessageBox.Show("You must work above 20 hours");
                }
            }
            else if (hoursworked <= 45)
            {
                salary = (40 * payrate) + ((hoursworked - 40) * (payrate*1.5));
            }
            else if (hoursworked <= 50)
            {
                salary = (40 * payrate) + (5 * (payrate * 1.5)) + ((hoursworked - 45) * (payrate * 2));
            }
            else
            {
                MessageBox.Show("You can not enter hours of worked per week than 50 hours");
            }

            lblSalary.Text = Convert.ToString(salary);
        }
    }
}
