using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Jump_example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            { 
                for(int a = 1; a <= 9; a++)
                {
                    int[] intList = new int[a];
                    for (int n = 1; n <= a; n++)
                    {
                        intList[(n - 1)] = n;
                    }

                    string printText = string.Empty;
                    foreach(var row in intList.ToList().OrderByDescending(i => i))
                    {
                        printText += " " + row;
                    }
                    listBoxResult.Items.Add(printText);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
