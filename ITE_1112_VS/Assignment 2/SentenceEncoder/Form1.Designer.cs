namespace SentenceEncoder
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSentence_56 = new System.Windows.Forms.TextBox();
            this.btnEncode_56 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncodedSentences_56 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1386, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "The application provides a user-friendly interface with text boxes to input the s" +
    "entence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type your sentance here";
            // 
            // txtSentence_56
            // 
            this.txtSentence_56.Location = new System.Drawing.Point(18, 144);
            this.txtSentence_56.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSentence_56.Name = "txtSentence_56";
            this.txtSentence_56.Size = new System.Drawing.Size(904, 35);
            this.txtSentence_56.TabIndex = 2;
            // 
            // btnEncode_56
            // 
            this.btnEncode_56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode_56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEncode_56.Location = new System.Drawing.Point(18, 197);
            this.btnEncode_56.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEncode_56.Name = "btnEncode_56";
            this.btnEncode_56.Size = new System.Drawing.Size(904, 52);
            this.btnEncode_56.TabIndex = 3;
            this.btnEncode_56.Text = "Encode";
            this.btnEncode_56.UseVisualStyleBackColor = true;
            this.btnEncode_56.Click += new System.EventHandler(this.btnEncode_56_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encoded sentance:";
            // 
            // txtEncodedSentences_56
            // 
            this.txtEncodedSentences_56.Location = new System.Drawing.Point(18, 341);
            this.txtEncodedSentences_56.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEncodedSentences_56.Multiline = true;
            this.txtEncodedSentences_56.Name = "txtEncodedSentences_56";
            this.txtEncodedSentences_56.Size = new System.Drawing.Size(904, 278);
            this.txtEncodedSentences_56.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 640);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(903, 56);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(605, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "and display the encoded sentences. ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEncodedSentences_56);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncode_56);
            this.Controls.Add(this.txtSentence_56);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Enigma encoder machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSentence_56;
        private System.Windows.Forms.Button btnEncode_56;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncodedSentences_56;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
    }
}

