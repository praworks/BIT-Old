namespace Hello_word
{
    partial class HelloWord
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
            this.textinput = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textinput
            // 
            this.textinput.Location = new System.Drawing.Point(280, 165);
            this.textinput.Name = "textinput";
            this.textinput.Size = new System.Drawing.Size(150, 43);
            this.textinput.TabIndex = 0;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(280, 238);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(150, 48);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // HelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 1027);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textinput);
            this.Name = "HelloWord";
            this.Text = "HelloWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textinput;
        private Button Submit;
    }
}