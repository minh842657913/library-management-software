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
    public partial class rp_MuonTheoTheLoai : Form
    {
        DataSet dataSet = new DataSet();
        string strTime;
        int intSum;
        public rp_MuonTheoTheLoai(DataSet ds, string[] strThangNam, int intTongLuotMuon)
        {
            InitializeComponent();

            dataSet = ds;
            strTime = strThangNam[0] + "/" + strThangNam[1];
            intSum = intTongLuotMuon;
        }

        private void rp_MuonTheoTheLoai_Load(object sender, EventArgs e)
        {
            rp_MuonTheLoai_Thang cr = new rp_MuonTheLoai_Thang();
            cr.SetDataSource(dataSet);
            this.cr_Viewer.ReportSource = cr;

            SetParameters(strTime, intSum);
            
        }

        private void SetParameters(string strThangNgay, int intTongLuotMuon)
        {
            ParameterFields From = new ParameterFields();
            ParameterField time = new ParameterField();
            ParameterField tongLuot = new ParameterField();

            time.Name = "strThangNam";
            ParameterDiscreteValue timeVal = new ParameterDiscreteValue();
            timeVal.Value = strThangNgay;
            time.CurrentValues.Add(timeVal);
            From.Add(time);

            tongLuot.Name = "intTongLuotMuon";
            ParameterDiscreteValue sumVal = new ParameterDiscreteValue();
            sumVal.Value = intTongLuotMuon;
            tongLuot.CurrentValues.Add(sumVal);
            From.Add(tongLuot);

            cr_Viewer.ParameterFieldInfo = From;
        }
    }
}
