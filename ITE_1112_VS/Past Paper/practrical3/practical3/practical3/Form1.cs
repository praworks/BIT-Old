namespace practical3
{
  
    public partial class Form1 : Form
    {
        public static string studentname;
        public static string registerNumber;
        public double vsFinalExamMark;
        public double WebFinalExamMark;
        public double MathsFinalExamMark;
        public double englishFinalExamMark;
        public double ictFinalExamMark;

        public double vsCaMark;
        public double webCaMark;
        public double mathsCaMark;
        public double englishCaMark;
        public double ictCaMark;

        public double vsCaWeigtage;
        public double webCaWeigtage;
        public double mathsCaWeigtage;
        public double englishCaWeigtage;
        public double ictCaWeigtage;

        public static double vsfinalMarks;
        public static double webfinalMarks;
        public static double mathsfinalMarks;
        public static double englishfinalMarks;
        public static double ictfinalMarks;

        public static string vsGrade;
        public static string webGrade;
        public static string mathsGrade;
        public static string englishGrade;
        public static string ictGrade;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_click(object sender, EventArgs e)
        {
            studentname = textBox_ST_Name.Text;
            registerNumber = textBox_RG_Number.Text;

            vsFinalExamMark = double.Parse(textBox_VS_FnlMark.Text);
            WebFinalExamMark = double.Parse(textBox_Web_FnlMark.Text);
            MathsFinalExamMark = double.Parse(textBox_Maths_FnlMark.Text);
            englishFinalExamMark = double.Parse(textBox_English_FnlMark.Text);
            ictFinalExamMark = double.Parse(textBox_ICT_FnlMark.Text);

            vsCaMark = double.Parse(textBox_VS_CA_Mark.Text);
            webCaMark = double.Parse(textBox_Web_CA_Mark.Text);
            mathsCaMark = double.Parse(textBox_Maths_CA_Mark.Text);
            englishCaMark = double.Parse(textBox_English_CA_Mark.Text);
            ictCaMark = double.Parse(textBox_ICT_CA_Mark.Text);

            vsCaWeigtage = double.Parse(textBox_VS_CA_Weightage.Text);
            webCaWeigtage = double.Parse(textBox_VS_CA_Weightage.Text);
            mathsCaWeigtage = double.Parse(textBox_VS_CA_Weightage.Text);
            englishCaWeigtage = double.Parse(textBox_VS_CA_Weightage.Text);
            ictCaWeigtage = double.Parse(textBox_VS_CA_Weightage.Text);


            vsfinalMarks = vsFinalExamMark * ((100 - vsCaWeigtage) / 100) + vsCaMark * (vsCaWeigtage / 100);
            if(vsfinalMarks < 40)
            {
                vsGrade = "F";
            }else if(vsfinalMarks >= 40 && vsfinalMarks < 49)
            {
                vsGrade = "C-";
            }
           
            else if (vsfinalMarks >= 50 && vsfinalMarks < 64)
            {
                vsGrade = "C";
            }
            else if (vsfinalMarks >= 65 && vsfinalMarks < 79)
            {
                vsGrade = "B";
            }
            else if (vsfinalMarks >= 80 && vsfinalMarks < 89)
            {
                vsGrade = "A";
            }
            else if (vsfinalMarks > 90)
            {
                vsGrade = "A+";
            }


            webfinalMarks = WebFinalExamMark * ((100 - webCaWeigtage) / 100) + webCaMark * (webCaWeigtage / 100);
            if (webfinalMarks < 40)
            {
                webGrade = "F";
            }
            else if (webfinalMarks >= 40 && webfinalMarks < 49)
            {
                webGrade = "C-";
            }

            else if (webfinalMarks >= 50 && webfinalMarks < 64)
            {
                webGrade = "C";
            }
            else if (webfinalMarks >= 65 && webfinalMarks < 79)
            {
                webGrade = "B";
            }
            else if (webfinalMarks >= 80 && webfinalMarks < 89)
            {
                webGrade = "A";
            }
            else if (webfinalMarks > 90)
            {
                webGrade = "A+";
            }


            mathsfinalMarks = englishFinalExamMark * ((100 - mathsCaWeigtage) / 100) + mathsCaMark * (mathsCaWeigtage / 100);
            if (mathsfinalMarks < 40)
            {
                mathsGrade = "F";
            }
            else if (mathsfinalMarks >= 40 && mathsfinalMarks < 49)
            {
                mathsGrade = "C-";
            }

            else if (mathsfinalMarks >= 50 && mathsfinalMarks < 64)
            {
                mathsGrade = "C";
            }
            else if (mathsfinalMarks >= 65 && mathsfinalMarks < 79)
            {
                mathsGrade = "B";
            }
            else if (mathsfinalMarks >= 80 && mathsfinalMarks < 89)
            {
                mathsGrade = "A";
            }
            else if (mathsfinalMarks > 90)
            {
                mathsGrade = "A+";
            }


            englishfinalMarks = englishFinalExamMark * ((100 - englishCaWeigtage) / 100) + englishCaMark * (englishCaWeigtage / 100);
            if (englishfinalMarks < 40)
            {
                englishGrade = "F";
            }
            else if (englishfinalMarks >= 40 && englishfinalMarks < 49)
            {
                englishGrade = "C-";
            }

            else if (englishfinalMarks >= 50 && englishfinalMarks < 64)
            {
                englishGrade = "C";
            }
            else if (englishfinalMarks >= 65 && englishfinalMarks < 79)
            {
                englishGrade = "B";
            }
            else if (englishfinalMarks >= 80 && englishfinalMarks < 89)
            {
                englishGrade = "A";
            }
            else if (englishfinalMarks > 90)
            {
                englishGrade = "A+";
            }



            ictfinalMarks = ictFinalExamMark * ((100 - ictCaWeigtage) / 100) + ictCaMark * (ictCaWeigtage / 100 );
            if (ictfinalMarks < 40)
            {
                ictGrade = "F";
            }
            else if (ictfinalMarks >= 40 && ictfinalMarks < 49)
            {
                ictGrade = "C-";
            }

            else if (ictfinalMarks >= 50 && ictfinalMarks < 64)
            {
                ictGrade = "C";
            }
            else if (ictfinalMarks >= 65 && ictfinalMarks < 79)
            {
                ictGrade = "B";
            }
            else if (ictfinalMarks >= 80 && ictfinalMarks < 89)
            {
                ictGrade = "A";
            }
            else if (ictfinalMarks > 90)
            {
                ictGrade = "A+";
            }


            Form2 frm = new Form2();
            frm.Show();
        }
    }
}