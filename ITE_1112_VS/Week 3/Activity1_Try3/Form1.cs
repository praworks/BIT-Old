using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sample.WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int number1 = 0;
        private int number2 = 0;
        private int result = 0;
        private int intValidation = 0;

        public Form()
        {
            InitializeComponent();
            txtResult.ReadOnly = true;
        }

        private void txtNumber1_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtNumber1.Text, out intValidation))
            {
                errorProvider.SetError(txtNumber1, "Please fill the required field");
            }
            else
            {
                errorProvider.SetError(txtNumber1, "");
            }
        }

        private void txtNumber2_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtNumber2.Text, out intValidation))
            {
                errorProvider.SetError(txtNumber2, "Please fill the required field");
            }
            else
            {
                errorProvider.SetError(txtNumber2, "");
            }
        }

        private void txtResult_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtResult.Text, out intValidation))
            {
                errorProvider.SetError(txtResult, "Please fill the required field");
            }
            else
            {
                errorProvider.SetError(txtResult, "");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    number1 = int.Parse(txtNumber1.Text);
                    number2 = int.Parse(txtNumber2.Text);
                    result = number1 + number2;
                    txtResult.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}