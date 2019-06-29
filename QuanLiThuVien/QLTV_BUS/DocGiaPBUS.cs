using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;
using QLTV_DAL;

namespace QLTV_BUS
{
    public class DocGiaPBUS
    {
        private DocGiaPDAL docGiaPDAL;

        public DocGiaPBUS()
        {
            docGiaPDAL = new DocGiaPDAL();
        }

        public List<DocGiaP> SelectAll()
        {
            return docGiaPDAL.SelectAll();
        }

        public bool UpdateTongNo(PhieuPhat infoDocGia)
        {
            return docGiaPDAL.UpdateTongNo(infoDocGia);
        }
    }
}
