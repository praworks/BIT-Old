using System;
using System.Windows.Forms;

namespace Loops_try_3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForLoop formForLoop = new FormForLoop();
            formForLoop.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormWhileLoop formWhileLoop = new FormWhileLoop();
            formWhileLoop.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDoWhileLoop formDoWhileLoop = new FormDoWhileLoop();
            formDoWhileLoop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNested formNested = new FormNested();
            formNested.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
