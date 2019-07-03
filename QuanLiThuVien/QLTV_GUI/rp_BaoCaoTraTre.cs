using CrystalDecisions.Shared;
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
    public partial class rp_BaoCaoTraTre : Form
    {
        DataSet dataSet = new DataSet();
        string strTime;
        public rp_BaoCaoTraTre(DataSet ds, string strNgayThangNam)
        {
            InitializeComponent();

            dataSet = ds;
            strTime = strNgayThangNam;
        }

        private void rp_BaoCaoTraTre_Load(object sender, EventArgs e)
        {
            rp_BaoCaoTraTre_Ngay cr = new rp_BaoCaoTraTre_Ngay();
            cr.SetDataSource(dataSet);
            this.cr_Viewer.ReportSource = cr;

            SetParameters(strTime);
        }

        private void SetParameters(string strTime)
        {
            ParameterFields From = new ParameterFields();
            ParameterField time = new ParameterField();

            time.Name = "strNgay";
            ParameterDiscreteValue timeVal = new ParameterDiscreteValue();
            timeVal.Value = strTime;
            time.CurrentValues.Add(timeVal);
            From.Add(time);

            cr_Viewer.ParameterFieldInfo = From;
        }
    }
}
