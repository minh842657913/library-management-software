using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_DTO;
using QLTV_BUS;

namespace QLTV_GUI
{
    public partial class BaoCaoTraTre : Form
    {
        TraTreTKBUS tk_TraTreBUS = new TraTreTKBUS();

        public BaoCaoTraTre()
        {
            InitializeComponent();
        }

        private void dtp_Ngay_ValueChanged(object sender, EventArgs e)
        {
            string[] strNgayThangNam = dtp_Ngay.Text.Split('/');


            string strNamThangNgay = strNgayThangNam[2] + "/" + strNgayThangNam[1] + "/" + strNgayThangNam[0];

            List<TraTreTK> listTraTre = tk_TraTreBUS.Select(strNamThangNgay);
            DataToGridView(listTraTre);
        }

        private void DataToGridView(List<TraTreTK> listTraTre)
        {
            if (listTraTre == null)
            {
                MessageBox.Show("Không có mục cần tìm, hoặc có lỗi trong quá trình lấy dữ liệu từ DB");
                return;
            }

            dgv_TraTre.DataSource = null;
            dgv_TraTre.AutoGenerateColumns = false;
            dgv_TraTre.AllowUserToAddRows = false;
            dgv_TraTre.DataSource = listTraTre;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_TraTre.DataSource];
            myCurrencyManager.Refresh();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xacNhan_Click(object sender, EventArgs e)
        {
            //Dinh nghia dataSet
            DataSet ds = new DataSet();

            DataTable dttb_TraTre = new DataTable();
            dttb_TraTre.Columns.Add("STT", typeof(Int32));
            dttb_TraTre.Columns.Add("tenSach", typeof(string));
            dttb_TraTre.Columns.Add("ngayMuon", typeof(string));
            dttb_TraTre.Columns.Add("soNgayTraTre", typeof(int));

            foreach (DataGridViewRow dgvR in dgv_TraTre.Rows)
            {
                dttb_TraTre.Rows.Add(dgvR.Cells[0].Value, dgvR.Cells[1].Value, dgvR.Cells[2].Value, dgvR.Cells[3].Value);
            }

            ds.Tables.Add(dttb_TraTre);
            ds.WriteXmlSchema("Sample_BaoCaoTraTre.xml");

            rp_BaoCaoTraTre formBaoCaoTraTre = new rp_BaoCaoTraTre(ds, dtp_Ngay.Text);
            formBaoCaoTraTre.Show();
        }
    }
}
