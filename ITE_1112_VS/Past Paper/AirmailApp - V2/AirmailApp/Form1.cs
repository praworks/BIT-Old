namespace AirmailApp
{
    public partial class Form1 : Form
    {
        public static string countryCategory;
        public static double weightNearest;
        public static double basicPrice;
        public static double additinalWeight;
        public static double addunits;
        public static double postage;
        public static double variableX;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            countryCategory = comboBox1_CountryCategory.Text;
            weightNearest = Convert.ToDouble(textBox1_Weight.Text);
         
                    

            //country category = A

            if (comboBox1_CountryCategory.Text == "A") 
            {
                basicPrice = 55;
                variableX = 15;
            }
            //country category = B

            else if (comboBox1_CountryCategory.Text == "B") 
            {
                basicPrice = 60;
                variableX = 15;            
            }

            //country category = C

            else if (comboBox1_CountryCategory.Text == "C") 
            {
                basicPrice = 65;
                variableX = 20;            
            }

            //country category = D

            else if (comboBox1_CountryCategory.Text == "D") 
            {
                basicPrice = 70;
                variableX = 20;           
            }

            //country category = E

           else if (comboBox1_CountryCategory.Text == "E") 
            {
                basicPrice = 75;
                variableX = 25;          
            }

            //country category = F

            else if (comboBox1_CountryCategory.Text == "F") 
            {
                basicPrice = 80;
                variableX = 25;         
            }

            //country category = G

           else if (comboBox1_CountryCategory.Text == "G") 
            {
                basicPrice = 85;
                variableX = 30;             
            }

            //country category = H

            else if (comboBox1_CountryCategory.Text == "H") 
            {
                basicPrice = 110;
                variableX = 40;         
            }

            additinalWeight = weightNearest - 20;
            if (additinalWeight > 0 && additinalWeight <= 10)
            {
                addunits = 1;
            }

            if (additinalWeight > 10 && additinalWeight <= 20)
            {
                addunits = 2;
            }

            if (additinalWeight>20 && additinalWeight <=30)
            {
                addunits = 3;
            }
            if (additinalWeight > 30 && additinalWeight <= 40)
            {
                addunits = 4;
            }
            if (additinalWeight > 40 && additinalWeight <= 50)
            {
                addunits = 5;
            }
            if (additinalWeight > 50 && additinalWeight <= 60)
            {
                addunits = 6;
            }
            if (additinalWeight > 60 && additinalWeight <= 70)
            {
                addunits = 7;
            }
            if (additinalWeight > 70 && additinalWeight <= 80)
            {
                addunits = 8;
            }
            if (additinalWeight > 80)
            {
                MessageBox.Show("Prefer to send as small packet");
            }
           

            postage = basicPrice + variableX * addunits;
            Form2 form=new Form2();
            form.Show();

        }

    } 
}