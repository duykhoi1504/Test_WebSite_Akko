namespace _32_Khoi_N1_KiemThuWebsiteGearVN
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
            this.btn_OpenWebsite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenWebsite
            // 
            this.btn_OpenWebsite.Location = new System.Drawing.Point(24, 21);
            this.btn_OpenWebsite.Name = "btn_OpenWebsite";
            this.btn_OpenWebsite.Size = new System.Drawing.Size(154, 23);
            this.btn_OpenWebsite.TabIndex = 0;
            this.btn_OpenWebsite.Text = "Truy cập trang web";
            this.btn_OpenWebsite.UseVisualStyleBackColor = true;
            this.btn_OpenWebsite.Click += new System.EventHandler(this.btn_OpenWebsite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OpenWebsite);
            this.groupBox1.Location = new System.Drawing.Point(162, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng_login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenWebsite;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

