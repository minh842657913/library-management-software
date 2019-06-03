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
            this.lb_taiKhoan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_matKhau = new System.Windows.Forms.TextBox();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.AutoSize = true;
            this.lb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lb_taiKhoan.Location = new System.Drawing.Point(66, 61);
            this.lb_taiKhoan.Name = "lb_taiKhoan";
            this.lb_taiKhoan.Size = new System.Drawing.Size(90, 22);
            this.lb_taiKhoan.TabIndex = 1;
            this.lb_taiKhoan.Text = "Tài khoản";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(172, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 2;
            // 
            // tb_matKhau
            // 
            this.tb_matKhau.BackColor = System.Drawing.Color.LightCyan;
            this.tb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_matKhau.Location = new System.Drawing.Point(172, 112);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.PasswordChar = '*';
            this.tb_matKhau.Size = new System.Drawing.Size(222, 22);
            this.tb_matKhau.TabIndex = 4;
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matKhau.ForeColor = System.Drawing.Color.Black;
            this.lb_matKhau.Location = new System.Drawing.Point(66, 110);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(83, 22);
            this.lb_matKhau.TabIndex = 3;
            this.lb_matKhau.Text = "Mật khẩu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(172, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(474, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.lb_matKhau);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_taiKhoan);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 270);
            this.MinimumSize = new System.Drawing.Size(490, 270);
            this.Name = "DangNhap";
            this.ShowIcon = false;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_taiKhoan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_matKhau;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.Button button1;
    }
}