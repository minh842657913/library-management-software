using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class SachBUS
    {
        //---------

        private SachDAL sachDAL;

        public SachBUS()
        {
            sachDAL = new SachDAL();
        }

        public bool Them(Sach sa)
        {
            bool re = sachDAL.Them(sa);
            return re;
        }

        public bool Sua(Sach sa)
        {
            bool re = sachDAL.Sua(sa);
            return re;
        }

        public bool Xoa(Sach sa)
        {
            bool re = sachDAL.Xoa(sa);
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
    }
}
