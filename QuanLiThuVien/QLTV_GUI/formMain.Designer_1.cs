namespace QLTV_GUI
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.ts_heThong = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lapPhieuPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_quanLiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapSach = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatSach = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_quanLiDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.lapTheDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_quanLiMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.muonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.traSach = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lb_dangXuat = new System.Windows.Forms.LinkLabel();
            this.lb_tenTaiKhoan = new System.Windows.Forms.Label();
            this.pn_account = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_timKiem = new System.Windows.Forms.Button();
            this.tb_timKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pn_title = new System.Windows.Forms.Panel();
            this.dt_bangSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ts_lapTheDocGia = new System.Windows.Forms.ToolStripButton();
            this.ts_muonSach = new System.Windows.Forms.ToolStripButton();
            this.ts_traSach = new System.Windows.Forms.ToolStripButton();
            this.ts_nhapSach = new System.Windows.Forms.ToolStripButton();
            this.ts_lapPhieuPhat = new System.Windows.Forms.ToolStripButton();
            this.ts_baoCao = new System.Windows.Forms.ToolStripButton();
            this.menu_Main.SuspendLayout();
            this.ts_toolBar.SuspendLayout();
            this.pn_account.SuspendLayout();
            this.pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_bangSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_heThong,
            this.ts_quanLiSach,
            this.ts_quanLiDocGia,
            this.ts_quanLiMuonTra,
            this.gioiThieu});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(1008, 24);
            this.menu_Main.TabIndex = 53;
            this.menu_Main.Text = "Thanh thực đơn";
            // 
            // ts_heThong
            // 
            this.ts_heThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhap,
            this.dangXuat,
            this.toolStripSeparator,
            this.lapPhieuPhat,
            this.toolStripSeparator3,
            this.thoat});
            this.ts_heThong.Name = "ts_heThong";
            this.ts_heThong.Size = new System.Drawing.Size(69, 20);
            this.ts_heThong.Text = "Hệ thống";
            // 
            // dangNhap
            // 
            this.dangNhap.Name = "dangNhap";
            this.dangNhap.Size = new System.Drawing.Size(153, 22);
            this.dangNhap.Text = "Đăng nhập";
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(153, 22);
            this.dangXuat.Text = "Đăng xuất";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(150, 6);
            // 
            // lapPhieuPhat
            // 
            this.lapPhieuPhat.Name = "lapPhieuPhat";
            this.lapPhieuPhat.Size = new System.Drawing.Size(153, 22);
            this.lapPhieuPhat.Text = "Lập phiếu phạt";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(153, 22);
            this.thoat.Text = "Thoát";
            // 
            // ts_quanLiSach
            // 
            this.ts_quanLiSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapSach,
            this.capNhatSach,
            this.xoaSach});
            this.ts_quanLiSach.Name = "ts_quanLiSach";
            this.ts_quanLiSach.Size = new System.Drawing.Size(84, 20);
            this.ts_quanLiSach.Text = "Quản lí sách";
            // 
            // nhapSach
            // 
            this.nhapSach.Name = "nhapSach";
            this.nhapSach.Size = new System.Drawing.Size(198, 22);
            this.nhapSach.Text = "Nhập sách";
            // 
            // capNhatSach
            // 
            this.capNhatSach.Name = "capNhatSach";
            this.capNhatSach.Size = new System.Drawing.Size(198, 22);
            this.capNhatSach.Text = "Cập nhật sách";
            // 
            // xoaSach
            // 
            this.xoaSach.Name = "xoaSach";
            this.xoaSach.Size = new System.Drawing.Size(198, 22);
            this.xoaSach.Text = "Xóa sách khỏi hệ thống";
            // 
            // ts_quanLiDocGia
            // 
            this.ts_quanLiDocGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapTheDocGia,
            this.capNhatDocGia,
            this.xoaDocGia});
            this.ts_quanLiDocGia.Name = "ts_quanLiDocGia";
            this.ts_quanLiDocGia.Size = new System.Drawing.Size(99, 20);
            this.ts_quanLiDocGia.Text = "Quản lí độc giả";
            // 
            // lapTheDocGia
            // 
            this.lapTheDocGia.Name = "lapTheDocGia";
            this.lapTheDocGia.Size = new System.Drawing.Size(187, 22);
            this.lapTheDocGia.Text = "Lập thẻ độc giả";
            // 
            // capNhatDocGia
            // 
            this.capNhatDocGia.Name = "capNhatDocGia";
            this.capNhatDocGia.Size = new System.Drawing.Size(187, 22);
            this.capNhatDocGia.Text = "Sữa thông tin độc giả";
            // 
            // xoaDocGia
            // 
            this.xoaDocGia.Name = "xoaDocGia";
            this.xoaDocGia.Size = new System.Drawing.Size(187, 22);
            this.xoaDocGia.Text = "Xóa độc giả";
            // 
            // ts_quanLiMuonTra
            // 
            this.ts_quanLiMuonTra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muonSach,
            this.traSach});
            this.ts_quanLiMuonTra.Name = "ts_quanLiMuonTra";
            this.ts_quanLiMuonTra.Size = new System.Drawing.Size(109, 20);
            this.ts_quanLiMuonTra.Text = "Quản lí mượn trả";
            // 
            // muonSach
            // 
            this.muonSach.Name = "muonSach";
            this.muonSach.Size = new System.Drawing.Size(158, 22);
            this.muonSach.Text = "Cho mượn sách";
            // 
            // traSach
            // 
            this.traSach.Name = "traSach";
            this.traSach.Size = new System.Drawing.Size(158, 22);
            this.traSach.Text = "Nhận trả sách";
            // 
            // gioiThieu
            // 
            this.gioiThieu.Name = "gioiThieu";
            this.gioiThieu.Size = new System.Drawing.Size(70, 20);
            this.gioiThieu.Text = "Giới thiệu";
            // 
            // ts_toolBar
            // 
            this.ts_toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lapTheDocGia,
            this.toolStripSeparator1,
            this.ts_muonSach,
            this.ts_traSach,
            this.ts_nhapSach,
            this.toolStripSeparator2,
            this.ts_lapPhieuPhat,
            this.ts_baoCao});
            this.ts_toolBar.Location = new System.Drawing.Point(0, 24);
            this.ts_toolBar.Name = "ts_toolBar";
            this.ts_toolBar.Size = new System.Drawing.Size(1008, 39);
            this.ts_toolBar.TabIndex = 54;
            this.ts_toolBar.Text = "Thanh công cụ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // lb_dangXuat
            // 
            this.lb_dangXuat.ActiveLinkColor = System.Drawing.Color.DarkCyan;
            this.lb_dangXuat.DisabledLinkColor = System.Drawing.Color.DarkTurquoise;
            this.lb_dangXuat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lb_dangXuat.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.lb_dangXuat.Location = new System.Drawing.Point(61, 32);
            this.lb_dangXuat.Name = "lb_dangXuat";
            this.lb_dangXuat.Size = new System.Drawing.Size(56, 13);
            this.lb_dangXuat.TabIndex = 57;
            this.lb_dangXuat.TabStop = true;
            this.lb_dangXuat.Text = "Đăng xuất";
            this.lb_dangXuat.VisitedLinkColor = System.Drawing.Color.DarkTurquoise;
            // 
            // lb_tenTaiKhoan
            // 
            this.lb_tenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenTaiKhoan.Location = new System.Drawing.Point(37, 5);
            this.lb_tenTaiKhoan.Name = "lb_tenTaiKhoan";
            this.lb_tenTaiKhoan.Size = new System.Drawing.Size(89, 17);
            this.lb_tenTaiKhoan.TabIndex = 56;
            this.lb_tenTaiKhoan.Text = "Quản trị viên";
            // 
            // pn_account
            // 
            this.pn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_account.AutoScroll = true;
            this.pn_account.Controls.Add(this.pictureBox1);
            this.pn_account.Controls.Add(this.lb_tenTaiKhoan);
            this.pn_account.Controls.Add(this.lb_dangXuat);
            this.pn_account.Location = new System.Drawing.Point(822, 66);
            this.pn_account.MaximumSize = new System.Drawing.Size(170, 55);
            this.pn_account.MinimumSize = new System.Drawing.Size(170, 55);
            this.pn_account.Name = "pn_account";
            this.pn_account.Size = new System.Drawing.Size(170, 55);
            this.pn_account.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "(Nhập tên sách hoặc mã sách)";
            // 
            // bt_timKiem
            // 
            this.bt_timKiem.Location = new System.Drawing.Point(315, 32);
            this.bt_timKiem.Name = "bt_timKiem";
            this.bt_timKiem.Size = new System.Drawing.Size(75, 23);
            this.bt_timKiem.TabIndex = 61;
            this.bt_timKiem.Text = "Tìm kiếm";
            this.bt_timKiem.UseVisualStyleBackColor = true;
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.Location = new System.Drawing.Point(7, 34);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Size = new System.Drawing.Size(300, 20);
            this.tb_timKiem.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(58, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 31);
            this.label11.TabIndex = 59;
            this.label11.Text = "QUẢN LÍ THƯ VIỆN";
            // 
            // pn_title
            // 
            this.pn_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_title.Controls.Add(this.label11);
            this.pn_title.Controls.Add(this.label2);
            this.pn_title.Controls.Add(this.tb_timKiem);
            this.pn_title.Controls.Add(this.bt_timKiem);
            this.pn_title.Location = new System.Drawing.Point(327, 69);
            this.pn_title.MaximumSize = new System.Drawing.Size(390, 75);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(390, 75);
            this.pn_title.TabIndex = 63;
            // 
            // dt_bangSach
            // 
            this.dt_bangSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_bangSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_bangSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_bangSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.NamXuatBan,
            this.NhaXuatBan,
            this.NgayNhap,
            this.SoLuongTon,
            this.TriGia});
            this.dt_bangSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dt_bangSach.Location = new System.Drawing.Point(11, 150);
            this.dt_bangSach.Margin = new System.Windows.Forms.Padding(2);
            this.dt_bangSach.Name = "dt_bangSach";
            this.dt_bangSach.RowHeadersVisible = false;
            this.dt_bangSach.Size = new System.Drawing.Size(986, 349);
            this.dt_bangSach.TabIndex = 64;
            // 
            // STT
            // 
            this.STT.FillWeight = 5.962163F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaSach
            // 
            this.MaSach.FillWeight = 1.94764F;
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 75;
            // 
            // TenSach
            // 
            this.TenSach.FillWeight = 68.75516F;
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 200;
            // 
            // TheLoai
            // 
            this.TheLoai.FillWeight = 281.9706F;
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Width = 150;
            // 
            // TacGia
            // 
            this.TacGia.FillWeight = 379.7668F;
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.FillWeight = 253.8071F;
            this.NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Width = 50;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.FillWeight = 1.94764F;
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // NgayNhap
            // 
            this.NgayNhap.FillWeight = 1.94764F;
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.FillWeight = 1.94764F;
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Width = 50;
            // 
            // TriGia
            // 
            this.TriGia.FillWeight = 1.94764F;
            this.TriGia.HeaderText = "Trị Giá";
            this.TriGia.Name = "TriGia";
            this.TriGia.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLTV_GUI.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(125, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // ts_lapTheDocGia
            // 
            this.ts_lapTheDocGia.Image = global::QLTV_GUI.Properties.Resources.card;
            this.ts_lapTheDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lapTheDocGia.Name = "ts_lapTheDocGia";
            this.ts_lapTheDocGia.Size = new System.Drawing.Size(128, 36);
            this.ts_lapTheDocGia.Text = "Lập thẻ thư viện";
            // 
            // ts_muonSach
            // 
            this.ts_muonSach.Image = global::QLTV_GUI.Properties.Resources.book;
            this.ts_muonSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_muonSach.Name = "ts_muonSach";
            this.ts_muonSach.Size = new System.Drawing.Size(102, 36);
            this.ts_muonSach.Text = "Mượn sách";
            // 
            // ts_traSach
            // 
            this.ts_traSach.Image = global::QLTV_GUI.Properties.Resources.book;
            this.ts_traSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_traSach.Name = "ts_traSach";
            this.ts_traSach.Size = new System.Drawing.Size(86, 36);
            this.ts_traSach.Text = "Trả sách";
            // 
            // ts_nhapSach
            // 
            this.ts_nhapSach.Image = global::QLTV_GUI.Properties.Resources.TiepNhanSach;
            this.ts_nhapSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_nhapSach.Name = "ts_nhapSach";
            this.ts_nhapSach.Size = new System.Drawing.Size(147, 36);
            this.ts_nhapSach.Text = "Tiếp nhận sách mới";
            // 
            // ts_lapPhieuPhat
            // 
            this.ts_lapPhieuPhat.Image = global::QLTV_GUI.Properties.Resources.punish;
            this.ts_lapPhieuPhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lapPhieuPhat.Name = "ts_lapPhieuPhat";
            this.ts_lapPhieuPhat.Size = new System.Drawing.Size(122, 36);
            this.ts_lapPhieuPhat.Text = "Lập phiếu phạt";
            // 
            // ts_baoCao
            // 
            this.ts_baoCao.Image = global::QLTV_GUI.Properties.Resources.report;
            this.ts_baoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_baoCao.Name = "ts_baoCao";
            this.ts_baoCao.Size = new System.Drawing.Size(85, 36);
            this.ts_baoCao.Text = "Báo cáo";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.dt_bangSach);
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.pn_account);
            this.Controls.Add(this.ts_toolBar);
            this.Controls.Add(this.menu_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "formMain";
            this.Text = "Quản lí thư viện";
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            this.ts_toolBar.ResumeLayout(false);
            this.ts_toolBar.PerformLayout();
            this.pn_account.ResumeLayout(false);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_bangSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem ts_heThong;
        private System.Windows.Forms.ToolStripMenuItem dangNhap;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem lapPhieuPhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.ToolStripMenuItem ts_quanLiSach;
        private System.Windows.Forms.ToolStripMenuItem nhapSach;
        private System.Windows.Forms.ToolStripMenuItem capNhatSach;
        private System.Windows.Forms.ToolStripMenuItem xoaSach;
        private System.Windows.Forms.ToolStripMenuItem ts_quanLiDocGia;
        private System.Windows.Forms.ToolStripMenuItem lapTheDocGia;
        private System.Windows.Forms.ToolStripMenuItem capNhatDocGia;
        private System.Windows.Forms.ToolStripMenuItem xoaDocGia;
        private System.Windows.Forms.ToolStripMenuItem ts_quanLiMuonTra;
        private System.Windows.Forms.ToolStripMenuItem muonSach;
        private System.Windows.Forms.ToolStripMenuItem traSach;
        private System.Windows.Forms.ToolStripMenuItem gioiThieu;
        private System.Windows.Forms.ToolStrip ts_toolBar;
        private System.Windows.Forms.ToolStripButton ts_lapTheDocGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_muonSach;
        private System.Windows.Forms.ToolStripButton ts_traSach;
        private System.Windows.Forms.ToolStripButton ts_nhapSach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_lapPhieuPhat;
        private System.Windows.Forms.ToolStripButton ts_baoCao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lb_dangXuat;
        private System.Windows.Forms.Label lb_tenTaiKhoan;
        private System.Windows.Forms.Panel pn_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_timKiem;
        private System.Windows.Forms.TextBox tb_timKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.DataGridView dt_bangSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
    }
}

