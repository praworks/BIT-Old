namespace practical1
{
    public partial class Form1 : Form
    {
       public double workHrs;
       public double payRate;
       public double basisSalary;
       public double normalOtPayment;
       public double doubleOtPayment;
       public double totalsalary;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                workHrs = double.Parse(textBox_workHrs.Text);
                payRate = double.Parse(textBox_PayRate.Text);
                
                if (workHrs >= 20 && workHrs <= 40)
                {
                    basisSalary = workHrs * payRate;
                    totalsalary = basisSalary;

                }
                else if (workHrs > 40 && workHrs <= 45)
                {
                    basisSalary = 40 * payRate;
                    normalOtPayment = (workHrs - 40) * payRate * 1.5;
                    totalsalary = basisSalary + normalOtPayment;
                }
                else if (workHrs > 45 && workHrs <= 50)
                {
                    basisSalary = 40 * payRate;
                    normalOtPayment = 5 * payRate;
                    doubleOtPayment = (workHrs - 45) * payRate * 2;
                    totalsalary = basisSalary + normalOtPayment + doubleOtPayment;
                }
                else if (workHrs > 50)
                {
                    MessageBox.Show("your work hours amount is greater than 50. Explanation should be made.");
                }
                else
                {
                    MessageBox.Show("your work hours amount is less than 20. Explanation should be made.");
                }
                label_basicSalary.Text = basisSalary.ToString();
                label1_normalOT.Text = normalOtPayment.ToString();
                label_doubleOt.Text = doubleOtPayment.ToString();
                label_total.Text = totalsalary.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_workHrs.Clear();
            textBox_PayRate.Clear();
            label_basicSalary.Text = "?";
            label1_normalOT.Text = "?";
            label_doubleOt.Text = "?";
            label_total.Text = "?";
        }
    }
}