namespace WaterBillCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_MonthOutput = new System.Windows.Forms.TextBox();
            this.tb_UnitRangeOutput = new System.Windows.Forms.TextBox();
            this.tb_NameOutput = new System.Windows.Forms.TextBox();
            this.tb_UnitOutput = new System.Windows.Forms.TextBox();
            this.tb_UsageChargeOutput = new System.Windows.Forms.TextBox();
            this.tb_ServisechargeOutput = new System.Windows.Forms.TextBox();
            this.tb_TotalbillOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usage charge";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Water Bill Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "No Of Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usage Units Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Service Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Bill";
            // 
            // tb_MonthOutput
            // 
            this.tb_MonthOutput.Location = new System.Drawing.Point(312, 128);
            this.tb_MonthOutput.Name = "tb_MonthOutput";
            this.tb_MonthOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_MonthOutput.TabIndex = 15;
            // 
            // tb_UnitRangeOutput
            // 
            this.tb_UnitRangeOutput.Location = new System.Drawing.Point(312, 271);
            this.tb_UnitRangeOutput.Name = "tb_UnitRangeOutput";
            this.tb_UnitRangeOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_UnitRangeOutput.TabIndex = 17;
            // 
            // tb_NameOutput
            // 
            this.tb_NameOutput.Location = new System.Drawing.Point(312, 181);
            this.tb_NameOutput.Name = "tb_NameOutput";
            this.tb_NameOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_NameOutput.TabIndex = 18;
            // 
            // tb_UnitOutput
            // 
            this.tb_UnitOutput.Location = new System.Drawing.Point(312, 228);
            this.tb_UnitOutput.Name = "tb_UnitOutput";
            this.tb_UnitOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_UnitOutput.TabIndex = 19;
            // 
            // tb_UsageChargeOutput
            // 
            this.tb_UsageChargeOutput.Location = new System.Drawing.Point(312, 320);
            this.tb_UsageChargeOutput.Name = "tb_UsageChargeOutput";
            this.tb_UsageChargeOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_UsageChargeOutput.TabIndex = 20;
            // 
            // tb_ServisechargeOutput
            // 
            this.tb_ServisechargeOutput.Location = new System.Drawing.Point(312, 374);
            this.tb_ServisechargeOutput.Name = "tb_ServisechargeOutput";
            this.tb_ServisechargeOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_ServisechargeOutput.TabIndex = 21;
            // 
            // tb_TotalbillOutput
            // 
            this.tb_TotalbillOutput.Location = new System.Drawing.Point(312, 428);
            this.tb_TotalbillOutput.Name = "tb_TotalbillOutput";
            this.tb_TotalbillOutput.Size = new System.Drawing.Size(177, 27);
            this.tb_TotalbillOutput.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 672);
            this.Controls.Add(this.tb_TotalbillOutput);
            this.Controls.Add(this.tb_ServisechargeOutput);
            this.Controls.Add(this.tb_UsageChargeOutput);
            this.Controls.Add(this.tb_UnitOutput);
            this.Controls.Add(this.tb_NameOutput);
            this.Controls.Add(this.tb_UnitRangeOutput);
            this.Controls.Add(this.tb_MonthOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_MonthOutput;
        private TextBox tb_UnitRangeOutput;
        private TextBox tb_NameOutput;
        private TextBox tb_UnitOutput;
        private TextBox tb_UsageChargeOutput;
        private TextBox tb_ServisechargeOutput;
        private TextBox tb_TotalbillOutput;
    }
}