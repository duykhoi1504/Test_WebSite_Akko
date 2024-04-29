namespace _32_Khoi_N1_KiemThuWebSiteUdemy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_32_Khoi_TruyCapTrangWeb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_tc1_32_Khoi_DangNhapThanhCong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_32_Khoi_TruyCapTrangWeb);
            this.groupBox1.Location = new System.Drawing.Point(148, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TestCase_Login";
            // 
            // btn_32_Khoi_TruyCapTrangWeb
            // 
            this.btn_32_Khoi_TruyCapTrangWeb.Location = new System.Drawing.Point(24, 21);
            this.btn_32_Khoi_TruyCapTrangWeb.Name = "btn_32_Khoi_TruyCapTrangWeb";
            this.btn_32_Khoi_TruyCapTrangWeb.Size = new System.Drawing.Size(383, 36);
            this.btn_32_Khoi_TruyCapTrangWeb.TabIndex = 0;
            this.btn_32_Khoi_TruyCapTrangWeb.Text = "Truy cập trang web";
            this.btn_32_Khoi_TruyCapTrangWeb.UseVisualStyleBackColor = true;
            this.btn_32_Khoi_TruyCapTrangWeb.Click += new System.EventHandler(this.btn_32_Khoi_TruyCapTrangWeb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_tc1_32_Khoi_DangNhapThanhCong
            // 
            this.btn_tc1_32_Khoi_DangNhapThanhCong.Location = new System.Drawing.Point(33, 347);
            this.btn_tc1_32_Khoi_DangNhapThanhCong.Name = "btn_tc1_32_Khoi_DangNhapThanhCong";
            this.btn_tc1_32_Khoi_DangNhapThanhCong.Size = new System.Drawing.Size(383, 36);
            this.btn_tc1_32_Khoi_DangNhapThanhCong.TabIndex = 0;
            this.btn_tc1_32_Khoi_DangNhapThanhCong.Text = "tc1_DangNhapThanhCong";
            this.btn_tc1_32_Khoi_DangNhapThanhCong.UseVisualStyleBackColor = true;
            this.btn_tc1_32_Khoi_DangNhapThanhCong.Click += new System.EventHandler(this.btn_tc1_32_Khoi_DangNhapThanhCong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tc1_32_Khoi_DangNhapThanhCong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_32_Khoi_TruyCapTrangWeb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_tc1_32_Khoi_DangNhapThanhCong;
    }
}

