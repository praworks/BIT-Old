﻿namespace Week_3_Activity_1_Try_3
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
            label1 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label2 = new Label();
            result = new TextBox();
            label3 = new Label();
            btnSub = new Button();
            object value = SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(176, 44);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(100, 23);
            txtNumber1.TabIndex = 1;
            txtNumber1.TextChanged += number1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(176, 88);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(100, 23);
            txtNumber2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // result
            // 
            result.Location = new Point(176, 131);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 139);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // btnSub
            // 
            btnSub.Location = new Point(189, 190);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 6;
            btnSub.Text = "Sum";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSub);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(txtNumber2);
            Controls.Add(label2);
            Controls.Add(txtNumber1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label2;
        private TextBox result;
        private Label label3;
        private Button btnSub;
    }
}