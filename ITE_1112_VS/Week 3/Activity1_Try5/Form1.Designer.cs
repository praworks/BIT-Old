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
            this.Number1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(122, 113);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(92, 25);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "Number 1";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(537, 107);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(150, 31);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.Text = "0";
            this.txtNumber1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber1_Validating);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(537, 167);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(150, 31);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.Text = "0";
            this.txtNumber2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber2_Validating);
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(122, 173);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(92, 25);
            this.Number2.TabIndex = 2;
            this.Number2.Text = "Number 2";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(537, 234);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(150, 31);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "0";
            this.txtResult.Validating += new System.ComponentModel.CancelEventHandler(this.txtResult_Validating);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(122, 240);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(59, 25);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(538, 289);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(112, 34);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 674);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Number1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label Number2;
        private TextBox txtResult;
        private Label Result;
        private Button btnSum;
    }
}