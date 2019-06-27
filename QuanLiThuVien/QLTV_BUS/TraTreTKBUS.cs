using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class TraTreTKBUS
    {
        private TraTreTKDAL tk_TraTreDAL;
        public TraTreTKBUS()
        {
            tk_TraTreDAL = new TraTreTKDAL();
        }

        public List<TraTreTK> Select(string strNamThangNgay)
        {
            return tk_TraTreDAL.Select(strNamThangNgay);
        }
    }
}
