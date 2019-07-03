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
    Description: Class mô tả các thuộc tính của loại độc giả
    */
    public class LoaiDocGia
    {
        string maLoaiDocGia;
        string loaiDG;

        public string MaLoaiDocGia
        {
            get
            {
                return maLoaiDocGia;
            }

            set
            {
                maLoaiDocGia = value;
            }
        }

        public string LoaiDG
        {
            get
            {
                return loaiDG;
            }

            set
            {
                loaiDG = value;
            }
        }
    }
}
