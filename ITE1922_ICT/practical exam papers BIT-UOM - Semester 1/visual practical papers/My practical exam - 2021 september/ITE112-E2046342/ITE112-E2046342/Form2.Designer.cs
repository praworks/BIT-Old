
using System;

namespace ITE112_E2046342
{
    partial class frmCalculate_42
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
            this.components = new System.ComponentModel.Container();
            this.txtInput_42 = new System.Windows.Forms.TextBox();
            this.lblInput_42 = new System.Windows.Forms.Label();
            this.btnTheSum_42 = new System.Windows.Forms.Button();
            this.btnTheSquare_42 = new System.Windows.Forms.Button();
            this.lblSum_42 = new System.Windows.Forms.Label();
            this.lblSquare_42 = new System.Windows.Forms.Label();
            this.lblMean_42 = new System.Windows.Forms.Label();
            this.btnTheMean_42 = new System.Windows.Forms.Button();
            this.txt2_42 = new System.Windows.Forms.TextBox();
            this.lbl2_42 = new System.Windows.Forms.Label();
            this.lbl3_42 = new System.Windows.Forms.Label();
            this.txt3_42 = new System.Windows.Forms.TextBox();
            this.lbl4_42 = new System.Windows.Forms.Label();
            this.txt4_42 = new System.Windows.Forms.TextBox();
            this.lblmeann_42 = new System.Windows.Forms.Label();
            this.lblSqu_42 = new System.Windows.Forms.Label();
            this.lblSumm_42 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClear_42 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput_42
            // 
            this.txtInput_42.Location = new System.Drawing.Point(137, 72);
            this.txtInput_42.Name = "txtInput_42";
            this.txtInput_42.Size = new System.Drawing.Size(185, 20);
            this.txtInput_42.TabIndex = 0;
            this.txtInput_42.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_42_Validating);
            // 
            // lblInput_42
            // 
            this.lblInput_42.AutoSize = true;
            this.lblInput_42.Location = new System.Drawing.Point(34, 75);
            this.lblInput_42.Name = "lblInput_42";
            this.lblInput_42.Size = new System.Drawing.Size(80, 13);
            this.lblInput_42.TabIndex = 1;
            this.lblInput_42.Text = "Input Number 1";
            this.lblInput_42.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTheSum_42
            // 
            this.btnTheSum_42.Location = new System.Drawing.Point(23, 161);
            this.btnTheSum_42.Name = "btnTheSum_42";
            this.btnTheSum_42.Size = new System.Drawing.Size(129, 23);
            this.btnTheSum_42.TabIndex = 2;
            this.btnTheSum_42.Text = "Sum of numbers";
            this.btnTheSum_42.UseVisualStyleBackColor = true;
            this.btnTheSum_42.Click += new System.EventHandler(this.btnTheSum_42_Click);
            // 
            // btnTheSquare_42
            // 
            this.btnTheSquare_42.Location = new System.Drawing.Point(32, 329);
            this.btnTheSquare_42.Name = "btnTheSquare_42";
            this.btnTheSquare_42.Size = new System.Drawing.Size(129, 23);
            this.btnTheSquare_42.TabIndex = 3;
            this.btnTheSquare_42.Text = "Square of numbers";
            this.btnTheSquare_42.UseVisualStyleBackColor = true;
            this.btnTheSquare_42.Click += new System.EventHandler(this.btnTheSquare_42_Click);
            // 
            // lblSum_42
            // 
            this.lblSum_42.AutoSize = true;
            this.lblSum_42.Location = new System.Drawing.Point(198, 166);
            this.lblSum_42.Name = "lblSum_42";
            this.lblSum_42.Size = new System.Drawing.Size(13, 13);
            this.lblSum_42.TabIndex = 5;
            this.lblSum_42.Text = "0";
            // 
            // lblSquare_42
            // 
            this.lblSquare_42.AutoSize = true;
            this.lblSquare_42.Location = new System.Drawing.Point(205, 334);
            this.lblSquare_42.Name = "lblSquare_42";
            this.lblSquare_42.Size = new System.Drawing.Size(13, 13);
            this.lblSquare_42.TabIndex = 6;
            this.lblSquare_42.Text = "0";
            // 
            // lblMean_42
            // 
            this.lblMean_42.AutoSize = true;
            this.lblMean_42.Location = new System.Drawing.Point(205, 488);
            this.lblMean_42.Name = "lblMean_42";
            this.lblMean_42.Size = new System.Drawing.Size(13, 13);
            this.lblMean_42.TabIndex = 7;
            this.lblMean_42.Text = "0";
            // 
            // btnTheMean_42
            // 
            this.btnTheMean_42.Location = new System.Drawing.Point(23, 478);
            this.btnTheMean_42.Name = "btnTheMean_42";
            this.btnTheMean_42.Size = new System.Drawing.Size(127, 23);
            this.btnTheMean_42.TabIndex = 8;
            this.btnTheMean_42.Text = "Mean  of numbers";
            this.btnTheMean_42.UseVisualStyleBackColor = true;
            this.btnTheMean_42.Click += new System.EventHandler(this.btnTheMean_42_Click);
            // 
            // txt2_42
            // 
            this.txt2_42.Location = new System.Drawing.Point(137, 105);
            this.txt2_42.Name = "txt2_42";
            this.txt2_42.Size = new System.Drawing.Size(185, 20);
            this.txt2_42.TabIndex = 9;
            this.txt2_42.Validating += new System.ComponentModel.CancelEventHandler(this.txt2_42_Validating);
            // 
            // lbl2_42
            // 
            this.lbl2_42.AutoSize = true;
            this.lbl2_42.Location = new System.Drawing.Point(34, 112);
            this.lbl2_42.Name = "lbl2_42";
            this.lbl2_42.Size = new System.Drawing.Size(80, 13);
            this.lbl2_42.TabIndex = 10;
            this.lbl2_42.Text = "Input Number 2";
            // 
            // lbl3_42
            // 
            this.lbl3_42.AutoSize = true;
            this.lbl3_42.Location = new System.Drawing.Point(34, 289);
            this.lbl3_42.Name = "lbl3_42";
            this.lbl3_42.Size = new System.Drawing.Size(77, 13);
            this.lbl3_42.TabIndex = 11;
            this.lbl3_42.Text = "Input Number1";
            // 
            // txt3_42
            // 
            this.txt3_42.Location = new System.Drawing.Point(161, 286);
            this.txt3_42.Name = "txt3_42";
            this.txt3_42.Size = new System.Drawing.Size(185, 20);
            this.txt3_42.TabIndex = 12;
            // 
            // lbl4_42
            // 
            this.lbl4_42.AutoSize = true;
            this.lbl4_42.Location = new System.Drawing.Point(29, 438);
            this.lbl4_42.Name = "lbl4_42";
            this.lbl4_42.Size = new System.Drawing.Size(79, 13);
            this.lbl4_42.TabIndex = 13;
            this.lbl4_42.Text = "input Number 1";
            // 
            // txt4_42
            // 
            this.txt4_42.Location = new System.Drawing.Point(161, 435);
            this.txt4_42.Name = "txt4_42";
            this.txt4_42.Size = new System.Drawing.Size(185, 20);
            this.txt4_42.TabIndex = 14;
            // 
            // lblmeann_42
            // 
            this.lblmeann_42.AutoSize = true;
            this.lblmeann_42.Location = new System.Drawing.Point(177, 392);
            this.lblmeann_42.Name = "lblmeann_42";
            this.lblmeann_42.Size = new System.Drawing.Size(34, 13);
            this.lblmeann_42.TabIndex = 15;
            this.lblmeann_42.Text = "Mean";
            this.lblmeann_42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSqu_42
            // 
            this.lblSqu_42.AutoSize = true;
            this.lblSqu_42.Location = new System.Drawing.Point(177, 227);
            this.lblSqu_42.Name = "lblSqu_42";
            this.lblSqu_42.Size = new System.Drawing.Size(41, 13);
            this.lblSqu_42.TabIndex = 16;
            this.lblSqu_42.Text = "Square";
            // 
            // lblSumm_42
            // 
            this.lblSumm_42.AutoSize = true;
            this.lblSumm_42.Location = new System.Drawing.Point(177, 20);
            this.lblSumm_42.Name = "lblSumm_42";
            this.lblSumm_42.Size = new System.Drawing.Size(28, 13);
            this.lblSumm_42.TabIndex = 17;
            this.lblSumm_42.Text = "Sum";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblClear_42
            // 
            this.lblClear_42.Location = new System.Drawing.Point(395, 520);
            this.lblClear_42.Name = "lblClear_42";
            this.lblClear_42.Size = new System.Drawing.Size(75, 23);
            this.lblClear_42.TabIndex = 18;
            this.lblClear_42.Text = "Clear All";
            this.lblClear_42.UseVisualStyleBackColor = true;
            this.lblClear_42.Click += new System.EventHandler(this.lblC_42_Click);
            // 
            // frmCalculate_42
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 559);
            this.Controls.Add(this.lblClear_42);
            this.Controls.Add(this.lblSumm_42);
            this.Controls.Add(this.lblSqu_42);
            this.Controls.Add(this.lblmeann_42);
            this.Controls.Add(this.txt4_42);
            this.Controls.Add(this.lbl4_42);
            this.Controls.Add(this.txt3_42);
            this.Controls.Add(this.lbl3_42);
            this.Controls.Add(this.lbl2_42);
            this.Controls.Add(this.txt2_42);
            this.Controls.Add(this.btnTheMean_42);
            this.Controls.Add(this.lblMean_42);
            this.Controls.Add(this.lblSquare_42);
            this.Controls.Add(this.lblSum_42);
            this.Controls.Add(this.btnTheSquare_42);
            this.Controls.Add(this.btnTheSum_42);
            this.Controls.Add(this.lblInput_42);
            this.Controls.Add(this.txtInput_42);
            this.Name = "frmCalculate_42";
            this.Text = "Calculate Program";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput_42;
        private System.Windows.Forms.Label lblInput_42;
        private System.Windows.Forms.Button btnTheSum_42;
        private System.Windows.Forms.Button btnTheSquare_42;
        private System.Windows.Forms.Label lblSum_42;
        private System.Windows.Forms.Label lblSquare_42;
        private System.Windows.Forms.Label lblMean_42;
        private System.Windows.Forms.Button btnTheMean_42;
        private System.Windows.Forms.TextBox txt2_42;
        private System.Windows.Forms.Label lbl2_42;
        private System.Windows.Forms.Label lbl3_42;
        private System.Windows.Forms.TextBox txt3_42;
        private System.Windows.Forms.Label lbl4_42;
        private System.Windows.Forms.TextBox txt4_42;
        private System.Windows.Forms.Label lblmeann_42;
        private System.Windows.Forms.Label lblSqu_42;
        private System.Windows.Forms.Label lblSumm_42;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button lblClear_42;
    }
}