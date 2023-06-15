namespace WeeklyPayment
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
            this.tb_WeeklyHrs = new System.Windows.Forms.TextBox();
            this.tb_PaymentRate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(409, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekly Payment Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(62, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Hrs worked per week";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(62, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Payment Rate";
            // 
            // tb_WeeklyHrs
            // 
            this.tb_WeeklyHrs.Location = new System.Drawing.Point(432, 181);
            this.tb_WeeklyHrs.Name = "tb_WeeklyHrs";
            this.tb_WeeklyHrs.Size = new System.Drawing.Size(232, 34);
            this.tb_WeeklyHrs.TabIndex = 3;
            // 
            // tb_PaymentRate
            // 
            this.tb_PaymentRate.Location = new System.Drawing.Point(432, 290);
            this.tb_PaymentRate.Name = "tb_PaymentRate";
            this.tb_PaymentRate.Size = new System.Drawing.Size(232, 34);
            this.tb_PaymentRate.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(710, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 94);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_PaymentRate);
            this.Controls.Add(this.tb_WeeklyHrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_WeeklyHrs;
        private TextBox tb_PaymentRate;
        private Button button1;
    }
}