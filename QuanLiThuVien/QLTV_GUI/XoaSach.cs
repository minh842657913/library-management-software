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
    Modified date: 23/05/2019
    Description: Class mô tả thực hiện xóa sách
    */
    public partial class XoaSach : Form
    {
        private SachBUS sachBus;

        public XoaSach()
        {
            InitializeComponent();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = tb_maSach.Text;

            bool kq = sachBus.Xoa(sach);
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
            sachBus = new SachBUS();
        }
    }
}
