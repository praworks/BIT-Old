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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void btnSolidCone_49_Click(object sender, EventArgs e)
        {

            FrmSolidCone frmSolidCone_49 = new FrmSolidCone();
            frmSolidCone_49.Show();
        }

        private void btnSolidCylinder_49_Click(object sender, EventArgs e)
        {
            FrmSolidCylinder frmSolidCylinder = new FrmSolidCylinder();
            frmSolidCylinder.Show();
        }

        private void btnSolidSphere_49_Click(object sender, EventArgs e)
        {
            FrmSolidSphere frmSolidSphere = new FrmSolidSphere();
            frmSolidSphere.Show();
        }

        private void btnSolidSBPyramid_49_Click(object sender, EventArgs e)
        {
            FrmSolidPyramid frmSolidPyramid = new FrmSolidPyramid();
            frmSolidPyramid.Show();
        }
    }
}
