using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverages_1
{
    public partial class Condition : Form
    {
        public Condition()
        {
            InitializeComponent();
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            try
            {
                int isValidation;
                if (int.TryParse(txtInput.Text, out isValidation))
                {
                    if (int.Parse(txtInput.Text) == 1)
                    {
                        MessageBox.Show("Number 1 is: Coke");
                    }
                    else if (int.Parse(txtInput.Text) == 2)
                    {
                        MessageBox.Show("Number 2 is: Wine");
                    }
                    else if (int.Parse(txtInput.Text) == 3)
                    {
                        MessageBox.Show("Number 3 is: Sprite");
                    }
                    else if (int.Parse(txtInput.Text) == 4)
                    {
                        MessageBox.Show("Number 4 is: Fanta");
                    }
                    else if (int.Parse(txtInput.Text) == 5)
                    {
                        MessageBox.Show("Number 5 is: Barley");
                    }
                    else
                    {
                        MessageBox.Show("Out of range");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                int isValidation;
                if (int.TryParse(txtInput.Text, out isValidation))
                {
                    switch (int.Parse(txtInput.Text))
                    {
                        case 1:
                            MessageBox.Show("Number 1 is: Coke");
                            break;
                        case 2:
                            MessageBox.Show("Number 2 is: Wine");
                            break;
                        case 3:
                            MessageBox.Show("Number 3 is: Sprite");
                            break;
                        case 4:
                            MessageBox.Show("Number 4 is: Fanta");
                            break;
                        case 5:
                            MessageBox.Show("Number 5 is: Barley");
                            break;
                        default:
                            MessageBox.Show("Out of range");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearText()
        {
            txtInput.Text = string.Empty;
            txtInput.Focus();
        }

        private void txtInput_Enter(object sender, EventArgs e)
        { 
            txtInput.Text = string.Empty; 
        }
    }
}
