namespace QLTV_GUI
{
    partial class BaoCaoMuonTheoTheLoai
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
            this.bt_xacNhan = new System.Windows.Forms.Button();
            this.dgv_MuonTheoTheLoai = new System.Windows.Forms.DataGridView();
            this.tb_tongLuotMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_Thang = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuonTheoTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Tomato;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_thoat.Location = new System.Drawing.Point(518, 333);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 50);
            this.bt_thoat.TabIndex = 65;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xacNhan
            // 
            this.bt_xacNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xacNhan.Location = new System.Drawing.Point(382, 333);
            this.bt_xacNhan.Name = "bt_xacNhan";
            this.bt_xacNhan.Size = new System.Drawing.Size(110, 50);
            this.bt_xacNhan.TabIndex = 64;
            this.bt_xacNhan.Text = "XÁC NHẬN";
            this.bt_xacNhan.UseVisualStyleBackColor = false;
            this.bt_xacNhan.Click += new System.EventHandler(this.bt_xacNhan_Click);
            // 
            // dgv_MuonTheoTheLoai
            // 
            this.dgv_MuonTheoTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MuonTheoTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTheLoai,
            this.SoLuotMuon,
            this.TiLe});
            this.dgv_MuonTheoTheLoai.Location = new System.Drawing.Point(34, 85);
            this.dgv_MuonTheoTheLoai.Name = "dgv_MuonTheoTheLoai";
            this.dgv_MuonTheoTheLoai.Size = new System.Drawing.Size(594, 186);
            this.dgv_MuonTheoTheLoai.TabIndex = 63;
            // 
            // tb_tongLuotMuon
            // 
            this.tb_tongLuotMuon.Location = new System.Drawing.Point(518, 281);
            this.tb_tongLuotMuon.Name = "tb_tongLuotMuon";
            this.tb_tongLuotMuon.ReadOnly = true;
            this.tb_tongLuotMuon.Size = new System.Drawing.Size(110, 20);
            this.tb_tongLuotMuon.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tổng số lượt mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tháng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(105, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 31);
            this.label11.TabIndex = 60;
            this.label11.Text = "BÁO CÁO MƯỢN THEO THỂ LOẠI";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Stt";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.Width = 200;
            // 
            // SoLuotMuon
            // 
            this.SoLuotMuon.DataPropertyName = "SoLuotMuon";
            this.SoLuotMuon.HeaderText = "Số Lượt Mượn";
            this.SoLuotMuon.Name = "SoLuotMuon";
            // 
            // TiLe
            // 
            this.TiLe.DataPropertyName = "TiLe";
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.Name = "TiLe";
            this.TiLe.Width = 150;
            // 
            // dtp_Thang
            // 
            this.dtp_Thang.CustomFormat = "MM/yyyy";
            this.dtp_Thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Thang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_Thang.Location = new System.Drawing.Point(301, 50);
            this.dtp_Thang.Name = "dtp_Thang";
            this.dtp_Thang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_Thang.Size = new System.Drawing.Size(112, 20);
            this.dtp_Thang.TabIndex = 68;
            this.dtp_Thang.ValueChanged += new System.EventHandler(this.dtp_Thang_ValueChanged);
            // 
            // BaoCaoMuonTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dtp_Thang);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xacNhan);
            this.Controls.Add(this.dgv_MuonTheoTheLoai);
            this.Controls.Add(this.tb_tongLuotMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "BaoCaoMuonTheoTheLoai";
            this.Text = "Báo cáo mượn theo thể loại";
            this.Load += new System.EventHandler(this.dtp_Thang_ValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuonTheoTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xacNhan;
        private System.Windows.Forms.DataGridView dgv_MuonTheoTheLoai;
        private System.Windows.Forms.TextBox tb_tongLuotMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.DateTimePicker dtp_Thang;
    }
}