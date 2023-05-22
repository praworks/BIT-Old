using System;
using System.Windows.Forms;

namespace Loops_try_3
{
    public partial class FormNested : Form
    {
        public FormNested()
        {
            InitializeComponent();
        }

        private void btnSubNested_Click(object sender, EventArgs e)
        {

            listBoxNested.Items.Clear();
            int input = Convert.ToInt32(this.txtInputNested.Text);
            for (int row = 1; row <= input; ++row)
            {
                var text = "";
                for (int col = 1; col <= row; ++col)
                {
                    text += "* ";
                }
                listBoxNested.Items.Add(text);
                listBoxNested.Items.Add("\n");

            }
        }
    }
}