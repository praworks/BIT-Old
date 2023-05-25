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

namespace Activity_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int isCheck;
                if (int.TryParse(textInput.Text, out isCheck))
                {
                    var getValue = int.Parse(textInput.Text);
                    if (getValue > 0)
                    {
                        if (dataGridView1.Rows.Count < 10)
                        {
                            dataGridView1.Rows.Add(getValue, "");
                            textInput.Text = "";

                            if (dataGridView1.Rows.Count == 10)
                            {
                                MessageBox.Show("You have entered 10 numbers");
                                textInput.Focus();
                                textInput.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("You cannot enter more than 10 numbers");
                            textInput.Focus();
                            textInput.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot enter less than 1");
                        textInput.Focus();
                        textInput.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Entered value is invalid");
                    textInput.Focus();
                    textInput.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
