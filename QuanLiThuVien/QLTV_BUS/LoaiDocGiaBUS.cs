using QLTV_DAL;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class LoaiDocGiaBUS
    {
        private LoaiDocGiaDAL loaiDGDal;
        public LoaiDocGiaBUS()
        {
            loaiDGDal = new LoaiDocGiaDAL();
        }

        public List<LoaiDocGia> Select()
        {
            return loaiDGDal.Select();
        }
    }
}
