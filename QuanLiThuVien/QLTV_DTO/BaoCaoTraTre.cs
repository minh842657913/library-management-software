using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class BaoCaoTraTre
    {
        string maBCTra;
        Sach sach;
        PhieuMuon phieuMuon;
        DateTime soNgayTraTre;
        public string MaBCTra
        {
            get { return maBCTra; }
            set { maBCTra = value; }
        }
        public Sach Sach
        {
            get { return sach; }
            set { sach = value; }
        }
        public PhieuMuon PhieuMuown
        {
            get { return phieuMuon; }
            set { phieuMuon = value; }
        }
        public DateTime SoNgayTraTre
        {
            get { return soNgayTraTre; }
            set { soNgayTraTre = value; }
        }
    }
}
