namespace Activity_10
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultMax = new System.Windows.Forms.Label();
            this.labelResultMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(13, 13);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(334, 20);
            this.textInput.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(13, 40);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(334, 39);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(13, 85);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(171, 342);
            this.listViewResult.TabIndex = 2;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(193, 388);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 39);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(193, 343);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(159, 39);
            this.buttonMin.TabIndex = 5;
            this.buttonMin.Text = "Display Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(193, 298);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(159, 39);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "Display Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Display Result";
            // 
            // labelResultMax
            // 
            this.labelResultMax.AutoSize = true;
            this.labelResultMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMax.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelResultMax.Location = new System.Drawing.Point(190, 172);
            this.labelResultMax.Name = "labelResultMax";
            this.labelResultMax.Size = new System.Drawing.Size(103, 25);
            this.labelResultMax.TabIndex = 10;
            this.labelResultMax.Text = "Maximum:";
            // 
            // labelResultMin
            // 
            this.labelResultMin.AutoSize = true;
            this.labelResultMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultMin.Location = new System.Drawing.Point(190, 228);
            this.labelResultMin.Name = "labelResultMin";
            this.labelResultMin.Size = new System.Drawing.Size(97, 25);
            this.labelResultMin.TabIndex = 11;
            this.labelResultMin.Text = "Minimum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.labelResultMin);
            this.Controls.Add(this.labelResultMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Activity 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultMax;
        private System.Windows.Forms.Label labelResultMin;
    }
}

