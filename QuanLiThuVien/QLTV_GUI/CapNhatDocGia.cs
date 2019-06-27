using QLTV_BUS;
using QLTV_DTO;
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
    public partial class CapNhatDocGia : Form
    {
        private DocGiaBUS dgBus;
        private LoaiDocGiaBUS loaidgBus;
        public CapNhatDocGia()
        {
            InitializeComponent();
        }

        private void CapNhatDocGia_Load(object sender, EventArgs e)
        {
            dgBus = new DocGiaBUS();
            loaidgBus = new LoaiDocGiaBUS();
            load_LoaiDocGia_Combobox();
        }

        private void load_LoaiDocGia_Combobox()
        {
            List<LoaiDocGia> listLoaiDocGia = loaidgBus.Select();
            if (listLoaiDocGia == null)
            {
                MessageBox.Show("Có lỗi khi lấy loại đọc giả từ DB");
                return;
            }
            cb_LoaiDocGia.DataSource = new BindingSource(listLoaiDocGia, String.Empty);
            cb_LoaiDocGia.DisplayMember = "MaLoaiDocGia";
            cb_LoaiDocGia.ValueMember = "MaLoaiDocGia";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_LoaiDocGia.DataSource];
            myCurrencyManager.Refresh();

            if (cb_LoaiDocGia.Items.Count > 0)
            {
                cb_LoaiDocGia.SelectedIndex = 0;
            }
        }

        private void Bt_capNhat_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.DiaChi = tb_diaChi.Text;
            dg.Email = tb_email.Text;
            dg.HoTen = tb_hoTenDocGia.Text;
            dg.MaDocGia = cb_maDocGia.Text;
            dg.NgaySinh = DateTime.Parse(tx_ngaySinh.Text);

            bool kq = dgBus.Sua(dg);
            if (kq == false)
                MessageBox.Show("Cập nhật độc giả thất bại. Vui lòng kiểu tra lại dữ liệu");
            else
                MessageBox.Show("Cập nhật thành công.");

        }
    }
}
