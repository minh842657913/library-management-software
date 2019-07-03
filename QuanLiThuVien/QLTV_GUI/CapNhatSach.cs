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

namespace QLTV_GUI
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Song Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 24/06/2019
    Description: Class mô tả thực hiện cập nhật sách
    */
    public partial class CapNhatSach : Form
    {
        private SachBUS sachBus;
        private LoaiSachBUS loaiSachBus;

        public CapNhatSach()
        {
            InitializeComponent();
        }

        private void CapNhatSach_Load(object sender, EventArgs e)
        {
            sachBus = new SachBUS();
            loaiSachBus = new LoaiSachBUS();
            Load_LoaiSach_Combobox();
        }

        private void bt_capNhat_Click(object sender, EventArgs e)
        {
            //Lay du lieu tu GUI
            Sach sach = new Sach();
            sach.MaSach = tb_maSach.Text;
            sach.TenSach = tb_tenSach.Text;
            sach.LoaiSach = cb_theLoai.Text;
            sach.MaTacGia = tb_tacGia.Text;
            sach.NamXuatBan = int.Parse(tb_namXuatBan.Text);
            sach.MaNhaXuatBan = tb_nhaXuatBan.Text;
            sach.TriGia = int.Parse(tb_triGia.Text);

            //Them vao database
            bool kq = sachBus.Sua(sach);
            if (kq == false)
                MessageBox.Show("Cập nhật sách thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Cập nhật sách thành công");
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

        /* 
        Description: Sử dụng mã sách để hiện thông tin của sách. 
        Written by: Nguyễn Thành Luân
        Modified by: Nguyễn Thành Luân 
        */
        private void tb_maSach_TextChanged(object sender, EventArgs e)
        {
            List<Sach> listSach = new List<Sach>();

            listSach = sachBus.TaiDuLieu();

            foreach (var sach in listSach)
            {
                //Cắt khoảng trắng ở đầu và sau chuỗi MaSach
                sach.MaSach = sach.MaSach.Trim();

                if (tb_maSach.Text == sach.MaSach) /*Nếu textbox mã sách = 1 mã sách trong CSDL thì hiện thông tin sách lên*/
                {
                    tb_tenSach.Text = sach.TenSach;
                    cb_theLoai.Text = sach.MaLoaiSach;
                    tb_tacGia.Text = sach.MaTacGia;
                    tb_namXuatBan.Text = sach.NamXuatBan.ToString();
                    tb_nhaXuatBan.Text = sach.MaNhaXuatBan;
                    tb_soLuong.Text = sach.SoLuongTon.ToString();
                    tb_triGia.Text = sach.TriGia.ToString();
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
