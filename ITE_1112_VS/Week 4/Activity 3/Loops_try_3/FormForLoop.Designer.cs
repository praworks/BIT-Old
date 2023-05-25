namespace Loops_try_3
{
    partial class FormForLoop
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
            this.txtInputForLoop = new System.Windows.Forms.TextBox();
            this.btnSubForLoop = new System.Windows.Forms.Button();
            this.listBoxForLoop = new System.Windows.Forms.ListBox();
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
            // txtInputForLoop
            // 
            this.txtInputForLoop.Location = new System.Drawing.Point(109, 25);
            this.txtInputForLoop.Name = "txtInputForLoop";
            this.txtInputForLoop.Size = new System.Drawing.Size(176, 20);
            this.txtInputForLoop.TabIndex = 1;
            // 
            // btnSubForLoop
            // 
            this.btnSubForLoop.Location = new System.Drawing.Point(109, 52);
            this.btnSubForLoop.Name = "btnSubForLoop";
            this.btnSubForLoop.Size = new System.Drawing.Size(176, 23);
            this.btnSubForLoop.TabIndex = 2;
            this.btnSubForLoop.Text = "Submit";
            this.btnSubForLoop.UseVisualStyleBackColor = true;
            this.btnSubForLoop.Click += new System.EventHandler(this.btnSubForLoop_Click);
            // 
            // listBoxForLoop
            // 
            this.listBoxForLoop.FormattingEnabled = true;
            this.listBoxForLoop.Location = new System.Drawing.Point(109, 82);
            this.listBoxForLoop.Name = "listBoxForLoop";
            this.listBoxForLoop.Size = new System.Drawing.Size(176, 355);
            this.listBoxForLoop.TabIndex = 3;
            // 
            // FormForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.listBoxForLoop);
            this.Controls.Add(this.btnSubForLoop);
            this.Controls.Add(this.txtInputForLoop);
            this.Controls.Add(this.label1);
            this.Name = "FormForLoop";
            this.Text = "For Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputForLoop;
        private System.Windows.Forms.Button btnSubForLoop;
        private System.Windows.Forms.ListBox listBoxForLoop;
    }
}

