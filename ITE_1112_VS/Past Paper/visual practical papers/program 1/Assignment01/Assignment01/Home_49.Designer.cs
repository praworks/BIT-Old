namespace Assignment01
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnSolidCone_49 = new System.Windows.Forms.Button();
            this.btnSolidCylinder_49 = new System.Windows.Forms.Button();
            this.btnSolidSphere_49 = new System.Windows.Forms.Button();
            this.btnSolidSBPyramid_49 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolidCone_49
            // 
            this.btnSolidCone_49.BackgroundImage = global::Assignment01.Properties.Resources._2;
            this.btnSolidCone_49.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCone_49.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSolidCone_49.Location = new System.Drawing.Point(49, 29);
            this.btnSolidCone_49.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolidCone_49.Name = "btnSolidCone_49";
            this.btnSolidCone_49.Size = new System.Drawing.Size(252, 76);
            this.btnSolidCone_49.TabIndex = 0;
            this.btnSolidCone_49.Text = "SOLID CONE";
            this.btnSolidCone_49.UseVisualStyleBackColor = true;
            this.btnSolidCone_49.Click += new System.EventHandler(this.btnSolidCone_49_Click);
            // 
            // btnSolidCylinder_49
            // 
            this.btnSolidCylinder_49.BackgroundImage = global::Assignment01.Properties.Resources._4;
            this.btnSolidCylinder_49.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCylinder_49.ForeColor = System.Drawing.Color.Aqua;
            this.btnSolidCylinder_49.Location = new System.Drawing.Point(373, 29);
            this.btnSolidCylinder_49.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolidCylinder_49.Name = "btnSolidCylinder_49";
            this.btnSolidCylinder_49.Size = new System.Drawing.Size(252, 76);
            this.btnSolidCylinder_49.TabIndex = 1;
            this.btnSolidCylinder_49.Text = "SOLID CYLINDER";
            this.btnSolidCylinder_49.UseVisualStyleBackColor = true;
            this.btnSolidCylinder_49.Click += new System.EventHandler(this.btnSolidCylinder_49_Click);
            // 
            // btnSolidSphere_49
            // 
            this.btnSolidSphere_49.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolidSphere_49.BackgroundImage")));
            this.btnSolidSphere_49.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidSphere_49.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSolidSphere_49.Location = new System.Drawing.Point(49, 156);
            this.btnSolidSphere_49.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolidSphere_49.Name = "btnSolidSphere_49";
            this.btnSolidSphere_49.Size = new System.Drawing.Size(252, 76);
            this.btnSolidSphere_49.TabIndex = 2;
            this.btnSolidSphere_49.Text = "SOLID SPHERE";
            this.btnSolidSphere_49.UseVisualStyleBackColor = true;
            this.btnSolidSphere_49.Click += new System.EventHandler(this.btnSolidSphere_49_Click);
            // 
            // btnSolidSBPyramid_49
            // 
            this.btnSolidSBPyramid_49.BackgroundImage = global::Assignment01.Properties.Resources._7;
            this.btnSolidSBPyramid_49.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidSBPyramid_49.ForeColor = System.Drawing.Color.Yellow;
            this.btnSolidSBPyramid_49.Location = new System.Drawing.Point(373, 156);
            this.btnSolidSBPyramid_49.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolidSBPyramid_49.Name = "btnSolidSBPyramid_49";
            this.btnSolidSBPyramid_49.Size = new System.Drawing.Size(252, 76);
            this.btnSolidSBPyramid_49.TabIndex = 3;
            this.btnSolidSBPyramid_49.Text = "SOLID SQURE-BASE PYRAMID";
            this.btnSolidSBPyramid_49.UseVisualStyleBackColor = true;
            this.btnSolidSBPyramid_49.Click += new System.EventHandler(this.btnSolidSBPyramid_49_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment01.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 258);
            this.Controls.Add(this.btnSolidSBPyramid_49);
            this.Controls.Add(this.btnSolidSphere_49);
            this.Controls.Add(this.btnSolidCylinder_49);
            this.Controls.Add(this.btnSolidCone_49);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Text = "Area and Volume Calculater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolidCone_49;
        private System.Windows.Forms.Button btnSolidCylinder_49;
        private System.Windows.Forms.Button btnSolidSphere_49;
        private System.Windows.Forms.Button btnSolidSBPyramid_49;
    }
}

