namespace QLTV_GUI
{
    partial class TraSach
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
            this.label6 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xacNhan = new System.Windows.Forms.Button();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_maDocGia = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tongNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tienNoKiNay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tienPhatKiNay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ngayTra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tenDocGia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mã độc giả:";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Tomato;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_thoat.Location = new System.Drawing.Point(548, 376);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 50);
            this.bt_thoat.TabIndex = 66;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            // 
            // bt_xacNhan
            // 
            this.bt_xacNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xacNhan.Location = new System.Drawing.Point(412, 376);
            this.bt_xacNhan.Name = "bt_xacNhan";
            this.bt_xacNhan.Size = new System.Drawing.Size(110, 50);
            this.bt_xacNhan.TabIndex = 65;
            this.bt_xacNhan.Text = "XÁC NHẬN";
            this.bt_xacNhan.UseVisualStyleBackColor = false;
            // 
            // TienPhat
            // 
            this.TienPhat.HeaderText = "Tiền Phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            this.TienPhat.Width = 200;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.HeaderText = "Số Ngày Mượn";
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Width = 150;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // cb_maDocGia
            // 
            this.cb_maDocGia.FormattingEnabled = true;
            this.cb_maDocGia.Location = new System.Drawing.Point(103, 75);
            this.cb_maDocGia.Name = "cb_maDocGia";
            this.cb_maDocGia.Size = new System.Drawing.Size(100, 21);
            this.cb_maDocGia.TabIndex = 68;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.NgayMuon,
            this.SoNgayMuon,
            this.TienPhat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 170);
            this.dataGridView1.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(233, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 31);
            this.label11.TabIndex = 63;
            this.label11.Text = "NHẬN TRẢ SÁCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tổng nợ:";
            // 
            // tb_tongNo
            // 
            this.tb_tongNo.Location = new System.Drawing.Point(321, 152);
            this.tb_tongNo.Name = "tb_tongNo";
            this.tb_tongNo.Size = new System.Drawing.Size(100, 20);
            this.tb_tongNo.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tiền nợ kì này:";
            // 
            // tb_tienNoKiNay
            // 
            this.tb_tienNoKiNay.Location = new System.Drawing.Point(321, 126);
            this.tb_tienNoKiNay.Name = "tb_tienNoKiNay";
            this.tb_tienNoKiNay.Size = new System.Drawing.Size(100, 20);
            this.tb_tienNoKiNay.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tiền phạt kỉ này:";
            // 
            // tb_tienPhatKiNay
            // 
            this.tb_tienPhatKiNay.Location = new System.Drawing.Point(103, 123);
            this.tb_tienPhatKiNay.Name = "tb_tienPhatKiNay";
            this.tb_tienPhatKiNay.Size = new System.Drawing.Size(100, 20);
            this.tb_tienPhatKiNay.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ngày trả:";
            // 
            // tb_ngayTra
            // 
            this.tb_ngayTra.Location = new System.Drawing.Point(548, 126);
            this.tb_ngayTra.Name = "tb_ngayTra";
            this.tb_ngayTra.Size = new System.Drawing.Size(124, 20);
            this.tb_ngayTra.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Độc giả:";
            // 
            // cb_tenDocGia
            // 
            this.cb_tenDocGia.FormattingEnabled = true;
            this.cb_tenDocGia.Location = new System.Drawing.Point(321, 76);
            this.cb_tenDocGia.Name = "cb_tenDocGia";
            this.cb_tenDocGia.Size = new System.Drawing.Size(201, 21);
            this.cb_tenDocGia.TabIndex = 69;
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.cb_tenDocGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xacNhan);
            this.Controls.Add(this.cb_maDocGia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tongNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tienNoKiNay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tienPhatKiNay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ngayTra);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 475);
            this.MinimumSize = new System.Drawing.Size(700, 475);
            this.Name = "TraSach";
            this.Text = "TraSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.ComboBox cb_maDocGia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tongNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tienNoKiNay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tienPhatKiNay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ngayTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tenDocGia;
    }
}