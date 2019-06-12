using System;
using QLTV_DAL;
using QLTV_DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class LoaiSachBUS
    {
        private LoaiSachDAL loaiSDal;
        public LoaiSachBUS()
        {
            loaiSDal = new LoaiSachDAL();
        }
        //public bool Them(Sach loaiS)
        //{
        //    bool re = loaiSDal.Them(loaiS);
        //    return re;
        //}

        public List<LoaiSach> Select()
        {
            return loaiSDal.Select();
        }
    }
}
