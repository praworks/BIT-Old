using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postage_Rate
{
    public partial class Form1 : Form
    {
        double price,additionalPrice,extra;
        int additionalWeight, totalWeight;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)

        {
            
            totalWeight = Convert.ToInt32(txtWeight.Text);
            string category = cmbCategory.SelectedItem.ToString();

            if (totalWeight < 100)

            {
                additionalWeight = totalWeight - 20;
                extra = additionalWeight % 10;



                if (category.Equals("A"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 15;
                        price = 55 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = (additionalWeight / 10) * 15 ;
                        price = 55+ 15 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }


                else if (category.Equals("B"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 15;
                        price = 60 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 15) + 15;
                        price = 60 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }


                else if (category.Equals("C"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 20;
                        price = 65 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 20) + 20;
                        price = 65 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }



                else if (category.Equals("D"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 20;
                        price = 70 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 20) + 20;
                        price = 70 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }



                else if (category.Equals("E"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 25;
                        price = 75 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 25) + 25;
                        price = 75 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }



                else if (category.Equals("F"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 25;
                        price = 80 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 25) + 25;
                        price = 80 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }



                else if (category.Equals("G"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 30;
                        price = 85 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 30) + 30;
                        price = 85 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }


                else if (category.Equals("H"))
                {

                    if (extra < 5)
                    {
                        additionalPrice = (additionalWeight / 10) * 40;
                        price = 110 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");

                    }
                    else
                    {
                        additionalPrice = ((additionalWeight / 10) * 40) + 40;
                        price = 110 + additionalPrice;
                        MessageBox.Show("Postage Price Is " + price + "LKR");
                    }
                }
                else
                {
                    MessageBox.Show("Ivalid Inputs");
                }


            }
            else
            {
                MessageBox.Show("Please Send This As A Small Packet");
            }
        }
    }
}
