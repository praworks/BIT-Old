namespace Activity_5
{
    partial class Activity_5
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
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Squares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess1
            // 
            this.btnProcess1.Location = new System.Drawing.Point(1, 1);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(66, 55);
            this.btnProcess1.TabIndex = 0;
            this.btnProcess1.Text = "Process 1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.Location = new System.Drawing.Point(73, 1);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(66, 55);
            this.btnProcess2.TabIndex = 1;
            this.btnProcess2.Text = "Process 2";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Squares,
            this.Cubes});
            this.dataGridView1.Location = new System.Drawing.Point(1, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Squares
            // 
            this.Squares.HeaderText = "Squares";
            this.Squares.Name = "Squares";
            // 
            // Cubes
            // 
            this.Cubes.HeaderText = "Cubes";
            this.Cubes.Name = "Cubes";
            // 
            // Activity_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.btnProcess1);
            this.Name = "Activity_5";
            this.Text = "Activity 5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Squares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cubes;
    }
}

