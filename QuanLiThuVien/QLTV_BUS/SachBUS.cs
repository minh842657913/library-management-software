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
        //---------

        private SachDAL sachDAL;

        public SachBUS()
        {
            sachDAL = new SachDAL();

        }

        public bool Them(Sach sach)
        {
            bool re = sachDAL.Them(sach);

            return re;
        }

        public bool Sua(Sach sach)
        {
            bool re = sachDAL.Sua(sach);

            return re;
        }

        public bool Xoa(Sach sach)
        {
            bool re = sachDAL.Xoa(sach);

            return re;
        }

        public List<Sach> Select()
        {
            return sachDAL.Select();
        }

        public List<Sach> SelectByKeyword(string strTuKhoa)
        {
            return sachDAL.SelectByKeyword(strTuKhoa);
        }

        public List<Sach> TaiDuLieu()
        {
            return sachDAL.TaiDuLieu();
        }
    }
}
