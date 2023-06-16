using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airmail
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBox_weight.ReadOnly = true;
            textBox_country.ReadOnly = true;
            textBox_postage.ReadOnly = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_weight.Text = Convert.ToString(Form1.weight);
            textBox_country.Text = Form1.country;
            textBox_postage.Text = Convert.ToString(Form1.postage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
