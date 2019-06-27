namespace QLTV_GUI
{
    partial class GiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienChinh));
            this.ms_thanhMenu = new System.Windows.Forms.MenuStrip();
            this.ms_heThong = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_dangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ms_lapPhieuPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_lapBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_baoCaoTraTre = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_baoCaoMuonTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_quanLiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_nhapSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_capNhatSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_xoaSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_quanLiDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_lapTheDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_capNhatDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_xoaDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_quanLiMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_muonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_traSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_gioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_thanhCongCu = new System.Windows.Forms.ToolStrip();
            this.ts_lapTheDocGia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_muonSach = new System.Windows.Forms.ToolStripButton();
            this.ts_traSach = new System.Windows.Forms.ToolStripButton();
            this.ts_nhapSach = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lapPhieuPhat = new System.Windows.Forms.ToolStripButton();
            this.ts_baoCao = new System.Windows.Forms.ToolStripSplitButton();
            this.ts_baoCaoTraTre = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_baoCaoMuonTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_dangXuat = new System.Windows.Forms.LinkLabel();
            this.lb_tenTaiKhoan = new System.Windows.Forms.Label();
            this.pn_account = new System.Windows.Forms.Panel();
            this.picbox_anhDaiDien = new System.Windows.Forms.PictureBox();
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
            this.ms_thanhMenu.SuspendLayout();
            this.ts_thanhCongCu.SuspendLayout();
            this.pn_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhDaiDien)).BeginInit();
            this.pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_bangSach)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_thanhMenu
            // 
            this.ms_thanhMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_heThong,
            this.ts_quanLiSach,
            this.ms_quanLiDocGia,
            this.ms_quanLiMuonTra,
            this.ms_gioiThieu});
            this.ms_thanhMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_thanhMenu.Name = "ms_thanhMenu";
            this.ms_thanhMenu.Size = new System.Drawing.Size(1008, 24);
            this.ms_thanhMenu.TabIndex = 53;
            this.ms_thanhMenu.Text = "Thanh thực đơn";
            // 
            // ms_heThong
            // 
            this.ms_heThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_dangNhap,
            this.ms_dangXuat,
            this.toolStripSeparator,
            this.ms_lapPhieuPhat,
            this.ms_lapBaoCao,
            this.toolStripSeparator3,
            this.ms_thoat});
            this.ms_heThong.Name = "ms_heThong";
            this.ms_heThong.Size = new System.Drawing.Size(69, 20);
            this.ms_heThong.Text = "Hệ thống";
            // 
            // ms_dangNhap
            // 
            this.ms_dangNhap.Name = "ms_dangNhap";
            this.ms_dangNhap.Size = new System.Drawing.Size(153, 22);
            this.ms_dangNhap.Text = "Đăng nhập";
            this.ms_dangNhap.Click += new System.EventHandler(this.ms_dangNhap_Click);
            // 
            // ms_dangXuat
            // 
            this.ms_dangXuat.Name = "ms_dangXuat";
            this.ms_dangXuat.Size = new System.Drawing.Size(153, 22);
            this.ms_dangXuat.Text = "Đăng xuất";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(150, 6);
            // 
            // ms_lapPhieuPhat
            // 
            this.ms_lapPhieuPhat.Name = "ms_lapPhieuPhat";
            this.ms_lapPhieuPhat.Size = new System.Drawing.Size(153, 22);
            this.ms_lapPhieuPhat.Text = "Lập phiếu phạt";
            this.ms_lapPhieuPhat.Click += new System.EventHandler(this.ms_lapPhieuPhat_Click);
            // 
            // ms_lapBaoCao
            // 
            this.ms_lapBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_baoCaoTraTre,
            this.ms_baoCaoMuonTheLoai});
            this.ms_lapBaoCao.Name = "ms_lapBaoCao";
            this.ms_lapBaoCao.Size = new System.Drawing.Size(153, 22);
            this.ms_lapBaoCao.Text = "Lập báo cáo";
            // 
            // ms_baoCaoTraTre
            // 
            this.ms_baoCaoTraTre.Name = "ms_baoCaoTraTre";
            this.ms_baoCaoTraTre.Size = new System.Drawing.Size(220, 22);
            this.ms_baoCaoTraTre.Text = "Báo cáo trả trễ ";
            this.ms_baoCaoTraTre.Click += new System.EventHandler(this.ms_baoCaoTraTre_Click);
            // 
            // ms_baoCaoMuonTheLoai
            // 
            this.ms_baoCaoMuonTheLoai.Name = "ms_baoCaoMuonTheLoai";
            this.ms_baoCaoMuonTheLoai.Size = new System.Drawing.Size(220, 22);
            this.ms_baoCaoMuonTheLoai.Text = "Báo cáo mượn theo thể loại";
            this.ms_baoCaoMuonTheLoai.Click += new System.EventHandler(this.ms_baoCaoMuonTheLoai_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // ms_thoat
            // 
            this.ms_thoat.Name = "ms_thoat";
            this.ms_thoat.Size = new System.Drawing.Size(153, 22);
            this.ms_thoat.Text = "Thoát";
            this.ms_thoat.Click += new System.EventHandler(this.ms_thoat_Click);
            // 
            // ts_quanLiSach
            // 
            this.ts_quanLiSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_nhapSach,
            this.ms_capNhatSach,
            this.ms_xoaSach});
            this.ts_quanLiSach.Name = "ts_quanLiSach";
            this.ts_quanLiSach.Size = new System.Drawing.Size(84, 20);
            this.ts_quanLiSach.Text = "Quản lí sách";
            // 
            // ms_nhapSach
            // 
            this.ms_nhapSach.Name = "ms_nhapSach";
            this.ms_nhapSach.Size = new System.Drawing.Size(198, 22);
            this.ms_nhapSach.Text = "Nhập sách";
            this.ms_nhapSach.Click += new System.EventHandler(this.ms_nhapSach_Click);
            // 
            // ms_capNhatSach
            // 
            this.ms_capNhatSach.Name = "ms_capNhatSach";
            this.ms_capNhatSach.Size = new System.Drawing.Size(198, 22);
            this.ms_capNhatSach.Text = "Cập nhật sách";
            this.ms_capNhatSach.Click += new System.EventHandler(this.ms_capNhatSach_Click);
            // 
            // ms_xoaSach
            // 
            this.ms_xoaSach.Name = "ms_xoaSach";
            this.ms_xoaSach.Size = new System.Drawing.Size(198, 22);
            this.ms_xoaSach.Text = "Xóa sách khỏi hệ thống";
            this.ms_xoaSach.Click += new System.EventHandler(this.ms_xoaSach_Click);
            // 
            // ms_quanLiDocGia
            // 
            this.ms_quanLiDocGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_lapTheDocGia,
            this.ms_capNhatDocGia,
            this.ms_xoaDocGia});
            this.ms_quanLiDocGia.Name = "ms_quanLiDocGia";
            this.ms_quanLiDocGia.Size = new System.Drawing.Size(99, 20);
            this.ms_quanLiDocGia.Text = "Quản lí độc giả";
            // 
            // ms_lapTheDocGia
            // 
            this.ms_lapTheDocGia.Name = "ms_lapTheDocGia";
            this.ms_lapTheDocGia.Size = new System.Drawing.Size(187, 22);
            this.ms_lapTheDocGia.Text = "Lập thẻ độc giả";
            this.ms_lapTheDocGia.Click += new System.EventHandler(this.ms_lapTheDocGia_Click);
            // 
            // ms_capNhatDocGia
            // 
            this.ms_capNhatDocGia.Name = "ms_capNhatDocGia";
            this.ms_capNhatDocGia.Size = new System.Drawing.Size(187, 22);
            this.ms_capNhatDocGia.Text = "Sữa thông tin độc giả";
            this.ms_capNhatDocGia.Click += new System.EventHandler(this.ms_capNhatDocGia_Click);
            // 
            // ms_xoaDocGia
            // 
            this.ms_xoaDocGia.Name = "ms_xoaDocGia";
            this.ms_xoaDocGia.Size = new System.Drawing.Size(187, 22);
            this.ms_xoaDocGia.Text = "Xóa độc giả";
            this.ms_xoaDocGia.Click += new System.EventHandler(this.ms_xoaDocGia_Click);
            // 
            // ms_quanLiMuonTra
            // 
            this.ms_quanLiMuonTra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_muonSach,
            this.ms_traSach});
            this.ms_quanLiMuonTra.Name = "ms_quanLiMuonTra";
            this.ms_quanLiMuonTra.Size = new System.Drawing.Size(109, 20);
            this.ms_quanLiMuonTra.Text = "Quản lí mượn trả";
            // 
            // ms_muonSach
            // 
            this.ms_muonSach.Name = "ms_muonSach";
            this.ms_muonSach.Size = new System.Drawing.Size(158, 22);
            this.ms_muonSach.Text = "Cho mượn sách";
            this.ms_muonSach.Click += new System.EventHandler(this.ms_muonSach_Click);
            // 
            // ms_traSach
            // 
            this.ms_traSach.Name = "ms_traSach";
            this.ms_traSach.Size = new System.Drawing.Size(158, 22);
            this.ms_traSach.Text = "Nhận trả sách";
            this.ms_traSach.Click += new System.EventHandler(this.ms_traSach_Click);
            // 
            // ms_gioiThieu
            // 
            this.ms_gioiThieu.Name = "ms_gioiThieu";
            this.ms_gioiThieu.Size = new System.Drawing.Size(70, 20);
            this.ms_gioiThieu.Text = "Giới thiệu";
            this.ms_gioiThieu.Click += new System.EventHandler(this.ms_gioiThieu_Click);
            // 
            // ts_thanhCongCu
            // 
            this.ts_thanhCongCu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_thanhCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_lapTheDocGia,
            this.toolStripSeparator1,
            this.ts_muonSach,
            this.ts_traSach,
            this.ts_nhapSach,
            this.toolStripSeparator2,
            this.ts_lapPhieuPhat,
            this.ts_baoCao});
            this.ts_thanhCongCu.Location = new System.Drawing.Point(0, 24);
            this.ts_thanhCongCu.Name = "ts_thanhCongCu";
            this.ts_thanhCongCu.Size = new System.Drawing.Size(1008, 39);
            this.ts_thanhCongCu.TabIndex = 54;
            this.ts_thanhCongCu.Text = "Thanh công cụ";
            // 
            // ts_lapTheDocGia
            // 
            this.ts_lapTheDocGia.Image = global::QLTV_GUI.Properties.Resources.card;
            this.ts_lapTheDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lapTheDocGia.Name = "ts_lapTheDocGia";
            this.ts_lapTheDocGia.Size = new System.Drawing.Size(128, 36);
            this.ts_lapTheDocGia.Text = "Lập thẻ thư viện";
            this.ts_lapTheDocGia.Click += new System.EventHandler(this.ms_lapTheDocGia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ts_muonSach
            // 
            this.ts_muonSach.Image = global::QLTV_GUI.Properties.Resources.book;
            this.ts_muonSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_muonSach.Name = "ts_muonSach";
            this.ts_muonSach.Size = new System.Drawing.Size(102, 36);
            this.ts_muonSach.Text = "Mượn sách";
            this.ts_muonSach.Click += new System.EventHandler(this.ms_muonSach_Click);
            // 
            // ts_traSach
            // 
            this.ts_traSach.Image = global::QLTV_GUI.Properties.Resources.book;
            this.ts_traSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_traSach.Name = "ts_traSach";
            this.ts_traSach.Size = new System.Drawing.Size(86, 36);
            this.ts_traSach.Text = "Trả sách";
            this.ts_traSach.Click += new System.EventHandler(this.ms_traSach_Click);
            // 
            // ts_nhapSach
            // 
            this.ts_nhapSach.Image = global::QLTV_GUI.Properties.Resources.TiepNhanSach;
            this.ts_nhapSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_nhapSach.Name = "ts_nhapSach";
            this.ts_nhapSach.Size = new System.Drawing.Size(147, 36);
            this.ts_nhapSach.Text = "Tiếp nhận sách mới";
            this.ts_nhapSach.Click += new System.EventHandler(this.ms_nhapSach_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ts_lapPhieuPhat
            // 
            this.ts_lapPhieuPhat.Image = global::QLTV_GUI.Properties.Resources.punish;
            this.ts_lapPhieuPhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lapPhieuPhat.Name = "ts_lapPhieuPhat";
            this.ts_lapPhieuPhat.Size = new System.Drawing.Size(122, 36);
            this.ts_lapPhieuPhat.Text = "Lập phiếu phạt";
            this.ts_lapPhieuPhat.Click += new System.EventHandler(this.ms_lapPhieuPhat_Click);
            // 
            // ts_baoCao
            // 
            this.ts_baoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_baoCaoTraTre,
            this.ts_baoCaoMuonTheLoai});
            this.ts_baoCao.Image = global::QLTV_GUI.Properties.Resources.report;
            this.ts_baoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_baoCao.Name = "ts_baoCao";
            this.ts_baoCao.Size = new System.Drawing.Size(97, 36);
            this.ts_baoCao.Text = "Báo cáo";
            // 
            // ts_baoCaoTraTre
            // 
            this.ts_baoCaoTraTre.Name = "ts_baoCaoTraTre";
            this.ts_baoCaoTraTre.Size = new System.Drawing.Size(220, 22);
            this.ts_baoCaoTraTre.Text = "Báo cáo trả trễ";
            this.ts_baoCaoTraTre.Click += new System.EventHandler(this.ms_baoCaoTraTre_Click);
            // 
            // ts_baoCaoMuonTheLoai
            // 
            this.ts_baoCaoMuonTheLoai.Name = "ts_baoCaoMuonTheLoai";
            this.ts_baoCaoMuonTheLoai.Size = new System.Drawing.Size(220, 22);
            this.ts_baoCaoMuonTheLoai.Text = "Báo cáo mượn theo thể loại";
            this.ts_baoCaoMuonTheLoai.Click += new System.EventHandler(this.ms_baoCaoMuonTheLoai_Click);
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
            this.pn_account.Controls.Add(this.picbox_anhDaiDien);
            this.pn_account.Controls.Add(this.lb_tenTaiKhoan);
            this.pn_account.Controls.Add(this.lb_dangXuat);
            this.pn_account.Location = new System.Drawing.Point(822, 66);
            this.pn_account.MaximumSize = new System.Drawing.Size(170, 55);
            this.pn_account.MinimumSize = new System.Drawing.Size(170, 55);
            this.pn_account.Name = "pn_account";
            this.pn_account.Size = new System.Drawing.Size(170, 55);
            this.pn_account.TabIndex = 58;
            // 
            // picbox_anhDaiDien
            // 
            this.picbox_anhDaiDien.BackgroundImage = global::QLTV_GUI.Properties.Resources.user;
            this.picbox_anhDaiDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_anhDaiDien.ErrorImage = null;
            this.picbox_anhDaiDien.InitialImage = null;
            this.picbox_anhDaiDien.Location = new System.Drawing.Point(125, 5);
            this.picbox_anhDaiDien.Margin = new System.Windows.Forms.Padding(5);
            this.picbox_anhDaiDien.MaximumSize = new System.Drawing.Size(40, 40);
            this.picbox_anhDaiDien.Name = "picbox_anhDaiDien";
            this.picbox_anhDaiDien.Size = new System.Drawing.Size(40, 40);
            this.picbox_anhDaiDien.TabIndex = 55;
            this.picbox_anhDaiDien.TabStop = false;
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
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.dt_bangSach);
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.pn_account);
            this.Controls.Add(this.ts_thanhCongCu);
            this.Controls.Add(this.ms_thanhMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "GiaoDienChinh";
            this.Text = "Quản lí thư viện";
            this.ms_thanhMenu.ResumeLayout(false);
            this.ms_thanhMenu.PerformLayout();
            this.ts_thanhCongCu.ResumeLayout(false);
            this.ts_thanhCongCu.PerformLayout();
            this.pn_account.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_anhDaiDien)).EndInit();
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_bangSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_thanhMenu;
        private System.Windows.Forms.ToolStripMenuItem ms_heThong;
        private System.Windows.Forms.ToolStripMenuItem ms_dangNhap;
        private System.Windows.Forms.ToolStripMenuItem ms_dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ms_lapPhieuPhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ms_thoat;
        private System.Windows.Forms.ToolStripMenuItem ts_quanLiSach;
        private System.Windows.Forms.ToolStripMenuItem ms_nhapSach;
        private System.Windows.Forms.ToolStripMenuItem ms_capNhatSach;
        private System.Windows.Forms.ToolStripMenuItem ms_xoaSach;
        private System.Windows.Forms.ToolStripMenuItem ms_quanLiDocGia;
        private System.Windows.Forms.ToolStripMenuItem ms_lapTheDocGia;
        private System.Windows.Forms.ToolStripMenuItem ms_capNhatDocGia;
        private System.Windows.Forms.ToolStripMenuItem ms_xoaDocGia;
        private System.Windows.Forms.ToolStripMenuItem ms_quanLiMuonTra;
        private System.Windows.Forms.ToolStripMenuItem ms_muonSach;
        private System.Windows.Forms.ToolStripMenuItem ms_traSach;
        private System.Windows.Forms.ToolStripMenuItem ms_gioiThieu;
        private System.Windows.Forms.ToolStrip ts_thanhCongCu;
        private System.Windows.Forms.ToolStripButton ts_lapTheDocGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_muonSach;
        private System.Windows.Forms.ToolStripButton ts_traSach;
        private System.Windows.Forms.ToolStripButton ts_nhapSach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_lapPhieuPhat;
        private System.Windows.Forms.PictureBox picbox_anhDaiDien;
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
        private System.Windows.Forms.ToolStripMenuItem ms_lapBaoCao;
        private System.Windows.Forms.ToolStripMenuItem ms_baoCaoTraTre;
        private System.Windows.Forms.ToolStripMenuItem ms_baoCaoMuonTheLoai;
        private System.Windows.Forms.ToolStripSplitButton ts_baoCao;
        private System.Windows.Forms.ToolStripMenuItem ts_baoCaoTraTre;
        private System.Windows.Forms.ToolStripMenuItem ts_baoCaoMuonTheLoai;
    }
}

