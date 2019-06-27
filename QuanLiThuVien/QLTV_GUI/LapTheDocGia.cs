using QLTV_BUS;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_GUI
{
    public partial class LapTheDocGia : Form
    {
        private DocGiaBUS dgBus;
        private LoaiDocGiaBUS loaidgBus;
        CultureInfo viVN = new CultureInfo("vi-Vn"); //Lấy kiểu văn hóa thời gian theo VN
        public LapTheDocGia()
        {
            InitializeComponent();
        }

        private void Bt_taoThe_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.HoTen = tb_hoTenDocGia.Text;
            dg.NgaySinh = DateTime.Parse(tb_ngaySinh.Text);
            dg.DiaChi = tb_diaChi.Text;
            dg.Email = tb_email.Text;
            dg.NgayLapThe = DateTime.Parse(tb_ngayLapThe.Text);

            bool kq = dgBus.Them(dg);
            if (kq == false)
            {
                MessageBox.Show("Lập thẻ đọc giả mới thất bại. Vui lòng kiểm tra lại dữ liệu.");
            }
            else
            {
                MessageBox.Show("Lập thẻ đọc giả mới thành công! ");
            }

        }

        private void LapTheDocGia_Load(object sender, EventArgs e)
        {
            dgBus = new DocGiaBUS();
            loaidgBus = new LoaiDocGiaBUS();
            Load_LoaiDocGia_Combobox();
            //Đưa thời gian hiện tại vào textbox 
            DateTime now = DateTime.Now;
            tb_ngayLapThe.Text = now.ToString("d", viVN);
        }

        private void Load_LoaiDocGia_Combobox()
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
    }
}
