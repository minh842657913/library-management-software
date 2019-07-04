using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class Sach
    {
        string maSach;
        string tenSach;

        string maLoaiSach;
        string loaiSach;

        string maTacGia;
        string tacGia;

        string maNhaXuatBan;
        string nhaXuatBan;

        int namXuatBan;
        string ngayNhap;
        int soLuongTon;
        double triGia;

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

        public string MaLoaiSach
        {
            get
            {
                return maLoaiSach;
            }

            set
            {
                maLoaiSach = value;
            }
        }

        public string LoaiSach
        {
            get
            {
                return loaiSach;
            }

            set
            {
                loaiSach = value;
            }
        }

        public string MaTacGia
        {
            get
            {
                return maTacGia;
            }

            set
            {
                maTacGia = value;
            }
        }

        public string TacGia
        {
            get
            {
                return tacGia;
            }

            set
            {
                tacGia = value;
            }
        }

        public string MaNhaXuatBan
        {
            get
            {
                return maNhaXuatBan;
            }

            set
            {
                maNhaXuatBan = value;
            }
        }

        public string NhaXuatBan
        {
            get
            {
                return nhaXuatBan;
            }

            set
            {
                nhaXuatBan = value;
            }
        }

        public int NamXuatBan
        {
            get
            {
                return namXuatBan;
            }

            set
            {
                namXuatBan = value;
            }
        }

        public string NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public double TriGia
        {
            get
            {
                return triGia;
            }

            set
            {
                triGia = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return soLuongTon;
            }

            set
            {
                soLuongTon = value;
            }
        } 
    }
}
