namespace FindSmallerNumber
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
            this.btnSmallerNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSmallerNum
            // 
            this.btnSmallerNum.Location = new System.Drawing.Point(263, 119);
            this.btnSmallerNum.Name = "btnSmallerNum";
            this.btnSmallerNum.Size = new System.Drawing.Size(257, 98);
            this.btnSmallerNum.TabIndex = 0;
            this.btnSmallerNum.Text = "Find smaller Number";
            this.btnSmallerNum.UseVisualStyleBackColor = true;
            this.btnSmallerNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSmallerNum);
            this.Name = "Form1";
            this.Text = "Find Smaller Number";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSmallerNum;
    }
}