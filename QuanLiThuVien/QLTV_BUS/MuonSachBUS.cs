using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class MuonSachBUS
    {
        private MuonSachDAL msDAL;
        public MuonSachBUS()
        {
            msDAL = new MuonSachDAL();
        }
        public List<MuonSachDTO> select()
        {
            return msDAL.select();
        }
    }
}
