namespace practical1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_doubleOt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_basicSalary = new System.Windows.Forms.Label();
            this.label1_normalOT = new System.Windows.Forms.Label();
            this.textBox_PayRate = new System.Windows.Forms.TextBox();
            this.textBox_workHrs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(756, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal OT payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salary Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay Rate Per Hour";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Work Hours";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_doubleOt
            // 
            this.label_doubleOt.AutoSize = true;
            this.label_doubleOt.Location = new System.Drawing.Point(935, 290);
            this.label_doubleOt.Name = "label_doubleOt";
            this.label_doubleOt.Size = new System.Drawing.Size(16, 20);
            this.label_doubleOt.TabIndex = 0;
            this.label_doubleOt.Text = "?";
            this.label_doubleOt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(756, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(935, 378);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(16, 20);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "?";
            this.label_total.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(756, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doble OT payment";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(756, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Basic Salary";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_basicSalary
            // 
            this.label_basicSalary.AutoSize = true;
            this.label_basicSalary.Location = new System.Drawing.Point(935, 127);
            this.label_basicSalary.Name = "label_basicSalary";
            this.label_basicSalary.Size = new System.Drawing.Size(16, 20);
            this.label_basicSalary.TabIndex = 0;
            this.label_basicSalary.Text = "?";
            this.label_basicSalary.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1_normalOT
            // 
            this.label1_normalOT.AutoSize = true;
            this.label1_normalOT.Location = new System.Drawing.Point(935, 204);
            this.label1_normalOT.Name = "label1_normalOT";
            this.label1_normalOT.Size = new System.Drawing.Size(16, 20);
            this.label1_normalOT.TabIndex = 0;
            this.label1_normalOT.Text = "?";
            this.label1_normalOT.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_PayRate
            // 
            this.textBox_PayRate.Location = new System.Drawing.Point(221, 202);
            this.textBox_PayRate.Name = "textBox_PayRate";
            this.textBox_PayRate.Size = new System.Drawing.Size(125, 27);
            this.textBox_PayRate.TabIndex = 1;
            // 
            // textBox_workHrs
            // 
            this.textBox_workHrs.Location = new System.Drawing.Point(221, 131);
            this.textBox_workHrs.Name = "textBox_workHrs";
            this.textBox_workHrs.Size = new System.Drawing.Size(125, 27);
            this.textBox_workHrs.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_workHrs);
            this.Controls.Add(this.textBox_PayRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_basicSalary);
            this.Controls.Add(this.label1_normalOT);
            this.Controls.Add(this.label_doubleOt);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_doubleOt;
        private Label label6;
        private Label label_total;
        private Label label8;
        private Label label9;
        private Label label_basicSalary;
        private Label label1_normalOT;
        private TextBox textBox_PayRate;
        private TextBox textBox_workHrs;
        private Button button1;
        private Button button2;
    }
}