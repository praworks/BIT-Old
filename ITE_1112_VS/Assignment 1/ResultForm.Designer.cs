namespace Assignment_1
{
    partial class ResultForm
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
            this.labelSA = new System.Windows.Forms.Label();
            this.labelCA = new System.Windows.Forms.Label();
            this.labelFE = new System.Windows.Forms.Label();
            this.labelRN = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.labelCAW = new System.Windows.Forms.Label();
            this.labelMN = new System.Windows.Forms.Label();
            this.labelMC = new System.Windows.Forms.Label();
            this.labelFG = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.caMarksLabel = new System.Windows.Forms.Label();
            this.feMarksLabel = new System.Windows.Forms.Label();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.caWeightageLabel = new System.Windows.Forms.Label();
            this.moduleNameLabel = new System.Windows.Forms.Label();
            this.moduleCodeLabel = new System.Windows.Forms.Label();
            this.flagLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSA
            // 
            this.labelSA.AutoSize = true;
            this.labelSA.Location = new System.Drawing.Point(12, 193);
            this.labelSA.Name = "labelSA";
            this.labelSA.Size = new System.Drawing.Size(109, 13);
            this.labelSA.TabIndex = 22;
            this.labelSA.Text = "Student’s attendance";
            this.labelSA.Click += new System.EventHandler(this.labelSA_Click);
            // 
            // labelCA
            // 
            this.labelCA.AutoSize = true;
            this.labelCA.Location = new System.Drawing.Point(12, 165);
            this.labelCA.Name = "labelCA";
            this.labelCA.Size = new System.Drawing.Size(172, 13);
            this.labelCA.TabIndex = 21;
            this.labelCA.Text = "Continuous assessment (CA) marks";
            // 
            // labelFE
            // 
            this.labelFE.AutoSize = true;
            this.labelFE.Location = new System.Drawing.Point(12, 139);
            this.labelFE.Name = "labelFE";
            this.labelFE.Size = new System.Drawing.Size(183, 13);
            this.labelFE.TabIndex = 20;
            this.labelFE.Text = "End-semester examination (FE) marks";
            // 
            // labelRN
            // 
            this.labelRN.AutoSize = true;
            this.labelRN.Location = new System.Drawing.Point(12, 113);
            this.labelRN.Name = "labelRN";
            this.labelRN.Size = new System.Drawing.Size(101, 13);
            this.labelRN.TabIndex = 19;
            this.labelRN.Text = "Registration number";
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(12, 87);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(73, 13);
            this.labelSN.TabIndex = 18;
            this.labelSN.Text = "Student name";
            // 
            // labelCAW
            // 
            this.labelCAW.AutoSize = true;
            this.labelCAW.Location = new System.Drawing.Point(12, 61);
            this.labelCAW.Name = "labelCAW";
            this.labelCAW.Size = new System.Drawing.Size(170, 13);
            this.labelCAW.TabIndex = 17;
            this.labelCAW.Text = "Continuous assessment weightage";
            // 
            // labelMN
            // 
            this.labelMN.AutoSize = true;
            this.labelMN.Location = new System.Drawing.Point(12, 35);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(71, 13);
            this.labelMN.TabIndex = 16;
            this.labelMN.Text = "Module name";
            // 
            // labelMC
            // 
            this.labelMC.AutoSize = true;
            this.labelMC.Location = new System.Drawing.Point(12, 9);
            this.labelMC.Name = "labelMC";
            this.labelMC.Size = new System.Drawing.Size(69, 13);
            this.labelMC.TabIndex = 15;
            this.labelMC.Text = "Module code";
            // 
            // labelFG
            // 
            this.labelFG.AutoSize = true;
            this.labelFG.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFG.Location = new System.Drawing.Point(12, 237);
            this.labelFG.Name = "labelFG";
            this.labelFG.Size = new System.Drawing.Size(129, 13);
            this.labelFG.TabIndex = 23;
            this.labelFG.Text = "Final grade for the module";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gradeLabel.Location = new System.Drawing.Point(216, 237);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(174, 17);
            this.gradeLabel.TabIndex = 32;
            this.gradeLabel.Text = "Final grade for the module";
            this.gradeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Location = new System.Drawing.Point(216, 193);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(109, 13);
            this.attendanceLabel.TabIndex = 31;
            this.attendanceLabel.Text = "Student’s attendance";
            // 
            // caMarksLabel
            // 
            this.caMarksLabel.AutoSize = true;
            this.caMarksLabel.Location = new System.Drawing.Point(216, 165);
            this.caMarksLabel.Name = "caMarksLabel";
            this.caMarksLabel.Size = new System.Drawing.Size(172, 13);
            this.caMarksLabel.TabIndex = 30;
            this.caMarksLabel.Text = "Continuous assessment (CA) marks";
            // 
            // feMarksLabel
            // 
            this.feMarksLabel.AutoSize = true;
            this.feMarksLabel.Location = new System.Drawing.Point(216, 139);
            this.feMarksLabel.Name = "feMarksLabel";
            this.feMarksLabel.Size = new System.Drawing.Size(183, 13);
            this.feMarksLabel.TabIndex = 29;
            this.feMarksLabel.Text = "End-semester examination (FE) marks";
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Location = new System.Drawing.Point(216, 113);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.registrationNumberLabel.TabIndex = 28;
            this.registrationNumberLabel.Text = "Registration number";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(216, 87);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(73, 13);
            this.studentNameLabel.TabIndex = 27;
            this.studentNameLabel.Text = "Student name";
            // 
            // caWeightageLabel
            // 
            this.caWeightageLabel.AutoSize = true;
            this.caWeightageLabel.Location = new System.Drawing.Point(216, 61);
            this.caWeightageLabel.Name = "caWeightageLabel";
            this.caWeightageLabel.Size = new System.Drawing.Size(170, 13);
            this.caWeightageLabel.TabIndex = 26;
            this.caWeightageLabel.Text = "Continuous assessment weightage";
            // 
            // moduleNameLabel
            // 
            this.moduleNameLabel.AutoSize = true;
            this.moduleNameLabel.Location = new System.Drawing.Point(216, 35);
            this.moduleNameLabel.Name = "moduleNameLabel";
            this.moduleNameLabel.Size = new System.Drawing.Size(71, 13);
            this.moduleNameLabel.TabIndex = 25;
            this.moduleNameLabel.Text = "Module name";
            // 
            // moduleCodeLabel
            // 
            this.moduleCodeLabel.AutoSize = true;
            this.moduleCodeLabel.Location = new System.Drawing.Point(216, 9);
            this.moduleCodeLabel.Name = "moduleCodeLabel";
            this.moduleCodeLabel.Size = new System.Drawing.Size(69, 13);
            this.moduleCodeLabel.TabIndex = 24;
            this.moduleCodeLabel.Text = "Module code";
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flagLabel.Location = new System.Drawing.Point(216, 263);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(164, 13);
            this.flagLabel.TabIndex = 33;
            this.flagLabel.Text = "Final grade for the module reason";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.attendanceLabel);
            this.Controls.Add(this.caMarksLabel);
            this.Controls.Add(this.feMarksLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.caWeightageLabel);
            this.Controls.Add(this.moduleNameLabel);
            this.Controls.Add(this.moduleCodeLabel);
            this.Controls.Add(this.labelFG);
            this.Controls.Add(this.labelSA);
            this.Controls.Add(this.labelCA);
            this.Controls.Add(this.labelFE);
            this.Controls.Add(this.labelRN);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.labelCAW);
            this.Controls.Add(this.labelMN);
            this.Controls.Add(this.labelMC);
            this.Name = "ResultForm";
            this.Text = "Grade Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSA;
        private System.Windows.Forms.Label labelCA;
        private System.Windows.Forms.Label labelFE;
        private System.Windows.Forms.Label labelRN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelCAW;
        private System.Windows.Forms.Label labelMN;
        private System.Windows.Forms.Label labelMC;
        private System.Windows.Forms.Label labelFG;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Label caMarksLabel;
        private System.Windows.Forms.Label feMarksLabel;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label caWeightageLabel;
        private System.Windows.Forms.Label moduleNameLabel;
        private System.Windows.Forms.Label moduleCodeLabel;
        private System.Windows.Forms.Label flagLabel;
    }
}