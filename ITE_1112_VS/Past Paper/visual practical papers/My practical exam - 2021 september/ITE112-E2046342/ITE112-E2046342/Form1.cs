using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE112_E2046342
{
    public partial class frmWelcome_42 : Form
    {
        public frmWelcome_42()
        {
            InitializeComponent();
        }

        private void btnSum_Click_42(object sender, EventArgs e)
        {
            frmCalculate_42 frmCalculate_42 = new frmCalculate_42();
            frmCalculate_42.Show();

        }

        private void btnSquare_Click_42(object sender, EventArgs e)
        {
            frmCalculate_42 frmCalculate_42 = new frmCalculate_42();
            frmCalculate_42.Show();

        }

        private void btnMean_Click_42(object sender, EventArgs e)
        {
            frmCalculate_42 frmCalculate_42 = new frmCalculate_42();
            frmCalculate_42.Show();

        }
    }
}
