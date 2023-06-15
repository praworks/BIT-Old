namespace WeeklyPayment
{
    public partial class Form1 : Form
    {
        public static double workedHrs;
        public static double rate;
        public static double otHrs;
        public static double otPay;
        public static double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workedHrs=Convert.ToDouble(tb_WeeklyHrs.Text);
            rate=Convert.ToDouble(tb_PaymentRate.Text);
            
           if (workedHrs<20)
            {
                MessageBox.Show("Call to explanation");
            }

           else if(workedHrs>50)
            {
                MessageBox.Show("ERROR");
            }
           
            else if(workedHrs>=20 && workedHrs<=40 )
            {
               otHrs=0;
               otPay = 0;
               total=rate*workedHrs;
            }

           else if (workedHrs > 40 && workedHrs <=45)
            {
                otHrs = workedHrs-40;
                otPay = otHrs*1.5*rate;
                total = otPay + (40 * rate);
            }
            else if (workedHrs > 45 && workedHrs <= 50)
            {
                otHrs = workedHrs - 40;
                otPay = ((otHrs-5) * 2* rate)+(5*1.5*rate);
                total = otPay + (40 * rate);
            }

          Form2 form2 = new Form2();
            form2.Show();
        }
    }
}