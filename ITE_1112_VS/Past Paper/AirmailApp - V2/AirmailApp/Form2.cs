﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirmailApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbOutput1.Text = Convert.ToString(Form1.weightNearest);
            tbOutput2.Text=Form1.countryCategory;
            tbOutput3.Text =Convert.ToString( Form1.postage);

        }
    }
}
