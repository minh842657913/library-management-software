using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL taiKhoanDAL;
        public TaiKhoanBUS()
        {
            taiKhoanDAL = new TaiKhoanDAL();
        }

        public TaiKhoan Select()
        {
            return taiKhoanDAL.Select();
        }
    }
}
