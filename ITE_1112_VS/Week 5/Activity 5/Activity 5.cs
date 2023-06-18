using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Activity_5 : Form
    {
        public Activity_5()
        {
            InitializeComponent();
        }
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            try
            {
                //standard process
                dataGridView1.Rows.Clear();
                for (int a = 0; a <= 10; a++)
                {
                    var numberVar = a;
                    var squaresVar = Math.Pow(a, 2);
                    var cubesVar = Math.Pow(a, 3);
                    dataGridView1.Rows.Add(numberVar, squaresVar, cubesVar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnProcess2_Click(object sender, EventArgs e)
        {
            try
            {
                //unstandard process
                dataGridView1.Rows.Clear();
                for (int a = 0; a <= 10; a++)
                {
                    var numberVar = a;
                    var squaresVar = (numberVar * numberVar);
                    var cubesVar = (numberVar * numberVar * numberVar);
                    dataGridView1.Rows.Add(numberVar, squaresVar, cubesVar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
