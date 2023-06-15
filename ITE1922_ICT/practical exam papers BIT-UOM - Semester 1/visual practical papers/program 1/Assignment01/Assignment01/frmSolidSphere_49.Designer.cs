namespace Assignment01
{
    partial class FrmSolidSphere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolidSphere));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolume_49 = new System.Windows.Forms.Label();
            this.lblArea_49 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolume_49 = new System.Windows.Forms.Button();
            this.btnArea_49 = new System.Windows.Forms.Button();
            this.txtRadius_49 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSolidPyramid = new System.Windows.Forms.Button();
            this.btnSolidCone = new System.Windows.Forms.Button();
            this.btnSolidCylinder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment01.Properties.Resources.sphere;
            this.pictureBox1.Location = new System.Drawing.Point(358, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 279);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.BackgroundImage = global::Assignment01.Properties.Resources._14;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblVolume_49);
            this.groupBox1.Controls.Add(this.lblArea_49);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnVolume_49);
            this.groupBox1.Controls.Add(this.btnArea_49);
            this.groupBox1.Controls.Add(this.txtRadius_49);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 406);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculater";
            // 
            // lblVolume_49
            // 
            this.lblVolume_49.AutoSize = true;
            this.lblVolume_49.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblVolume_49.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume_49.ForeColor = System.Drawing.Color.Lime;
            this.lblVolume_49.Image = ((System.Drawing.Image)(resources.GetObject("lblVolume_49.Image")));
            this.lblVolume_49.Location = new System.Drawing.Point(154, 304);
            this.lblVolume_49.Name = "lblVolume_49";
            this.lblVolume_49.Size = new System.Drawing.Size(17, 19);
            this.lblVolume_49.TabIndex = 11;
            this.lblVolume_49.Text = "0";
            // 
            // lblArea_49
            // 
            this.lblArea_49.AutoSize = true;
            this.lblArea_49.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblArea_49.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea_49.ForeColor = System.Drawing.Color.Lime;
            this.lblArea_49.Image = ((System.Drawing.Image)(resources.GetObject("lblArea_49.Image")));
            this.lblArea_49.Location = new System.Drawing.Point(154, 256);
            this.lblArea_49.Name = "lblArea_49";
            this.lblArea_49.Size = new System.Drawing.Size(17, 19);
            this.lblArea_49.TabIndex = 10;
            this.lblArea_49.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(68, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(68, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // btnVolume_49
            // 
            this.btnVolume_49.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolume_49.BackgroundImage")));
            this.btnVolume_49.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume_49.ForeColor = System.Drawing.Color.Black;
            this.btnVolume_49.Location = new System.Drawing.Point(173, 162);
            this.btnVolume_49.Name = "btnVolume_49";
            this.btnVolume_49.Size = new System.Drawing.Size(97, 25);
            this.btnVolume_49.TabIndex = 7;
            this.btnVolume_49.Text = "Volume";
            this.btnVolume_49.UseVisualStyleBackColor = true;
            this.btnVolume_49.Click += new System.EventHandler(this.btnVolume_49_Click);
            // 
            // btnArea_49
            // 
            this.btnArea_49.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArea_49.BackgroundImage")));
            this.btnArea_49.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea_49.ForeColor = System.Drawing.Color.Black;
            this.btnArea_49.Location = new System.Drawing.Point(34, 162);
            this.btnArea_49.Name = "btnArea_49";
            this.btnArea_49.Size = new System.Drawing.Size(92, 25);
            this.btnArea_49.TabIndex = 6;
            this.btnArea_49.Text = "Area";
            this.btnArea_49.UseVisualStyleBackColor = true;
            this.btnArea_49.Click += new System.EventHandler(this.btnArea_49_Click);
            // 
            // txtRadius_49
            // 
            this.txtRadius_49.Location = new System.Drawing.Point(123, 73);
            this.txtRadius_49.Name = "txtRadius_49";
            this.txtRadius_49.Size = new System.Drawing.Size(147, 29);
            this.txtRadius_49.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Image = global::Assignment01.Properties.Resources._19;
            this.label1.Location = new System.Drawing.Point(31, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(398, 399);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSolidPyramid
            // 
            this.btnSolidPyramid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolidPyramid.BackgroundImage")));
            this.btnSolidPyramid.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidPyramid.Location = new System.Drawing.Point(541, 352);
            this.btnSolidPyramid.Name = "btnSolidPyramid";
            this.btnSolidPyramid.Size = new System.Drawing.Size(95, 23);
            this.btnSolidPyramid.TabIndex = 20;
            this.btnSolidPyramid.Text = "Solid Pyramid";
            this.btnSolidPyramid.UseVisualStyleBackColor = true;
            this.btnSolidPyramid.Click += new System.EventHandler(this.btnSolidPyramid_Click);
            // 
            // btnSolidCone
            // 
            this.btnSolidCone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolidCone.BackgroundImage")));
            this.btnSolidCone.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCone.Location = new System.Drawing.Point(443, 352);
            this.btnSolidCone.Name = "btnSolidCone";
            this.btnSolidCone.Size = new System.Drawing.Size(92, 23);
            this.btnSolidCone.TabIndex = 19;
            this.btnSolidCone.Text = "Solid Cone";
            this.btnSolidCone.UseVisualStyleBackColor = true;
            this.btnSolidCone.Click += new System.EventHandler(this.btnSolidCone_Click);
            // 
            // btnSolidCylinder
            // 
            this.btnSolidCylinder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolidCylinder.BackgroundImage")));
            this.btnSolidCylinder.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolidCylinder.Location = new System.Drawing.Point(338, 352);
            this.btnSolidCylinder.Name = "btnSolidCylinder";
            this.btnSolidCylinder.Size = new System.Drawing.Size(99, 23);
            this.btnSolidCylinder.TabIndex = 18;
            this.btnSolidCylinder.Text = "Solid Cylinder";
            this.btnSolidCylinder.UseVisualStyleBackColor = true;
            this.btnSolidCylinder.Click += new System.EventHandler(this.btnSolidCylinder_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(510, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FrmSolidSphere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment01.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSolidPyramid);
            this.Controls.Add(this.btnSolidCone);
            this.Controls.Add(this.btnSolidCylinder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSolidSphere";
            this.Text = "Solid Sphere";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVolume_49;
        private System.Windows.Forms.Label lblArea_49;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolume_49;
        private System.Windows.Forms.Button btnArea_49;
        private System.Windows.Forms.TextBox txtRadius_49;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSolidPyramid;
        private System.Windows.Forms.Button btnSolidCone;
        private System.Windows.Forms.Button btnSolidCylinder;
        private System.Windows.Forms.Button btnClose;
    }
}