namespace WinFormsApp5
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
            this.txtSubject1 = new System.Windows.Forms.TextBox();
            this.txtSubject2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAvarage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.labelMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSubject1
            // 
            this.txtSubject1.Location = new System.Drawing.Point(311, 55);
            this.txtSubject1.Name = "txtSubject1";
            this.txtSubject1.Size = new System.Drawing.Size(357, 43);
            this.txtSubject1.TabIndex = 1;
            this.txtSubject1.Text = "0";
            // 
            // txtSubject2
            // 
            this.txtSubject2.Location = new System.Drawing.Point(311, 140);
            this.txtSubject2.Name = "txtSubject2";
            this.txtSubject2.Size = new System.Drawing.Size(357, 43);
            this.txtSubject2.TabIndex = 3;
            this.txtSubject2.Text = "0";
            this.txtSubject2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject 2";
            // 
            // txtAvarage
            // 
            this.txtAvarage.Location = new System.Drawing.Point(311, 235);
            this.txtAvarage.Name = "txtAvarage";
            this.txtAvarage.Size = new System.Drawing.Size(357, 43);
            this.txtAvarage.TabIndex = 5;
            this.txtAvarage.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(311, 322);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(357, 49);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Submit";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(700, 241);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(29, 37);
            this.labelMark.TabIndex = 8;
            this.labelMark.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtAvarage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubject2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubject1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aggregation Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSubject1;
        private TextBox txtSubject2;
        private Label label2;
        private TextBox txtAvarage;
        private Label label3;
        private Button btnSum;
        private Label labelMark;
    }
}