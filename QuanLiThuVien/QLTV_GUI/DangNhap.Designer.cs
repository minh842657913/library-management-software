namespace QLTV_GUI
{
    partial class DangNhap
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
            this.tb_taiKhoan = new System.Windows.Forms.TextBox();
            this.tb_matKhau = new System.Windows.Forms.TextBox();
            this.bt_dangNhap = new System.Windows.Forms.Button();
            this.pb_matKhau = new System.Windows.Forms.PictureBox();
            this.pb_taiKhoan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_matKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_taiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_taiKhoan
            // 
            this.tb_taiKhoan.BackColor = System.Drawing.Color.LightCyan;
            this.tb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_taiKhoan.Location = new System.Drawing.Point(169, 55);
            this.tb_taiKhoan.Name = "tb_taiKhoan";
            this.tb_taiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_taiKhoan.Size = new System.Drawing.Size(222, 22);
            this.tb_taiKhoan.TabIndex = 2;
            // 
            // tb_matKhau
            // 
            this.tb_matKhau.BackColor = System.Drawing.Color.LightCyan;
            this.tb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_matKhau.Location = new System.Drawing.Point(169, 116);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.Size = new System.Drawing.Size(222, 22);
            this.tb_matKhau.TabIndex = 4;
            // 
            // bt_dangNhap
            // 
            this.bt_dangNhap.AutoEllipsis = true;
            this.bt_dangNhap.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_dangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dangNhap.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.bt_dangNhap.FlatAppearance.BorderSize = 0;
            this.bt_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dangNhap.ForeColor = System.Drawing.SystemColors.Info;
            this.bt_dangNhap.Location = new System.Drawing.Point(169, 164);
            this.bt_dangNhap.Name = "bt_dangNhap";
            this.bt_dangNhap.Size = new System.Drawing.Size(153, 44);
            this.bt_dangNhap.TabIndex = 5;
            this.bt_dangNhap.Text = "ĐĂNG NHẬP";
            this.bt_dangNhap.UseVisualStyleBackColor = false;
            this.bt_dangNhap.Click += new System.EventHandler(this.bt_dangNhap_Click);
            // 
            // pb_matKhau
            // 
            this.pb_matKhau.BackgroundImage = global::QLTV_GUI.Properties.Resources.password;
            this.pb_matKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_matKhau.Location = new System.Drawing.Point(104, 107);
            this.pb_matKhau.Name = "pb_matKhau";
            this.pb_matKhau.Size = new System.Drawing.Size(40, 40);
            this.pb_matKhau.TabIndex = 7;
            this.pb_matKhau.TabStop = false;
            // 
            // pb_taiKhoan
            // 
            this.pb_taiKhoan.BackgroundImage = global::QLTV_GUI.Properties.Resources.Account;
            this.pb_taiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_taiKhoan.Location = new System.Drawing.Point(106, 46);
            this.pb_taiKhoan.Name = "pb_taiKhoan";
            this.pb_taiKhoan.Size = new System.Drawing.Size(40, 40);
            this.pb_taiKhoan.TabIndex = 6;
            this.pb_taiKhoan.TabStop = false;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.bt_dangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(474, 231);
            this.Controls.Add(this.pb_matKhau);
            this.Controls.Add(this.pb_taiKhoan);
            this.Controls.Add(this.bt_dangNhap);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.tb_taiKhoan);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 270);
            this.MinimumSize = new System.Drawing.Size(490, 270);
            this.Name = "DangNhap";
            this.ShowIcon = false;
            this.Text = "Đăng nhập";           
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_matKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_taiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_taiKhoan;
        private System.Windows.Forms.TextBox tb_matKhau;
        private System.Windows.Forms.Button bt_dangNhap;
        private System.Windows.Forms.PictureBox pb_taiKhoan;
        private System.Windows.Forms.PictureBox pb_matKhau;
    }
}