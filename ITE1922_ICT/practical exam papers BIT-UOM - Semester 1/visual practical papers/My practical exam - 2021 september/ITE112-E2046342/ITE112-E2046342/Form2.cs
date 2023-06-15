using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE112_E2046342
{
    public partial class frmCalculate_42 : Form
    {
        private double number1;
        private double number2;
        private double result;
        private int intValidation;


        public frmCalculate_42()
        {
            InitializeComponent();
            
            number1 = 0;
            number2 = 0;


        }

        private void btnTheSum_42_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        number1 = int.Parse(txtInput_42.Text);
                        number2 = int.Parse(txt2_42.Text);

                        result = (number1 + number2);

                        lblSum_42.Text = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnTheSquare_42_Click(object sender, EventArgs e)
        {

        }

        private void btnTheMean_42_Click(object sender, EventArgs e)
        {

        }

        private void txt1_42_Validating(object sender, CancelEventArgs e)
        {
            
                errorProvider1.SetError(txtInput_42, "");

                if (!int.TryParse(txtInput_42.Text, out intValidation))
                {
                    errorProvider1.SetError(txtInput_42, "Please fill the required field");
                }
            
        }

        private void txt2_42_Validating(object sender, CancelEventArgs e)
        {

            errorProvider1.SetError(txt2_42, "");

            if (!int.TryParse(txt2_42.Text, out intValidation))
            {
                errorProvider1.SetError(txtInput_42, "Please fill the required field");
            }

        }

        private void lblC_42_Click(object sender, EventArgs e)
        {
            txtInput_42.Clear();
            txt2_42.Clear();
            lblSum_42.Text = "";
        
        }
    }
}
