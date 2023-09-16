namespace projecte
{
    partial class Details
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
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(87, 361);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(44, 16);
            this.lbl_phone.TabIndex = 4;
            this.lbl_phone.Text = "label1";
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Location = new System.Drawing.Point(87, 304);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(44, 16);
            this.lbl_sal.TabIndex = 3;
            this.lbl_sal.Text = "label1";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(90, 260);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(44, 16);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "label1";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(87, 192);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(44, 16);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "label1";
            this.lbl_UserName.Click += new System.EventHandler(this.lbl_UserName_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_sal);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_UserName;
    }
}