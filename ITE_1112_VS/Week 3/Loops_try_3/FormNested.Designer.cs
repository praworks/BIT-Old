namespace Loops_try_3
{
    partial class FormNested
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
            this.txtInputNested = new System.Windows.Forms.TextBox();
            this.btnSubNested = new System.Windows.Forms.Button();
            this.listBoxNested = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // txtInputNested
            // 
            this.txtInputNested.Location = new System.Drawing.Point(109, 25);
            this.txtInputNested.Name = "txtInputNested";
            this.txtInputNested.Size = new System.Drawing.Size(176, 20);
            this.txtInputNested.TabIndex = 1;
            // 
            // btnSubNested
            // 
            this.btnSubNested.Location = new System.Drawing.Point(109, 52);
            this.btnSubNested.Name = "btnSubNested";
            this.btnSubNested.Size = new System.Drawing.Size(176, 23);
            this.btnSubNested.TabIndex = 2;
            this.btnSubNested.Text = "Submit";
            this.btnSubNested.UseVisualStyleBackColor = true;
            this.btnSubNested.Click += new System.EventHandler(this.btnSubNested_Click);
            // 
            // listBoxNested
            // 
            this.listBoxNested.FormattingEnabled = true;
            this.listBoxNested.Location = new System.Drawing.Point(109, 82);
            this.listBoxNested.Name = "listBoxNested";
            this.listBoxNested.Size = new System.Drawing.Size(176, 355);
            this.listBoxNested.TabIndex = 3;
            // 
            // FormNested
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.listBoxNested);
            this.Controls.Add(this.btnSubNested);
            this.Controls.Add(this.txtInputNested);
            this.Controls.Add(this.label1);
            this.Name = "FormNested";
            this.Text = "Nested";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputNested;
        private System.Windows.Forms.Button btnSubNested;
        private System.Windows.Forms.ListBox listBoxNested;
    }
}

