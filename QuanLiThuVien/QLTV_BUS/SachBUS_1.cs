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
        private SachDAL saDal;

        public SachBUS()
        {
            saDal = new SachDAL();
        }

        public bool Them(Sach sa)
        {
            bool re = saDal.Them(sa);
            return re;
        }

        public bool Sua(Sach sa)
        {
            bool re = saDal.Sua(sa);
            return re;
        }

        public bool Xoa(Sach sa)
        {
            bool re = saDal.Xoa(sa);
            return re;
        }
    }
}
