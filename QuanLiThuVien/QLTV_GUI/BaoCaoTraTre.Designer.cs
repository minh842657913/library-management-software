namespace QLTV_GUI
{
    partial class BaoCaoTraTre
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
            this.dgv_TraTre = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xacNhan = new System.Windows.Forms.Button();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayTraTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TraTre
            // 
            this.dgv_TraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraTre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayTraTre});
            this.dgv_TraTre.Location = new System.Drawing.Point(45, 102);
            this.dgv_TraTre.Name = "dgv_TraTre";
            this.dgv_TraTre.Size = new System.Drawing.Size(594, 186);
            this.dgv_TraTre.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ngày:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(185, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 31);
            this.label11.TabIndex = 52;
            this.label11.Text = "BÁO CÁO TRẢ SÁCH TRỄ";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Tomato;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_thoat.Location = new System.Drawing.Point(530, 301);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 50);
            this.bt_thoat.TabIndex = 57;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xacNhan
            // 
            this.bt_xacNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_xacNhan.Location = new System.Drawing.Point(394, 301);
            this.bt_xacNhan.Name = "bt_xacNhan";
            this.bt_xacNhan.Size = new System.Drawing.Size(110, 50);
            this.bt_xacNhan.TabIndex = 56;
            this.bt_xacNhan.Text = "XÁC NHẬN";
            this.bt_xacNhan.UseVisualStyleBackColor = false;
            this.bt_xacNhan.Click += new System.EventHandler(this.bt_xacNhan_Click);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Ngay.Location = new System.Drawing.Point(309, 66);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_Ngay.Size = new System.Drawing.Size(111, 20);
            this.dtp_Ngay.TabIndex = 58;
            this.dtp_Ngay.ValueChanged += new System.EventHandler(this.dtp_Ngay_ValueChanged);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Stt";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 200;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // SoNgayTraTre
            // 
            this.SoNgayTraTre.DataPropertyName = "SoNgayTraTre";
            this.SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ";
            this.SoNgayTraTre.Name = "SoNgayTraTre";
            this.SoNgayTraTre.Width = 150;
            // 
            // BaoCaoTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dtp_Ngay);
            this.Controls.Add(this.dgv_TraTre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xacNhan);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "BaoCaoTraTre";
            this.Text = "Báo cáo trả trễ";
            this.Load += new System.EventHandler(this.dtp_Ngay_ValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TraTre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xacNhan;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayTraTre;
    }
}