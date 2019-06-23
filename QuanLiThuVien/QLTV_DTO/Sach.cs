using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Thành Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 23/05/2019
    Description: Class mô tả các thuộc tính của sách
    */
    public class Sach
    {
        string maSach;
        string tenSach;
        string loaiSach;
        string maTacGia;
        string maNhaXuatBan;
        int namXuatBan;
        string ngayNhap;
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
    }
}
