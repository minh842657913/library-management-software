using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_GUI
{

    /*
    Program: Quản lí thư viện
    Written by: Nguyễn Song Luân
    Description: Giao diện chính của chương trỉnh đảm nhiệm việc kết nối người dùng với các chức năng
    */

    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void ms_dangNhap_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }

        private void ms_lapPhieuPhat_Click(object sender, EventArgs e)
        {
            PhieuThuTienPhat formLapPhieuPhat = new PhieuThuTienPhat();
            formLapPhieuPhat.Show();
        }

        private void ms_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ms_nhapSach_Click(object sender, EventArgs e)
        {
            NhapSachMoi formNhapSach = new NhapSachMoi();
            formNhapSach.Show();
        }

        private void ms_capNhatSach_Click(object sender, EventArgs e)
        {
            CapNhatSach formCapNhatSach = new CapNhatSach();
            formCapNhatSach.Show();
        }

        private void ms_xoaSach_Click(object sender, EventArgs e)
        {
            XoaSach formXoaSach = new XoaSach();
            formXoaSach.Show();
        }

        private void ms_lapTheDocGia_Click(object sender, EventArgs e)
        {
            LapTheDocGia formLapTheDocGia = new LapTheDocGia();
            formLapTheDocGia.Show();
        }

        private void ms_capNhatDocGia_Click(object sender, EventArgs e)
        {
            CapNhatDocGia formCapNhatDocGia = new CapNhatDocGia();
            formCapNhatDocGia.Show();
        }

        private void ms_xoaDocGia_Click(object sender, EventArgs e)
        {
            XoaDocGia formXoaDocGia = new XoaDocGia();
            formXoaDocGia.Show();
        }

        private void ms_muonSach_Click(object sender, EventArgs e)
        {
            MuonSach formMuonSach = new MuonSach();
            formMuonSach.Show();
        }

        private void ms_traSach_Click(object sender, EventArgs e)
        {
            TraSach formTraSach = new TraSach();
            formTraSach.Show();
        }

        private void ms_gioiThieu_Click(object sender, EventArgs e)
        {
            GioiThieu formGioiThieu = new GioiThieu();
            formGioiThieu.Show();
        }

        private void ms_baoCaoTraTre_Click(object sender, EventArgs e)
        {
            BaoCaoTraTre formBaoCaoTraTre = new BaoCaoTraTre();
            formBaoCaoTraTre.Show();
        }

        private void ms_baoCaoMuonTheLoai_Click(object sender, EventArgs e)
        {
            BaoCaoMuonTheoTheLoai formBaoCaoTheLoai = new BaoCaoMuonTheoTheLoai();
            formBaoCaoTheLoai.Show();
        }


    }
}
