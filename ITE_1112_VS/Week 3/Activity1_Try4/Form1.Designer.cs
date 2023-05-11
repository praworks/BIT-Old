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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(228, 42);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(263, 34);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.Text = "0";
            this.txtNumber1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber1_Validating);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(228, 106);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(263, 34);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.Text = "0";
            this.txtNumber2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber2_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(228, 178);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(263, 34);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "0";
            this.txtResult.Validating += new System.ComponentModel.CancelEventHandler(this.txtResult_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(228, 244);
            this.btnSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(262, 37);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 341);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Aggregation Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e) => throw new NotImplementedException();




        #endregion

        private Label label1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label2;
        private TextBox txtResult;
        private Label label3;
        private Button btnSum;
    }
}