namespace WaterBillCalculator
{
    public partial class Form1 : Form
    {
        public static string month;
        public static string name;
        public static string unitRange;
        public static double units;
        public static double serviceCharge;
        public static double unitCharge;
        public static double totalUsageCharge;
        public static double totalBill;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = tb_Month.Text;
            name = tb_Name.Text;
            unitRange = cb_UnitRange.Text;
            units = Convert.ToDouble(tb_Units.Text);
           
            //00-05
            if (unitRange == "00-05") 
            {
                serviceCharge = 50;
                unitCharge = 12;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //06-10
            else if (unitRange == "06-10")
            {
                serviceCharge = 65;
                unitCharge = 16;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //11-15
            else if (unitRange == "10-15")
            {
                serviceCharge = 70;
                unitCharge = 20;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //16-20
            else if (unitRange == "16-20")
            {
                serviceCharge = 80;
                unitCharge = 40;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //21-25
            else if (unitRange == "21-25")
            {
                serviceCharge = 100;
                unitCharge = 58;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //26-30
            else if (unitRange == "26-30")
            {
                serviceCharge = 200;
                unitCharge = 88;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //31-40
            else if (unitRange == "31-40")
            {
                serviceCharge = 400;
                unitCharge = 105;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //41-50
            else if (unitRange == "41-50")
            {
                serviceCharge = 650;
                unitCharge = 120;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //51-75
            else if (unitRange == "51-75")
            {
                serviceCharge = 1000;
                unitCharge = 130;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

            //over 75
            else if (unitRange == "Over 75")
            {
                serviceCharge = 1600;
                unitCharge = 140;
                totalUsageCharge = unitCharge * units;
                totalBill = serviceCharge + totalUsageCharge;
            }

         

            Form2 form=new Form2();
            form.Show();


        }
    }
}