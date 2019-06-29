using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_BUS;
using QLTV_DTO;

namespace QLTV_GUI
{

    public partial class PhieuThuTienPhat : Form
    {
        DocGiaPBUS docGiaPBUS;
        PhieuPhatBUS phieuPhatBUS;
        //---------------------

        public PhieuThuTienPhat()
        {
            InitializeComponent();

            docGiaPBUS = new DocGiaPBUS();
            phieuPhatBUS = new PhieuPhatBUS();

            DataToComboBox();

            LoadData();

            TienThuThayDoi();
        }

        // Đưa dữ liệu vào comboBox 
        private void DataToComboBox()
        {
            List<DocGiaP> listDocGiaP = docGiaPBUS.SelectAll();

            if (listDocGiaP == null)
            {
                MessageBox.Show("Có lỗi trong quá trình lấy dữ liệu");
                return;
            }

            cb_hoTenDocGia.DataSource = new BindingSource(listDocGiaP, String.Empty);
            cb_hoTenDocGia.DisplayMember ="StrMaVaTen";
            cb_hoTenDocGia.ValueMember = "MaDocGia";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_hoTenDocGia.DataSource];
            myCurrencyManager.Refresh();

            if (cb_hoTenDocGia.Items.Count > 0)
            {
                cb_hoTenDocGia.SelectedIndex = 0;
            }
        }



        private void cb_hoTenDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();

            TienThuThayDoi();
        }

        //Cập nhật thông tin tổng nợ trên form
        private void LoadData()
        {
            PhieuPhat phieuPhat = new PhieuPhat();
            string strMaDocGia = cb_hoTenDocGia.SelectedValue.ToString();

            strMaDocGia = strMaDocGia.Trim();
            phieuPhat = phieuPhatBUS.Select(strMaDocGia);

            tb_tongNo.Text = phieuPhat.TongNo.ToString();
        }

        private void bt_xacNhan_Click(object sender, EventArgs e)
        {
            if (cb_hoTenDocGia.Text == "" || tb_tongNo.Text == "" || tb_soTienThu.Text == "" || tb_conLai.Text == "")
            {
                return;
            }
            pp_PhieuThuTienPhat formPhieuThuTienPhat = new pp_PhieuThuTienPhat(cb_hoTenDocGia.Text, float.Parse(tb_tongNo.Text),
                float.Parse(tb_soTienThu.Text), float.Parse(tb_conLai.Text));

            CapNhatTongNo();

            formPhieuThuTienPhat.Show();

            LoadData();

            TienThuThayDoi();
        }

        private void tb_soTienThu_TextChanged(object sender, EventArgs e)
        {
            TienThuThayDoi();
        }

        private void TienThuThayDoi()
        {
            if (tb_soTienThu.Text == "")
            {
                tb_soTienThu.Text = "0";
            }
            float conLai = float.Parse(tb_tongNo.Text) - float.Parse(tb_soTienThu.Text);
            tb_conLai.Text = conLai.ToString();
        }

        private void tb_soTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatTongNo()
        {
            PhieuPhat infoDocGia = new PhieuPhat();
            infoDocGia.MaDocGia = cb_hoTenDocGia.SelectedValue.ToString();
            infoDocGia.MaDocGia = infoDocGia.MaDocGia.Trim();
            infoDocGia.ConLai = float.Parse(tb_conLai.Text);

            bool kq = docGiaPBUS.UpdateTongNo(infoDocGia);

            if (kq == false)
            {
                MessageBox.Show("Cập nhật tổng nợ thất bại");
            }
            else
            {
                MessageBox.Show("Đã cập nhật tổng nợ");
            }
        }
    }
}
