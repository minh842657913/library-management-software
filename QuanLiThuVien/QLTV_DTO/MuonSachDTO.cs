using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class MuonSachDTO
    {   

        private string maDocGia;
        private string tenDocGia;
        private string ngayMuon;
        private string maSach;
        private string tenSach;
        private int soLuong;
        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }
        public string TenSach
        {
            get
            {
                return tenSach;
            }
            set
            {
                tenSach = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
        public string NgayMuon
        {
            get
            {
                return ngayMuon;
            }
            set
            {
                ngayMuon = value;
            }
        }
        public string TenDocGia
        {
            get
            {
                return tenDocGia;
            }
            set
            {
                tenDocGia = value;
            }
        }
        public string MaDocGia
        {
            get
            {
                return maDocGia;
            }
            set
            {
                maDocGia = value;
            }
        }      
    }
}
