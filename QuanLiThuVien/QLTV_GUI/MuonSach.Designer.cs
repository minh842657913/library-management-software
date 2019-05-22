namespace QLTV_GUI
{
    partial class MuonSach
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.tb_soLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_nhapLieu = new System.Windows.Forms.Button();
            this.tb_maSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_tenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_xacNhan = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tb_ngayMuon = new System.Windows.Forms.TextBox();
            this.cb_tenDocGia = new System.Windows.Forms.ComboBox();
            this.cb_maDocGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Tomato;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_thoat.Location = new System.Drawing.Point(836, 399);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 50);
            this.bt_thoat.TabIndex = 80;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // tb_soLuong
            // 
            this.tb_soLuong.Location = new System.Drawing.Point(730, 149);
            this.tb_soLuong.Name = "tb_soLuong";
            this.tb_soLuong.Size = new System.Drawing.Size(68, 20);
            this.tb_soLuong.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Số lượng:";
            // 
            // bt_nhapLieu
            // 
            this.bt_nhapLieu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_nhapLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_nhapLieu.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_nhapLieu.Location = new System.Drawing.Point(836, 133);
            this.bt_nhapLieu.Name = "bt_nhapLieu";
            this.bt_nhapLieu.Size = new System.Drawing.Size(110, 50);
            this.bt_nhapLieu.TabIndex = 76;
            this.bt_nhapLieu.Text = "NHẬP";
            this.bt_nhapLieu.UseVisualStyleBackColor = false;
            // 
            // tb_maSach
            // 
            this.tb_maSach.Location = new System.Drawing.Point(169, 149);
            this.tb_maSach.Name = "tb_maSach";
            this.tb_maSach.Size = new System.Drawing.Size(110, 20);
            this.tb_maSach.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Mã sách:";
            // 
            // tb_tenSach
            // 
            this.tb_tenSach.Location = new System.Drawing.Point(346, 149);
            this.tb_tenSach.Name = "tb_tenSach";
            this.tb_tenSach.Size = new System.Drawing.Size(326, 20);
            this.tb_tenSach.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tên sách:";
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 200;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Width = 300;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 300;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // bt_xacNhan
            // 
            this.bt_xacNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xacNhan.Location = new System.Drawing.Point(688, 399);
            this.bt_xacNhan.Name = "bt_xacNhan";
            this.bt_xacNhan.Size = new System.Drawing.Size(110, 50);
            this.bt_xacNhan.TabIndex = 79;
            this.bt_xacNhan.Text = "XÁC NHẬN";
            this.bt_xacNhan.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia});
            this.dataGridView.Location = new System.Drawing.Point(12, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(988, 192);
            this.dataGridView.TabIndex = 71;
            // 
            // tb_ngayMuon
            // 
            this.tb_ngayMuon.Location = new System.Drawing.Point(518, 89);
            this.tb_ngayMuon.Name = "tb_ngayMuon";
            this.tb_ngayMuon.Size = new System.Drawing.Size(154, 20);
            this.tb_ngayMuon.TabIndex = 70;
            // 
            // cb_tenDocGia
            // 
            this.cb_tenDocGia.FormattingEnabled = true;
            this.cb_tenDocGia.Location = new System.Drawing.Point(518, 62);
            this.cb_tenDocGia.Name = "cb_tenDocGia";
            this.cb_tenDocGia.Size = new System.Drawing.Size(280, 21);
            this.cb_tenDocGia.TabIndex = 69;
            // 
            // cb_maDocGia
            // 
            this.cb_maDocGia.FormattingEnabled = true;
            this.cb_maDocGia.Location = new System.Drawing.Point(317, 62);
            this.cb_maDocGia.Name = "cb_maDocGia";
            this.cb_maDocGia.Size = new System.Drawing.Size(121, 21);
            this.cb_maDocGia.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tên độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mã độc giả:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(366, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 31);
            this.label11.TabIndex = 64;
            this.label11.Text = "THÔNG TIN MƯỢN SÁCH";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 461);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.tb_soLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_nhapLieu);
            this.Controls.Add(this.tb_maSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_tenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_xacNhan);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tb_ngayMuon);
            this.Controls.Add(this.cb_tenDocGia);
            this.Controls.Add(this.cb_maDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.MaximumSize = new System.Drawing.Size(1028, 500);
            this.MinimumSize = new System.Drawing.Size(1028, 500);
            this.Name = "MuonSach";
            this.Text = "MuonSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox tb_soLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_nhapLieu;
        private System.Windows.Forms.TextBox tb_maSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_tenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button bt_xacNhan;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tb_ngayMuon;
        private System.Windows.Forms.ComboBox cb_tenDocGia;
        private System.Windows.Forms.ComboBox cb_maDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}