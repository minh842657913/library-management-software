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
    Description: Class mô tả các thuộc tính của nhà xuất bản
    */
    public class NhaXuatBan
    {
        string maNXB;
        string tenNXB;

        public string MaNXB
        {
            get
            {
                return maNXB;
            }

            set
            {
                maNXB = value;
            }
        }

        public string TenNXB
        {
            get
            {
                return tenNXB;
            }

            set
            {
                tenNXB = value;
            }
        }
    }
}
