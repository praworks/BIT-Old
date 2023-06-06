using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_10
{
    public partial class Form1 : Form
    {
        private int check_int, no;
        private int[] result;
        public Form1()
        {
            InitializeComponent();
            result = new int[10];
            no = 0;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            try
            {
                int min, max;

                min = result[0];
                max = result[0];

                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i] < min)
                        min = result[i];
                    if (max < result[i])
                        max = result[i];
                }

                labelResultMax.Text = String.Format("{0} {1}", "Maximum : ", max.ToString());
                labelResultMin.Text = String.Format("{0} {1}", "Minimum : ", min.ToString());
                textInput.Text = string.Empty;

                textInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            try
            {
                int min, max;

                min = result[0];
                max = result[0];

                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i] < min)
                        min = result[i];
                    if (max < result[i])
                        max = result[i];
                }

                labelResultMax.Text = String.Format("{0} {1}", "Maximum : ", max.ToString());
                labelResultMin.Text = String.Format("{0} {1}", "Minimum : ", min.ToString());
                textInput.Text = string.Empty;

                textInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textInput.Text = string.Empty;
            textInput.Focus();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((listViewResult.Items.Count + 1) <= 10)
                {
                    if (int.TryParse(textInput.Text, out check_int))
                    {
                        listViewResult.Items.Add(textInput.Text);
                        result[no] = int.Parse(textInput.Text);
                        no++;
                        textInput.Text = string.Empty;
                        textInput.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Input value is invalid");
                    }
                    if ((listViewResult.Items.Count) == 10)
                    {
                        buttonMin.Enabled = true;
                        buttonMax.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot enter more than 10 numbers");
                    textInput.Text = string.Empty;
                }
                textInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
