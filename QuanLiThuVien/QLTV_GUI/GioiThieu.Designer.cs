namespace QLTV_GUI
{
    partial class GioiThieu
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
            this.lb_phienBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_thoat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lithograph", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lí thư viện";
            // 
            // lb_phienBan
            // 
            this.lb_phienBan.AutoSize = true;
            this.lb_phienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_phienBan.Location = new System.Drawing.Point(71, 104);
            this.lb_phienBan.Name = "lb_phienBan";
            this.lb_phienBan.Size = new System.Drawing.Size(96, 15);
            this.lb_phienBan.TabIndex = 1;
            this.lb_phienBan.Text = "Phiên bản: 0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(71, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Được thực hiện như sản phẩm môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập môn Công nghệ Phần mềm";
            // 
            // lb_thoat
            // 
            this.lb_thoat.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.lb_thoat.DisabledLinkColor = System.Drawing.Color.DarkTurquoise;
            this.lb_thoat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lb_thoat.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.lb_thoat.Location = new System.Drawing.Point(176, 220);
            this.lb_thoat.Name = "lb_thoat";
            this.lb_thoat.Size = new System.Drawing.Size(37, 13);
            this.lb_thoat.TabIndex = 58;
            this.lb_thoat.TabStop = true;
            this.lb_thoat.Text = "Thoát";
            this.lb_thoat.VisitedLinkColor = System.Drawing.Color.DarkTurquoise;
            // 
            // GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.lb_thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_phienBan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GioiThieu";
            this.Text = "GioiThieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_phienBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lb_thoat;
    }
}