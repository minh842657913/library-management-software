using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Thành Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 23/05/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của sách (lớp bussiness)
    */
    public class SachBUS
    {
        private SachDAL sachDal;

        public SachBUS()
        {
            sachDal = new SachDAL();
        }

        public bool Them(Sach sach)
        {
            bool re = sachDal.Them(sach);
            return re;
        }

        public bool Sua(Sach sach)
        {
            bool re = sachDal.Sua(sach);
            return re;
        }

        public bool Xoa(Sach sach)
        {
            bool re = sachDal.Xoa(sach);
            return re;
        }
    }
}
