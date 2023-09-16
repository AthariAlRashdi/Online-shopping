namespace WindowsFormsApp1
{
    partial class Admin
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
            this.bttnADD = new System.Windows.Forms.Button();
            this.bttnUPDATE = new System.Windows.Forms.Button();
            this.bttnDELETE = new System.Windows.Forms.Button();
            this.bttnSHOW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(354, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin :";
            // 
            // bttnADD
            // 
            this.bttnADD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnADD.ForeColor = System.Drawing.Color.Blue;
            this.bttnADD.Location = new System.Drawing.Point(186, 117);
            this.bttnADD.Name = "bttnADD";
            this.bttnADD.Size = new System.Drawing.Size(75, 48);
            this.bttnADD.TabIndex = 1;
            this.bttnADD.Text = "ADD";
            this.bttnADD.UseVisualStyleBackColor = true;
            this.bttnADD.Click += new System.EventHandler(this.bttnADD_Click);
            // 
            // bttnUPDATE
            // 
            this.bttnUPDATE.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUPDATE.ForeColor = System.Drawing.Color.Blue;
            this.bttnUPDATE.Location = new System.Drawing.Point(297, 116);
            this.bttnUPDATE.Name = "bttnUPDATE";
            this.bttnUPDATE.Size = new System.Drawing.Size(79, 48);
            this.bttnUPDATE.TabIndex = 2;
            this.bttnUPDATE.Text = "UPDATE";
            this.bttnUPDATE.UseVisualStyleBackColor = true;
            // 
            // bttnDELETE
            // 
            this.bttnDELETE.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDELETE.ForeColor = System.Drawing.Color.Blue;
            this.bttnDELETE.Location = new System.Drawing.Point(408, 116);
            this.bttnDELETE.Name = "bttnDELETE";
            this.bttnDELETE.Size = new System.Drawing.Size(80, 48);
            this.bttnDELETE.TabIndex = 3;
            this.bttnDELETE.Text = "DELETE";
            this.bttnDELETE.UseVisualStyleBackColor = true;
            // 
            // bttnSHOW
            // 
            this.bttnSHOW.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSHOW.ForeColor = System.Drawing.Color.Blue;
            this.bttnSHOW.Location = new System.Drawing.Point(520, 116);
            this.bttnSHOW.Name = "bttnSHOW";
            this.bttnSHOW.Size = new System.Drawing.Size(75, 48);
            this.bttnSHOW.TabIndex = 4;
            this.bttnSHOW.Text = "SHOW";
            this.bttnSHOW.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 239);
            this.dataGridView1.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnSHOW);
            this.Controls.Add(this.bttnDELETE);
            this.Controls.Add(this.bttnUPDATE);
            this.Controls.Add(this.bttnADD);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnADD;
        private System.Windows.Forms.Button bttnUPDATE;
        private System.Windows.Forms.Button bttnDELETE;
        private System.Windows.Forms.Button bttnSHOW;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}