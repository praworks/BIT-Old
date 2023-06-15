
namespace ITE112_E2046342
{
    partial class frmWelcome_42
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
            this.btnSum_42 = new System.Windows.Forms.Button();
            this.btnSquare_42 = new System.Windows.Forms.Button();
            this.btnMean_42 = new System.Windows.Forms.Button();
            this.lblScreen_42 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSum_42
            // 
            this.btnSum_42.Location = new System.Drawing.Point(29, 89);
            this.btnSum_42.Name = "btnSum_42";
            this.btnSum_42.Size = new System.Drawing.Size(344, 55);
            this.btnSum_42.TabIndex = 0;
            this.btnSum_42.Text = "The Sum Of Numbers";
            this.btnSum_42.UseVisualStyleBackColor = true;
            this.btnSum_42.Click += new System.EventHandler(this.btnSum_Click_42);
            // 
            // btnSquare_42
            // 
            this.btnSquare_42.Location = new System.Drawing.Point(29, 177);
            this.btnSquare_42.Name = "btnSquare_42";
            this.btnSquare_42.Size = new System.Drawing.Size(344, 52);
            this.btnSquare_42.TabIndex = 1;
            this.btnSquare_42.Text = "The Square Of Numbers";
            this.btnSquare_42.UseVisualStyleBackColor = true;
            this.btnSquare_42.Click += new System.EventHandler(this.btnSquare_Click_42);
            // 
            // btnMean_42
            // 
            this.btnMean_42.Location = new System.Drawing.Point(29, 252);
            this.btnMean_42.Name = "btnMean_42";
            this.btnMean_42.Size = new System.Drawing.Size(344, 47);
            this.btnMean_42.TabIndex = 2;
            this.btnMean_42.Text = "The Mean Of Numbers";
            this.btnMean_42.UseVisualStyleBackColor = true;
            this.btnMean_42.Click += new System.EventHandler(this.btnMean_Click_42);
            // 
            // lblScreen_42
            // 
            this.lblScreen_42.AutoSize = true;
            this.lblScreen_42.Location = new System.Drawing.Point(109, 28);
            this.lblScreen_42.Name = "lblScreen_42";
            this.lblScreen_42.Size = new System.Drawing.Size(89, 13);
            this.lblScreen_42.TabIndex = 3;
            this.lblScreen_42.Text = "Welcome Screen";
            // 
            // frmWelcome_42
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 323);
            this.Controls.Add(this.lblScreen_42);
            this.Controls.Add(this.btnMean_42);
            this.Controls.Add(this.btnSquare_42);
            this.Controls.Add(this.btnSum_42);
            this.Name = "frmWelcome_42";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum_42;
        private System.Windows.Forms.Button btnSquare_42;
        private System.Windows.Forms.Button btnMean_42;
        private System.Windows.Forms.Label lblScreen_42;
    }
}

