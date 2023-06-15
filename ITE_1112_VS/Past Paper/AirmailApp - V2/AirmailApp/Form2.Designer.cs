namespace AirmailApp
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutput1 = new System.Windows.Forms.TextBox();
            this.tbOutput2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOutput3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postage for an Airmail Letter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country Category";
            // 
            // tbOutput1
            // 
            this.tbOutput1.Location = new System.Drawing.Point(363, 133);
            this.tbOutput1.Name = "tbOutput1";
            this.tbOutput1.Size = new System.Drawing.Size(125, 27);
            this.tbOutput1.TabIndex = 3;
            this.tbOutput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbOutput2
            // 
            this.tbOutput2.Location = new System.Drawing.Point(363, 210);
            this.tbOutput2.Name = "tbOutput2";
            this.tbOutput2.Size = new System.Drawing.Size(125, 27);
            this.tbOutput2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postage (LKR)";
            // 
            // tbOutput3
            // 
            this.tbOutput3.Location = new System.Drawing.Point(363, 288);
            this.tbOutput3.Name = "tbOutput3";
            this.tbOutput3.Size = new System.Drawing.Size(125, 27);
            this.tbOutput3.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOutput3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOutput2);
            this.Controls.Add(this.tbOutput1);
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

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbOutput1;
        private TextBox tbOutput2;
        private Label label4;
        private TextBox tbOutput3;
    }
}