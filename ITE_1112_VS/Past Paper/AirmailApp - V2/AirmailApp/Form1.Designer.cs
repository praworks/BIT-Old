namespace AirmailApp
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
            this.comboBox1_CountryCategory = new System.Windows.Forms.ComboBox();
            this.textBox1_Weight = new System.Windows.Forms.TextBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight to the nearest gram";
            // 
            // comboBox1_CountryCategory
            // 
            this.comboBox1_CountryCategory.FormattingEnabled = true;
            this.comboBox1_CountryCategory.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.comboBox1_CountryCategory.Location = new System.Drawing.Point(420, 73);
            this.comboBox1_CountryCategory.Name = "comboBox1_CountryCategory";
            this.comboBox1_CountryCategory.Size = new System.Drawing.Size(151, 28);
            this.comboBox1_CountryCategory.TabIndex = 2;
            this.comboBox1_CountryCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1_Weight
            // 
            this.textBox1_Weight.Location = new System.Drawing.Point(420, 147);
            this.textBox1_Weight.Name = "textBox1_Weight";
            this.textBox1_Weight.Size = new System.Drawing.Size(151, 27);
            this.textBox1_Weight.TabIndex = 3;
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(326, 271);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(213, 103);
            this.button_Calculate.TabIndex = 4;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.textBox1_Weight);
            this.Controls.Add(this.comboBox1_CountryCategory);
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
        private ComboBox comboBox1_CountryCategory;
        private TextBox textBox1_Weight;
        private Button button_Calculate;
    }
}