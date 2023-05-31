using System;
using System.Windows.Forms;

namespace Loops_try_3
{
    public partial class FormWhileLoop : Form
    {
        public FormWhileLoop()
        {
            InitializeComponent();
        }

        private void btnSubWhileLoop_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxWhileLoop.Items.Clear();
                int i = Convert.ToInt32(this.txtInputWhileLoop.Text);
                //int i = 10;
                int j = 1;
                while (j <= i)
                {
                    int square = j * j;
                    listBoxWhileLoop.Items.Add(square);
                    j++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
