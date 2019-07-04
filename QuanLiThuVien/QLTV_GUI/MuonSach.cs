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
    public partial class MuonSach : Form
    {
        private MuonSachBUS msBus;
        public MuonSach()
        {
            InitializeComponent();
        }
        private void MuonSach_Load(object sender, EventArgs e)
        {
            msBus = new MuonSachBUS();
        }
        private void ADD_TEXTBOX_TO_DATAGILDVIEW()
        {
            MuonSachDTO ms = new MuonSachDTO();
            ms.SoLuong = int.Parse(tb_soLuong.Text);
            ms.MaSach = tb_maSach.Text;
            ms.TenSach = tb_tenSach.Text;
            if (ms.SoLuong == 0 || ms.TenSach == "" || ms.MaSach == "")
            {
                MessageBox.Show("Bạn phải nhập đủ các ô.");
            }
            else
            {
                dgvMuonSach.AllowUserToAddRows = false;
                dgvMuonSach.Rows.Add(1);
                int indexRow = dgvMuonSach.Rows.Count - 1;
                dgvMuonSach[1, indexRow].Value = tb_maSach.Text;
                dgvMuonSach[2, indexRow].Value = tb_tenSach.Text;
                dgvMuonSach[5, indexRow].Value = ms.SoLuong;
            }           
        }
        private void Bt_nhapLieu_Click(object sender, EventArgs e)
        {
            ADD_TEXTBOX_TO_DATAGILDVIEW();
        }

        private void Bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_maSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        private void Tb_tenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        private void Tb_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
