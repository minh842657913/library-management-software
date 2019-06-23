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
    Description: Class mô tả các thuộc tính của loại sách
    */
    public class LoaiSach
    {
        string maLoaiSach;
        string theLoai;

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

        public string TheLoai
        {
            get
            {
                return theLoai;
            }

            set
            {
                theLoai = value;
            }
        }
    }
}
