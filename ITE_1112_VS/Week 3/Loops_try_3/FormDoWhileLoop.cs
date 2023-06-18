using System;
using System.Windows.Forms;

namespace Loops_try_3
{
    public partial class FormDoWhileLoop : Form
    {
        public FormDoWhileLoop()
        {
            InitializeComponent();
        }

        private void btnSubWhileLoop_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxWhileLoop.Items.Clear();
                int j = Convert.ToInt32(this.txtInputWhileLoop.Text);
                int i = 1;
                //int j = ;
                do
                {
                    listBoxWhileLoop.Items.Add(j);
                    j--;
                } while (j >= i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
