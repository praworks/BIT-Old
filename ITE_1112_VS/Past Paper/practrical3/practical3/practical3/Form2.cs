using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_Name.Text = Form1.studentname;
            textBox_RegiterNumber.Text = Form1.registerNumber;

            textBox_VS_Marks.Text = Convert.ToString(Form1.vsfinalMarks);
            textBox_Web_Marks.Text = Convert.ToString(Form1.webfinalMarks);
            textBox_Maths_Marks.Text = Convert.ToString(Form1.mathsfinalMarks);
            textBox_English_Marks.Text = Convert.ToString(Form1.englishfinalMarks);
            textBox_ICT_Marks.Text = Convert.ToString(Form1.ictfinalMarks);

            textBox_VS_Grade.Text = Convert.ToString(Form1.vsGrade);
            textBox_Web_Grade.Text = Convert.ToString(Form1.webGrade);
            textBox_Maths_Grade.Text = Convert.ToString(Form1.mathsGrade);
            textBox_English_Grade.Text = Convert.ToString(Form1.englishGrade);
            textBox_ICT_Grade.Text = Convert.ToString(Form1.ictGrade);
        }
    }
}
