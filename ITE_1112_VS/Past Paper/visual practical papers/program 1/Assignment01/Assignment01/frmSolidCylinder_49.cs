using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class FrmSolidCylinder : Form
    {
        public FrmSolidCylinder()
        {
            InitializeComponent();
        }

        private void btnArea_49_Click(object sender, EventArgs e)
        {
            double radius;
            double height;
            double area;

            if (double.TryParse(txtRadius_49.Text, out radius))
            {
                if (double.TryParse(txtHeight_49.Text, out height))
                {
                    area = ((Math.PI * radius * radius)*2) + ((Math.PI * radius * height)*2);
                    lblArea_49.Text = Math.Round(area, 2).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a proper value for the Height");
                }
            }
            else
            {
                MessageBox.Show("Please enter a proper value for the radius");
            }
        }

        private void btnVolume_49_Click(object sender, EventArgs e)
        {
            double radius;
            double height;
            double volume;

            if (double.TryParse(txtRadius_49.Text, out radius))
            {
                if (double.TryParse(txtHeight_49.Text, out height))
                {
                    volume = Math.PI * radius * radius * height;
                    lblVolume_49.Text = Math.Round(volume, 2).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a proper value for the Height");
                }
            }
            else
            {
                MessageBox.Show("Please enter a proper value for the Radius");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSolidCone frmSolidCone_49 = new FrmSolidCone();
            frmSolidCone_49.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSolidSphere frmSolidSphere = new FrmSolidSphere();
            frmSolidSphere.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSolidPyramid frmSolidPyramid = new FrmSolidPyramid();
            frmSolidPyramid.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
