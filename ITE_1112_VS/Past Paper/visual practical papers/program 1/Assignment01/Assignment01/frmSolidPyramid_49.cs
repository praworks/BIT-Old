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
    public partial class FrmSolidPyramid : Form
    {
        public FrmSolidPyramid()
        {
            InitializeComponent();
        }

        private void btnArea_49_Click(object sender, EventArgs e)
        {
            double baseArea;
            double slanHeight;
            double basePerimeter;
            double area;

            if (double.TryParse(txtBaseRadius_49.Text, out baseArea))
            {
                if (double.TryParse(txtSlanHeight_49.Text, out basePerimeter))
                {
                    if (double.TryParse(txtBasePerimeter_49.Text, out slanHeight))
                    {
                        area = (baseArea + (basePerimeter * slanHeight) / 2);
                        lblArea_49.Text = Math.Round(area, 2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a proper value for the Base Perimeter");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a proper value for the Slan Height");
                }
            }
            else
            {
                MessageBox.Show("Please enter a proper value for the Base Radius");
            }
        }

        private void btnVolume_49_Click(object sender, EventArgs e)
        {
            double baseArea;
            double height;
            double volume;

            if (double.TryParse(txtBaseRadius_49.Text, out baseArea))
            {
                if (double.TryParse(txtHeight_49.Text, out height))
                {
                    volume = ((baseArea * height) / 3);
                    lblVolume_49.Text = Math.Round(volume, 2).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a proper value for the Height");
                }
            }

            else
            {
                MessageBox.Show("Please enter a proper value for the Base Radius");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSolidCone frmSolidCone_49 = new FrmSolidCone();
            frmSolidCone_49.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSolidCylinder frmSolidCylinder = new FrmSolidCylinder();
            frmSolidCylinder.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSolidSphere frmSolidSphere = new FrmSolidSphere();
            frmSolidSphere.Show();
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
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

