using QLTV_DAL;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAL dgDal;

        public DocGiaBUS()
        {
            dgDal = new DocGiaDAL();
        }

        public bool Them(DocGia dg)
        {
            bool re = dgDal.Them(dg);
            return re;
        }

        public bool Sua(DocGia dg)
        {
            bool re = dgDal.Sua(dg);
            return re;
        }

        public bool Xoa(DocGia dg)
        {
            bool re = dgDal.Xoa(dg);
            return re;
        }
    }
}
