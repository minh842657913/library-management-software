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
    public partial class CapNhatSach : Form
    {
        private SachBUS saBus;
        private LoaiSachBUS loaiSBus;

        public CapNhatSach()
        {
            InitializeComponent();
        }

        private void CapNhatSach_Load(object sender, EventArgs e)
        {
            saBus = new SachBUS();
            loaiSBus = new LoaiSachBUS();
            Load_LoaiSach_Combobox();
        }

        private void bt_capNhat_Click(object sender, EventArgs e)
        {
            //Lay du lieu tu GUI
            Sach sa = new Sach();
            sa.MaSach = tb_maSach.Text;
            sa.TenSach = tb_tenSach.Text;
            sa.MaLoaiSach = cb_theLoai.Text;
            sa.MaTacGia = tb_tacGia.Text;
            sa.NamXuatBan = int.Parse(tb_namXuatBan.Text);
            sa.MaNhaXuatBan = tb_nhaXuatBan.Text;
            sa.TriGia = int.Parse(tb_triGia.Text);

            //Them vao database
            bool kq = saBus.Sua(sa);
            if (kq == false)
                MessageBox.Show("Cập nhật sách thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Cập nhật sách thành công");
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
