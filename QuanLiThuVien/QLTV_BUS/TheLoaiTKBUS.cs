using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class TheLoaiTKBUS
    {
        private TheLoaiTKDAL theLoaiDAL;

        public TheLoaiTKBUS()
        {
            theLoaiDAL = new TheLoaiTKDAL();
        }

        public List<TheLoaiTK> Select(string[] strThangNam, int intTongLuotMuon)
        {
            return theLoaiDAL.Select(strThangNam, intTongLuotMuon);
        }

        public int SelectSum(string[] strThangNam)
        {
            return theLoaiDAL.SelectSum(strThangNam);
        }
    }
}
