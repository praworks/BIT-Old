using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
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
            tb_StudentNameOutput.Text = Form1.name;
            tb_RegNoOutput.Text= Form1.regNo;

            tb_module1_TotalMarks.Text = Convert.ToString(Form1.totalMarks1);
            tb_module1_Grage.Text = Convert.ToString(Form1.grade1);

            tb_module2_TotalMarks.Text = Convert.ToString(Form1.totalMarks2);
            tb_module2_Grage.Text = Convert.ToString(Form1.grade2);

            tb_module3_TotalMarks.Text = Convert.ToString(Form1.totalMarks3);
            tb_module3_Grage.Text = Convert.ToString(Form1.grade3);

            tb_module4_TotalMarks.Text = Convert.ToString(Form1.totalMarks4);
            tb_module4_Grage.Text = Convert.ToString(Form1.grade4);

            tb_module5_TotalMarks.Text = Convert.ToString(Form1.totalMarks5);
            tb_module5_Grage.Text = Convert.ToString(Form1.grade5);

        }
    }
}
