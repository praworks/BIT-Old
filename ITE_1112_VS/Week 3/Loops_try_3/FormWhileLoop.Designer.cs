using System;

namespace Loops_try_3
{
    partial class FormWhileLoop
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
            this.txtInputWhileLoop = new System.Windows.Forms.TextBox();
            this.btnSubWhileLoop = new System.Windows.Forms.Button();
            this.listBoxWhileLoop = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // txtInputWhileLoop
            // 
            this.txtInputWhileLoop.Location = new System.Drawing.Point(109, 25);
            this.txtInputWhileLoop.Name = "txtInputWhileLoop";
            this.txtInputWhileLoop.Size = new System.Drawing.Size(176, 20);
            this.txtInputWhileLoop.TabIndex = 1;
            // 
            // btnSubWhileLoop
            // 
            this.btnSubWhileLoop.Location = new System.Drawing.Point(109, 52);
            this.btnSubWhileLoop.Name = "btnSubWhileLoop";
            this.btnSubWhileLoop.Size = new System.Drawing.Size(176, 23);
            this.btnSubWhileLoop.TabIndex = 2;
            this.btnSubWhileLoop.Text = "Submit";
            this.btnSubWhileLoop.UseVisualStyleBackColor = true;
            this.btnSubWhileLoop.Click += new System.EventHandler(this.btnSubWhileLoop_Click);
            // 
            // listBoxWhileLoop
            // 
            this.listBoxWhileLoop.FormattingEnabled = true;
            this.listBoxWhileLoop.Location = new System.Drawing.Point(109, 108);
            this.listBoxWhileLoop.Name = "listBoxWhileLoop";
            this.listBoxWhileLoop.Size = new System.Drawing.Size(176, 329);
            this.listBoxWhileLoop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First 10 Square numbers";
            // 
            // FormWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxWhileLoop);
            this.Controls.Add(this.btnSubWhileLoop);
            this.Controls.Add(this.txtInputWhileLoop);
            this.Controls.Add(this.label1);
            this.Name = "FormWhileLoop";
            this.Text = "While Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSubForLoop_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputWhileLoop;
        private System.Windows.Forms.Button btnSubWhileLoop;
        private System.Windows.Forms.ListBox listBoxWhileLoop;
        private System.Windows.Forms.Label label2;
    }
}

