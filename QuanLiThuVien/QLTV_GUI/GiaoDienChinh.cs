using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_DAL;
using QLTV_BUS;
using QLTV_DTO;

namespace QLTV_GUI
{
    public partial class GiaoDienChinh : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private DangNhap formDangNhap;
        //--------------------
        public GiaoDienChinh()
        {
            InitializeComponent();
        }        
        private void ms_dangNhap_Click(object sender, EventArgs e)
        {        
            using (var form = new DangNhap())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {                   
                    enable();                    
                }          
            }
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

        private void bt_timKiem_Click(object sender, EventArgs e)
        {
            disable();
            string strTuKhoa = tb_timKiem.Text.Trim();
            if (strTuKhoa == null || strTuKhoa == string.Empty || strTuKhoa.Length == 0)
            {
                List<Sach> listSach = sachBUS.Select();
                this.DataToGridView(listSach);
            }
            else
            {
                List<Sach> listSach = sachBUS.SelectByKeyword(strTuKhoa);
                this.DataToGridView(listSach);
            }
        }

        private void DataToGridView(List<Sach> listSach)
        {
            if (listSach == null)
            {
                MessageBox.Show("Không có sách cần tìm, hoặc có lỗi trong quá trình lấy dữ liệu từ DB");
                return;
            }

            dt_bangSach.DataSource = null;

            dt_bangSach.AutoGenerateColumns = false;
            dt_bangSach.AllowUserToAddRows = false;
            dt_bangSach.DataSource = listSach;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dt_bangSach.DataSource];
            myCurrencyManager.Refresh();
        }

     

        public void disable()
        {

            ts_lapTheDocGia.Enabled = false;
            ms_dangXuat.Enabled = false;
            ms_lapPhieuPhat.Enabled = false;
            ms_lapBaoCao.Enabled = false;
            ms_nhapSach.Enabled = true;
            ms_capNhatSach.Enabled = false;
            ms_xoaSach.Enabled = false;
            ms_lapTheDocGia.Enabled = false;
            ms_capNhatDocGia.Enabled = false;
            ms_xoaDocGia.Enabled = false;
            ms_muonSach.Enabled = false;
            ms_traSach.Enabled = false;
            ts_lapTheDocGia.Enabled = false;
            ts_muonSach.Enabled = false;
            ts_traSach.Enabled = false;
            ts_nhapSach.Enabled = false;
            ts_lapPhieuPhat.Enabled = false;
            ts_baoCao.Enabled = false;
            lb_dangXuat.Enabled = false;
            ms_nhapSach.Enabled = false;
            ms_dangNhap.Enabled = true;
            lb_tenTaiKhoan.Text = "      Khách    ";
        }
        public void enable()
        {

            ts_lapTheDocGia.Enabled = true;
            ms_dangXuat.Enabled = true;
            ms_lapPhieuPhat.Enabled = true;
            ms_lapBaoCao.Enabled = true;
            ms_nhapSach.Enabled = true;
            ms_capNhatSach.Enabled = true;
            ms_xoaSach.Enabled = true;
            ms_lapTheDocGia.Enabled = true;
            ms_capNhatDocGia.Enabled = true;
            ms_xoaDocGia.Enabled = true;
            ms_muonSach.Enabled = true;
            ms_traSach.Enabled = true;
            ts_lapTheDocGia.Enabled = true;
            ts_muonSach.Enabled = true;
            ts_traSach.Enabled = true;
            ts_nhapSach.Enabled = true;
            ts_lapPhieuPhat.Enabled = true;
            ts_baoCao.Enabled = true;
            lb_dangXuat.Enabled = true;
            ms_dangNhap.Enabled = false;
            lb_tenTaiKhoan.Text = "QuảnTrịViên";
        }

        private void Ms_dangXuat_Click(object sender, EventArgs e)
        {
            disable();
        }
    }
}
