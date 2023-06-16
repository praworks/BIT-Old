namespace airmail
{
    public partial class Form1 : Form
    {
      public static  double postage = 0;
        public static int weight = 0;
        public static string country = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPostage_click(object sender, EventArgs e)
        {   
            country = comboBox1.Text;
            int isCheck;
            double initiaPrice = 0;
            double additionalPrice = 0;
           
            if(int.TryParse(textBox_weight.Text, out isCheck) ) 
            {
                weight = int.Parse(textBox_weight.Text);
                var devideByTen = ((weight - 20) / 10);
                double modulus = ((weight - 20) % 10);

                if (modulus > 0)
                {
                    devideByTen = devideByTen + 1;
                }
                else if (modulus < 0)
                {
                    devideByTen = 0;
                }
                else if (devideByTen < 0)
                {
                    devideByTen = 0;
                }

                if (weight <= 100)
                {
                    if (comboBox1.Text == "A")
                    {
                        initiaPrice = 55;
                        additionalPrice = 15;
                    }
                    else if (comboBox1.Text == "B")
                    {
                        initiaPrice = 60;
                        additionalPrice = 15;
                    }
                    else if (comboBox1.Text == "C")
                    {
                        initiaPrice = 65;
                        additionalPrice = 20;
                    }
                    else if (comboBox1.Text == "D")
                    {
                        initiaPrice = 70;
                        additionalPrice = 20;
                    }
                    else if (comboBox1.Text == "E")
                    {
                        initiaPrice = 75;
                        additionalPrice = 25;
                    }
                    else if (comboBox1.Text == "F")
                    {
                        initiaPrice = 80;
                        additionalPrice = 25;
                    }
                    else if (comboBox1.Text == "G")
                    {
                        initiaPrice = 85;
                        additionalPrice = 30;
                    }
                    else if (comboBox1.Text == "H")
                    {
                        initiaPrice = 110;
                        additionalPrice = 40;
                    }
                    postage = initiaPrice + (devideByTen * additionalPrice);
                }
                else
                {
                    MessageBox.Show("Do you prefer to send it as a small packet?");
                    return;
                }

            }else
            {
                MessageBox.Show("Please input the correct format for weight");
                return;
            }


            Form2 frm = new Form2();
            frm.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}