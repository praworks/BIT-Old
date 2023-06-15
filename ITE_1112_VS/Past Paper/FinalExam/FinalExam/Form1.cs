namespace FinalExam
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string regNo;

        public static double caWeightage1;
        public static double caMarks1;
        public static double finalMarks1;
        public static double totalMarks1;
        public static string grade1;
        

        public static double caWeightage2;
        public static double caMarks2;
        public static double finalMarks2;
        public static double totalMarks2;
        public static string grade2;
        

        public static double caWeightage3;
        public static double caMarks3;
        public static double finalMarks3;
        public static double totalMarks3;
        public static string grade3;
        

        public static double caWeightage4;
        public static double caMarks4;
        public static double finalMarks4;
        public static double totalMarks4;
        public static string grade4;
        

        public static double caWeightage5;
        public static double caMarks5;
        public static double finalMarks5;
        public static double totalMarks5;
        public static string grade5;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = tb_StudentName.Text;
            regNo=tb_StudentName.Text;

            //Module 01

            caWeightage1 = Convert.ToDouble(tb_module1_CAweightage.Text);
            caMarks1 = Convert.ToDouble(tb_module1_CAmarks.Text);
            finalMarks1 = Convert.ToDouble(tb_module1_FinalMarks.Text);

            caWeightage2 = Convert.ToDouble(tb_module2_CAweightage.Text);
            caMarks2 = Convert.ToDouble(tb_module2_CAmarks.Text);
            finalMarks2 = Convert.ToDouble(tb_module2_FinalMarks.Text);

            caWeightage3 = Convert.ToDouble(tb_module3_CAweightage.Text);
            caMarks3 = Convert.ToDouble(tb_module3_CAmarks.Text);
            finalMarks3 = Convert.ToDouble(tb_module3_FinalMarks.Text);

            caWeightage4 = Convert.ToDouble(tb_module4_CAweightage.Text);
            caMarks4 = Convert.ToDouble(tb_module4_CAmarks.Text);
            finalMarks4 = Convert.ToDouble(tb_module4_FinalMarks.Text);

            caWeightage5 = Convert.ToDouble(tb_module5_CAweightage.Text);
            caMarks5 = Convert.ToDouble(tb_module5_CAmarks.Text);
            finalMarks5 = Convert.ToDouble(tb_module5_FinalMarks.Text);

            totalMarks1 = ((caMarks1 * caWeightage1) / 100) + (finalMarks1 * (100 - caWeightage1) / 100);

            {
                if (totalMarks1 < 40)
                {
                    grade1 = "F";
                }
                else if (totalMarks1 >= 40 && totalMarks1 <= 49)
                {
                    grade1 = "C-";
                }
                else if (totalMarks1 >= 50 && totalMarks1 <= 64)
                {
                    grade1 = "C";
                }
                else if (totalMarks1 >= 65 && totalMarks1 <= 79)
                {
                    grade1 = "B";
                }
                else if (totalMarks1 >= 80 && totalMarks1 <= 89)
                {
                    grade1 = "A";
                }
                else if (totalMarks1 >= 90)
                {
                    grade1 = "A+";
                }

            }
     

            //Module 02
           
            totalMarks2 = ((caMarks2 * caWeightage2) / 100) + (finalMarks2 * (100 - caWeightage2) / 100);

            {
                if (totalMarks2 < 40)
                {
                    grade2 = "F";
                }
                else if (totalMarks2 >= 40 && totalMarks2 <= 49)
                {
                    grade2 = "C-";
                }
                else if (totalMarks2 >= 50 && totalMarks2 <= 64)
                {
                    grade2 = "C";
                }
                else if (totalMarks2 >= 65 && totalMarks2 <= 79)
                {
                    grade2 = "B";
                }
                else if (totalMarks2 >= 80 && totalMarks2 <= 89)
                {
                    grade2 = "A";
                }
                else if (totalMarks2 >= 90)
                {
                    grade2 = "A+";
                }

            }
         

            //Module 03
            
            totalMarks3 = ((caMarks3 * caWeightage3) / 100) + (finalMarks3 * (100 - caWeightage3) / 100);

            {
                if (totalMarks3 < 40)
                {
                    grade3 = "F";
                }
                else if (totalMarks3 >= 40 && totalMarks3 <= 49)
                {
                    grade3 = "C-";
                }
                else if (totalMarks3 >= 50 && totalMarks3 <= 64)
                {
                    grade3 = "C";
                }
                else if (totalMarks3 >= 65 && totalMarks3 <= 79)
                {
                    grade3 = "B";
                }
                else if (totalMarks3 >= 80 && totalMarks3 <= 89)
                {
                    grade3 = "A";
                }
                else if (totalMarks3 >= 90)
                {
                    grade3 = "A+";
                }

            }

            //Module 04
           
            totalMarks4 = ((caMarks4* caWeightage4) / 100) + (finalMarks4 * (100 - caWeightage4) / 100);

            {
                if (totalMarks4 < 40)
                {
                    grade4 = "F";
                }
                else if (totalMarks4 >= 40 && totalMarks4 <= 49)
                {
                    grade4 = "C-";
                }
                else if (totalMarks4 >= 50 && totalMarks4 <= 64)
                {
                    grade4 = "C";
                }
                else if (totalMarks4 >= 65 && totalMarks4 <= 79)
                {
                    grade4 = "B";
                }
                else if (totalMarks4 >= 80 && totalMarks4 <= 89)
                {
                    grade4 = "A";
                }
                else if (totalMarks4 >= 90)
                {
                    grade4 = "A+";
                }

            }
   

            //Module 05
           
            totalMarks5 = ((caMarks5 * caWeightage5) / 100) + (finalMarks5 * (100 - caWeightage5) / 100);

            {
                if (totalMarks5 < 40)
                {
                    grade5 = "F";
                }
                else if (totalMarks5 >= 40 && totalMarks5 <= 49)
                {
                    grade5 = "C-";
                }
                else if (totalMarks5 >= 50 && totalMarks5 <= 64)
                {
                    grade5 = "C";
                }
                else if (totalMarks5 >= 65 && totalMarks5 <= 79)
                {
                    grade5 = "B";
                }
                else if (totalMarks5 >= 80 && totalMarks5 <= 89)
                {
                    grade5 = "A";
                }
                else if (totalMarks5 >= 90)
                {
                    grade5 = "A+";
                }

            }
           

            Form2 form=new Form2();
            form.Show();
        }
    }
}