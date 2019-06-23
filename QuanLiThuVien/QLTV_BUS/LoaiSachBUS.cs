using System;
using QLTV_DAL;
using QLTV_DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Thành Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 23/05/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của loại sách (lớp bussiness)
    */
    public class LoaiSachBUS
    {
        private LoaiSachDAL loaiSachDal;
        public LoaiSachBUS()
        {
            loaiSachDal = new LoaiSachDAL();
        }
        //public bool Them(Sach loaiS)
        //{
        //    bool re = loaiSDal.Them(loaiS);
        //    return re;
        //}

        public List<LoaiSach> Select()
        {
            return loaiSachDal.Select();
        }
    }
}
