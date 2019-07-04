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
    public partial class XoaSach : Form
    {
        private SachBUS saBus;

        public XoaSach()
        {
            InitializeComponent();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Sach sa = new Sach();
            sa.MaSach = tb_maSach.Text;

            bool kq = saBus.Xoa(sa);
            if (kq == false)
            {
                MessageBox.Show("Xóa sách thất bại. Vui lòng kiểm tra lại dữ liệu.");
            }
            else
            {
                MessageBox.Show("Xóa sách thành công! ");
            }
        }

        private void XoaSach_Load(object sender, EventArgs e)
        {
            saBus = new SachBUS();
        }
    }
}
