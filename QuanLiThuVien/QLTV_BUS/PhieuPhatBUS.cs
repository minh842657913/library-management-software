using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class PhieuPhatBUS
    {
        private PhieuPhatDAL phieuPhatDAL;

        public PhieuPhatBUS()
        {
            phieuPhatDAL = new PhieuPhatDAL();
        }

        public PhieuPhat Select(string strMaDocGia)
        {
            return phieuPhatDAL.Select(strMaDocGia);
        }
    }
}
