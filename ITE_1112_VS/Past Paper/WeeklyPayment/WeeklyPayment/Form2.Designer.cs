namespace WeeklyPayment
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_PaymentRateOutput = new System.Windows.Forms.TextBox();
            this.tb_WeeklyHrsOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_otHrsOutput = new System.Windows.Forms.TextBox();
            this.tb_TotalOutput = new System.Windows.Forms.TextBox();
            this.tb_OtPayOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_PaymentRateOutput
            // 
            this.tb_PaymentRateOutput.Location = new System.Drawing.Point(269, 166);
            this.tb_PaymentRateOutput.Name = "tb_PaymentRateOutput";
            this.tb_PaymentRateOutput.Size = new System.Drawing.Size(232, 27);
            this.tb_PaymentRateOutput.TabIndex = 9;
            // 
            // tb_WeeklyHrsOutput
            // 
            this.tb_WeeklyHrsOutput.Location = new System.Drawing.Point(269, 114);
            this.tb_WeeklyHrsOutput.Name = "tb_WeeklyHrsOutput";
            this.tb_WeeklyHrsOutput.Size = new System.Drawing.Size(232, 27);
            this.tb_WeeklyHrsOutput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(35, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hourly Payment Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "No of Hrs worked per week";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(382, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weekly Payment Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Payment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "OT Hrs";
            // 
            // tb_otHrsOutput
            // 
            this.tb_otHrsOutput.Location = new System.Drawing.Point(269, 232);
            this.tb_otHrsOutput.Name = "tb_otHrsOutput";
            this.tb_otHrsOutput.Size = new System.Drawing.Size(232, 27);
            this.tb_otHrsOutput.TabIndex = 14;
            // 
            // tb_TotalOutput
            // 
            this.tb_TotalOutput.Location = new System.Drawing.Point(269, 339);
            this.tb_TotalOutput.Name = "tb_TotalOutput";
            this.tb_TotalOutput.Size = new System.Drawing.Size(232, 27);
            this.tb_TotalOutput.TabIndex = 15;
            // 
            // tb_OtPayOutput
            // 
            this.tb_OtPayOutput.Location = new System.Drawing.Point(269, 282);
            this.tb_OtPayOutput.Name = "tb_OtPayOutput";
            this.tb_OtPayOutput.Size = new System.Drawing.Size(232, 27);
            this.tb_OtPayOutput.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "OT Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_OtPayOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_TotalOutput);
            this.Controls.Add(this.tb_otHrsOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_PaymentRateOutput);
            this.Controls.Add(this.tb_WeeklyHrsOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_PaymentRateOutput;
        private TextBox tb_WeeklyHrsOutput;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_otHrsOutput;
        private TextBox tb_TotalOutput;
        private TextBox tb_OtPayOutput;
        private Label label8;
        private Label label9;
    }
}