using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using QLTV_BUS;
using QLTV_DTO;


namespace QLTV_GUI
{
    /*
    Program: Quản lí thư viện
    Written by: Nguyễn Song Luân
    Description: Form đăng nhập và các sự kiện liên quan
    */

    public partial class DangNhap : Form
    {       
        private TaiKhoanBUS tkBus;
        
        public DangNhap()
        {
            InitializeComponent();
            this.tb_taiKhoan.Text = "Tài khoản";
            this.tb_taiKhoan.ForeColor = SystemColors.GrayText;

            this.tb_matKhau.Text = "Mật khẩu";
            this.tb_matKhau.ForeColor = SystemColors.GrayText;

            this.tb_taiKhoan.Leave += Tb_TaiKhoan_Leave;
            this.tb_taiKhoan.Enter += Tb_TaiKhoan_Enter;

            this.tb_matKhau.Leave += Tb_matKhau_Leave;
            this.tb_matKhau.Enter += Tb_matKhau_Enter;
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            tkBus = new TaiKhoanBUS();
        }
        
        private void Tb_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if (tb_taiKhoan.Text.Length == 0)
            {
                tb_taiKhoan.Text = "Tài khoản";
                tb_taiKhoan.ForeColor = SystemColors.GrayText;
            }
        }

        private void Tb_TaiKhoan_Enter(object sender, EventArgs e)
        {
            if (tb_taiKhoan.Text == "Tài khoản")
            {
                tb_taiKhoan.Text = "";
                tb_taiKhoan.ForeColor = SystemColors.WindowText;
            }
        }

        private void Tb_matKhau_Enter(object sender, EventArgs e)
        {
            if (tb_matKhau.Text == "Mật khẩu")
            {
                tb_matKhau.Text = "";
                tb_matKhau.PasswordChar = '*';
                tb_matKhau.ForeColor = SystemColors.WindowText;
            }
        }

        private void Tb_matKhau_Leave(object sender, EventArgs e)
        {
            if (tb_matKhau.Text.Length == 0)
            {
                tb_matKhau.Text = "Mật khẩu";
                tb_matKhau.PasswordChar = '\0';
                tb_matKhau.ForeColor = SystemColors.GrayText;
            }
        }

        private void bt_dangNhap_Click(object sender, EventArgs e)
        {
            if (tb_taiKhoan.Text == "" || tb_taiKhoan.Text == "Tài khoản"
                || tb_matKhau.Text == "" || tb_matKhau.Text == "Mật khẩu")
            {
                MessageBox.Show("Nhap lai tai khoan, mat khau");

            }
            else
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenTaiKhoan = tb_taiKhoan.Text;
                tk.MatKhau = tb_matKhau.Text;
                if(tk.equals(tkBus.Select()))
                {                   
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {                  
                    MessageBox.Show("login khong thanh cong");
                }
            }            
        }              
    }
}
