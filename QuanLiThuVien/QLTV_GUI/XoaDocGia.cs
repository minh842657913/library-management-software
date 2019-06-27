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
    public partial class XoaDocGia : Form
    {
        private DocGiaBUS dgBus;
        public XoaDocGia()
        {
            InitializeComponent();
        }

        private void XoaDocGia_Load(object sender, EventArgs e)
        {
            dgBus = new DocGiaBUS();
        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = tb_maDocGia.Text;
            bool kq = dgBus.Xoa(dg);
            if (kq == false)
                MessageBox.Show("Xóa đọc giả thất bại. Vui lòng kiểm tra lại mã");
            else
                MessageBox.Show("Xóa đọc giả thành công");
        }
    }
}
