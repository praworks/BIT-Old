namespace Week5_Jump_example1
{
    partial class Form1
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
            this.EnterNumber = new System.Windows.Forms.Label();
            this.inputEnterNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnterNumber
            // 
            this.EnterNumber.AutoSize = true;
            this.EnterNumber.Location = new System.Drawing.Point(12, 38);
            this.EnterNumber.Name = "EnterNumber";
            this.EnterNumber.Size = new System.Drawing.Size(108, 20);
            this.EnterNumber.TabIndex = 0;
            this.EnterNumber.Text = "Enter Number";
            // 
            // inputEnterNumber
            // 
            this.inputEnterNumber.Location = new System.Drawing.Point(145, 35);
            this.inputEnterNumber.Name = "inputEnterNumber";
            this.inputEnterNumber.Size = new System.Drawing.Size(303, 26);
            this.inputEnterNumber.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(147, 78);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(300, 28);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(145, 131);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(302, 444);
            this.listBoxResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 631);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.inputEnterNumber);
            this.Controls.Add(this.EnterNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNumber;
        private System.Windows.Forms.TextBox inputEnterNumber;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

