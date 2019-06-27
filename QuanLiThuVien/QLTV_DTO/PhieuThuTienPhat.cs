using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class PhieuThuTienPhat
    {
        string maPTTP;
        DocGia docGia;
        ThongTinNo maTTN;
        int soTienThu;
        int soTienCL;
        public string MaPTTP
        {
            get { return maPTTP; }
            set { maPTTP = value; }
        }
        public DocGia DocGia
        {
            get { return docGia; }
            set { docGia = value; }
        }
        public int SoTienThu
        {
            get { return soTienThu; }
            set { soTienThu = value; }
        }
        public int SoTienCL
        {
            get { return soTienCL; }
            set { soTienCL = value; }
        }
    }
}
