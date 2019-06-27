using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class ThongTinNo
    {
        string maTTN;
        DocGia docGia;
        int tongNo;
        public string MaTTN
        {
            get { return maTTN; }
            set { maTTN = value; }
        }
        public DocGia DocGia
        {
            get { return docGia; }
            set { docGia = value; }
        }
        public int TongNo
        {
            get { return tongNo; }
            set { tongNo = value; }
        }

    }
}
