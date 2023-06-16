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
    public partial class FrmSolidSphere : Form
    {
        public FrmSolidSphere()
        {
            InitializeComponent();
        }

        private void btnArea_49_Click(object sender, EventArgs e)
        {
            double radius;
            double area;

            if (double.TryParse(txtRadius_49.Text, out radius))
            {
                area = ((Math.PI * radius * radius) * 4);
                lblArea_49.Text = Math.Round(area, 2).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a proper value for the Radius");
            }
        
        }

        private void btnVolume_49_Click(object sender, EventArgs e)
        {
            double radius;
            double volume;

            if (double.TryParse(txtRadius_49.Text, out radius))
            {
                volume = ((Math.PI * radius * radius * radius) * 4/3);
                lblVolume_49.Text = Math.Round(volume, 4).ToString();
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSolidCone_Click(object sender, EventArgs e)
        {
            FrmSolidCone frmSolidCone_49 = new FrmSolidCone();
            frmSolidCone_49.Show();
            this.Close();
        }

        private void btnSolidCylinder_Click(object sender, EventArgs e)
        {
            FrmSolidCylinder frmSolidCylinder = new FrmSolidCylinder();
            frmSolidCylinder.Show();
            this.Close();
        }

        private void btnSolidPyramid_Click(object sender, EventArgs e)
        {
            FrmSolidPyramid frmSolidPyramid = new FrmSolidPyramid();
            frmSolidPyramid.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
