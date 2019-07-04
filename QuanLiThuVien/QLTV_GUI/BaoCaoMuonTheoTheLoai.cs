using System;
using System.IO;
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
    public partial class BaoCaoMuonTheoTheLoai : Form
    {
        TheLoaiTKBUS tkTheLoaiBUS = new TheLoaiTKBUS();
        int intTongLuotMuon;
        string[] strThangNam;

        public BaoCaoMuonTheoTheLoai()
        {
            InitializeComponent();
        }

        private void bt_xacNhan_Click(object sender, EventArgs e)
        {
            //Dinh nghia dataSet
            DataSet ds = new DataSet();

            DataTable dttb_TheLoai = new DataTable();
            dttb_TheLoai.Columns.Add("STT", typeof(Int32));
            dttb_TheLoai.Columns.Add("tenTheLoai", typeof(string));
            dttb_TheLoai.Columns.Add("soLuotMuon", typeof(Int32));
            dttb_TheLoai.Columns.Add("tiLe", typeof(double));

            foreach (DataGridViewRow dgvR in dgv_MuonTheoTheLoai.Rows)
            {
                dttb_TheLoai.Rows.Add(dgvR.Cells[0].Value, dgvR.Cells[1].Value, dgvR.Cells[2].Value, dgvR.Cells[3].Value);
            }

            ds.Tables.Add(dttb_TheLoai);
            ds.WriteXmlSchema("Sample.xml");

            rp_MuonTheoTheLoai formMuonTheoTheLoai = new rp_MuonTheoTheLoai(ds, strThangNam, intTongLuotMuon);
            formMuonTheoTheLoai.Show();
        }

        private void DataToGridView(List<TheLoaiTK> listTheLoai)
        {
            if (listTheLoai == null)
            {
                MessageBox.Show("Không có sách cần tìm, hoặc có lỗi trong quá trình lấy dữ liệu từ DB");
                return;
            }

            dgv_MuonTheoTheLoai.DataSource = null;

            dgv_MuonTheoTheLoai.AutoGenerateColumns = false;
            dgv_MuonTheoTheLoai.AllowUserToAddRows = false;
            dgv_MuonTheoTheLoai.DataSource = listTheLoai;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_MuonTheoTheLoai.DataSource];
            myCurrencyManager.Refresh();
        }

        private void dtp_Thang_ValueChanged(object sender, EventArgs e)
        {
            strThangNam = dtp_Thang.Text.Split('/');
            intTongLuotMuon = tkTheLoaiBUS.SelectSum(strThangNam);

            List<TheLoaiTK> listTheLoai = tkTheLoaiBUS.Select(strThangNam,intTongLuotMuon);
            this.DataToGridView(listTheLoai);

            tb_tongLuotMuon.Text = intTongLuotMuon.ToString();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
