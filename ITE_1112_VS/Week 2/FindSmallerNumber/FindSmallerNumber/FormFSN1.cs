using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindSmallerNumber
{
    public partial class FormFSN1 : Form
    {
        decimal ischeckvalidation;
        public FormFSN1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(decimal.tryPhrase(textInput1.Text, out ischeckvalidation) && decimal.TryParse(textInput2.Text, out ischeckvalidation))
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
