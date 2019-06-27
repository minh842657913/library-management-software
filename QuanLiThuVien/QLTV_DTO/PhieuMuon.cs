using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class PhieuMuon
    {
        string maPhieuMuon;
        DocGia docGia;
        Sach sach;
        TacGia tacGia;
        DateTime ngayMuon;
        
        public string MaPhieuMuon
        {
            get
            {
                return maPhieuMuon;
            }
            set
            {
                maPhieuMuon = value;
            }
        }
        public DocGia DocGia
        {
            get { return docGia; }
            set { docGia = value; }
        }
        public Sach Sach
        {
            get { return sach; }
            set { sach = value; }
        }
        public TacGia TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
    }
}
