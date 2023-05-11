namespace Hello_word
{
    public partial class HelloWord : Form
    {
        public HelloWord()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textinput.Text);
        }
    }
}