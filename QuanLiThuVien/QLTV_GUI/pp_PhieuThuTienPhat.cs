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
    public partial class pp_PhieuThuTienPhat : Form
    {
        string docGia;
        float tongNo;
        float soTienThu;
        float conLai;

        public pp_PhieuThuTienPhat(string strDocGia, float fTongNo, float fSoTienThu, float fConLai)
        {
            InitializeComponent();

            docGia = strDocGia;
            tongNo = fTongNo;
            soTienThu = fSoTienThu;
            conLai = fConLai;
        }

        private void pp_PhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            pp_PhieuPhat_ cr = new pp_PhieuPhat_();
            this.cr_Viewer.ReportSource = cr;

            SetParameter(docGia, tongNo, soTienThu, conLai);
        }

        private void SetParameter(string docGia, float tongNo, float soTienThu, float conLai)
        {
            ParameterFields From = new ParameterFields();
            ParameterField docGia_ = new ParameterField();
            ParameterField tongNo_ = new ParameterField(); 
            ParameterField soTienThu_ = new ParameterField();
            ParameterField conLai_ = new ParameterField();

            docGia_.Name = "strDocGia";
            ParameterDiscreteValue docGiaVal = new ParameterDiscreteValue();
            docGiaVal.Value = docGia;
            docGia_.CurrentValues.Add(docGiaVal);
            From.Add(docGia_);

            tongNo_.Name = "fTongNo";
            ParameterDiscreteValue tongNoVal = new ParameterDiscreteValue();
            tongNoVal.Value = tongNo;
            tongNo_.CurrentValues.Add(tongNoVal);
            From.Add(tongNo_);

            soTienThu_.Name = "fSoTienThu";
            ParameterDiscreteValue soTienThuVal = new ParameterDiscreteValue();
            soTienThuVal.Value = soTienThu;
            soTienThu_.CurrentValues.Add(soTienThuVal);
            From.Add(soTienThu_);

            conLai_.Name = "fConLai";
            ParameterDiscreteValue conLaiVal = new ParameterDiscreteValue();
            conLaiVal.Value = conLai;
            conLai_.CurrentValues.Add(conLaiVal);
            From.Add(conLai_);

            cr_Viewer.ParameterFieldInfo = From;
        }
    }
}
