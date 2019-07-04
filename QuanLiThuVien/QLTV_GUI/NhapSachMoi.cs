using System;
using QLTV_BUS;
using QLTV_DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace QLTV_GUI
{
    public partial class NhapSachMoi : Form
    {
        private SachBUS saBus;
        private LoaiSachBUS loaiSBus;
        CultureInfo viVN = new CultureInfo("vi-Vn"); //Lấy kiểu văn hóa thời gian theo VN

        public NhapSachMoi()
        {
            InitializeComponent();            
        }

        private void bt_nhapSach_Click(object sender, EventArgs e)
        {
            //- Lay du lieu tu gui xuong
            Sach sa = new Sach();
            sa.MaSach = tb_maSach.Text;
            sa.TenSach = tb_tenSach.Text;
            sa.MaLoaiSach = cb_theLoai.Text;
            sa.MaTacGia = tb_tacGia.Text;
            sa.NamXuatBan = int.Parse(tb_namXuatBan.Text);
            sa.MaNhaXuatBan = tb_nhaXuatBan.Text;
            sa.TriGia = int.Parse(tb_triGia.Text);
            sa.NgayNhap = tb_ngayNhap.Text;

            Console.Write(sa.NgayNhap);
            //- kiemm tra du lieu nhap

            // Them vao data base
            bool kq = saBus.Them(sa);
            if (kq == false)
            {
                MessageBox.Show("Thêm sách mới thất bại. Vui lòng kiểm tra lại dữ liệu.");
            }
            else
            {
                MessageBox.Show("Thêm sách mới thành công! ");
            }
        }

        private void NhapSachMoi_Load(object sender, EventArgs e)
        {
            saBus = new SachBUS();
            loaiSBus = new LoaiSachBUS();
            Load_LoaiSach_Combobox();
            //Đưa thời gian hiện tại vào textbox 
            DateTime now = DateTime.Now;
            tb_ngayNhap.Text = now.ToString("d", viVN);
        }

        private void Load_LoaiSach_Combobox()
        {
            List<LoaiSach> listLoaiSach = loaiSBus.Select();

            if (listLoaiSach == null)
            {
                MessageBox.Show("Có lỗi khi lấy Loai sach từ DB");
                return;
            }
            cb_theLoai.DataSource = new BindingSource(listLoaiSach, String.Empty);
            cb_theLoai.DisplayMember = "MaLoaiSach";
            cb_theLoai.ValueMember = "MaLoaiSach";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_theLoai.DataSource];
            myCurrencyManager.Refresh();

            if (cb_theLoai.Items.Count > 0)
            {
                cb_theLoai.SelectedIndex = 0;
            }
        }
    }
}
