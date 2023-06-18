using System;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            int[] number = new int[11] { 5000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            try
            {
                int isCheck;
                if (int.TryParse(textInput.Text, out isCheck))
                {
                    int getModValue = int.Parse(textInput.Text);
                    dataGridView1.Rows.Clear();
                    for (int a = 0; a < number.Length; a++)
                    {
                        int getDivideNo = getModValue / number[a];
                        getModValue %= number[a];

                        dataGridView1.Rows.Add(string.Format("{0} /=", number[a]), getDivideNo);
                    }
                }
                else
                {
                    MessageBox.Show("Entered value is invalid");
                    textInput.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
