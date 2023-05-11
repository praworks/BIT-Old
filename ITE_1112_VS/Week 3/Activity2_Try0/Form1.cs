namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private int MarkSubject1;
        private int MarkSubject2;
        private int result;

        private bool bSubject1 = false;
        private bool bSubject2 = false;
        private bool bresult = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (bSubject1 == false && bSubject2 == false)

                MarkSubject1 = int.Parse(txtSubject1.Text);
                MarkSubject2 = int.Parse(txtSubject2.Text);

                result = ((MarkSubject1 + MarkSubject2) / 2);

                txtAvarage.Text = result.ToString();

                if (result >= 0 && result <= 40)
                {
                    labelMark.Text = "Grade F";
                }
                else if (result > 40 && result <= 65)
                {
                    labelMark.Text = "Grade C";
                }
                else if (result > 65 && result <= 75)
                {
                    labelMark.Text = "Grade B";
                }
                else if (result > 75 && result <= 100)
                {
                    labelMark.Text = "Grade A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
