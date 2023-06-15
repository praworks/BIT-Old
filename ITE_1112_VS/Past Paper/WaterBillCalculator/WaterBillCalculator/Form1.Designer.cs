namespace WaterBillCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Month = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cb_UnitRange = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Units = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Bill Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(700, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usage Units Range";
            // 
            // tb_Month
            // 
            this.tb_Month.Location = new System.Drawing.Point(231, 97);
            this.tb_Month.Name = "tb_Month";
            this.tb_Month.Size = new System.Drawing.Size(302, 27);
            this.tb_Month.TabIndex = 5;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(231, 161);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(302, 27);
            this.tb_Name.TabIndex = 6;
            // 
            // cb_UnitRange
            // 
            this.cb_UnitRange.FormattingEnabled = true;
            this.cb_UnitRange.Items.AddRange(new object[] {
            "00-05",
            "06-10",
            "11-15",
            "16-20",
            "21-25",
            "26-30",
            "31-40",
            "41-50",
            "51-75",
            "Over 75"});
            this.cb_UnitRange.Location = new System.Drawing.Point(231, 297);
            this.cb_UnitRange.Name = "cb_UnitRange";
            this.cb_UnitRange.Size = new System.Drawing.Size(302, 28);
            this.cb_UnitRange.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "No Of Units";
            // 
            // tb_Units
            // 
            this.tb_Units.Location = new System.Drawing.Point(231, 240);
            this.tb_Units.Name = "tb_Units";
            this.tb_Units.Size = new System.Drawing.Size(302, 27);
            this.tb_Units.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Range should be selected from drop down)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Units);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_UnitRange);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox tb_Month;
        private TextBox tb_Name;
        private ComboBox cb_UnitRange;
        private Label label5;
        private TextBox tb_Units;
        private Label label6;
    }
}