using System;
using System.Windows.Forms;

namespace Loops_try_3
{
    public partial class FormForLoop : Form
    {
        public FormForLoop()
        {
            InitializeComponent();
        }

        private void btnSubForLoop_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxForLoop.Items.Clear();
                int i = Convert.ToInt32(this.txtInputForLoop.Text);
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        listBoxForLoop.Items.Add(j);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
