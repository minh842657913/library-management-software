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
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Song Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 24/06/2019
    Description: Class mô tả thực hiện nhập sách mới
    */
    public partial class NhapSachMoi : Form
    {
        private SachBUS sachBus;
        private LoaiSachBUS loaiSachBus;
        private DateTime now = DateTime.Now;

        public NhapSachMoi()
        {
            InitializeComponent();            
        }

        private void bt_nhapSach_Click(object sender, EventArgs e)
        {
            //- Lay du lieu tu gui xuong
            Sach sach = new Sach();
            sach.MaSach = tb_maSach.Text;
            sach.TenSach = tb_tenSach.Text;
            sach.LoaiSach = cb_theLoai.Text;
            sach.MaTacGia = tb_tacGia.Text;
            sach.NamXuatBan = int.Parse(tb_namXuatBan.Text);
            sach.MaNhaXuatBan = tb_nhaXuatBan.Text;
            sach.TriGia = int.Parse(tb_triGia.Text);
            sach.NgayNhap = tb_ngayNhap.Text;

            Console.Write(sach.NgayNhap);
            //- kiemm tra du lieu nhap
            if (sach.NamXuatBan > now.Year)
            {

                MessageBox.Show("Năm xuất bản lớn hơn ngày nhập !");
            }
            else
            {
                // Them vao data base
                bool kq = sachBus.Them(sach);
                if (kq == false)
                {
                    MessageBox.Show("Thêm sách mới thất bại. Vui lòng kiểm tra lại dữ liệu.");
                }
                else
                {
                    MessageBox.Show("Thêm sách mới thành công! ");
                }
            }          
        }

        private void NhapSachMoi_Load(object sender, EventArgs e)
        {
            sachBus = new SachBUS();
            loaiSachBus = new LoaiSachBUS();
            Load_LoaiSach_Combobox();
            //Đưa thời gian hiện tại vào textbox           
            tb_ngayNhap.Text = now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void Load_LoaiSach_Combobox()
        {
            List<LoaiSach> listLoaiSach = loaiSachBus.Select();

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

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
