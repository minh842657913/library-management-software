using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class DocGiaP
    {
        string maDocGia;
        string tenDocGia;
        string strMaVaTen;

        public string MaDocGia
        {
            get
            {
                return maDocGia;
            }

            set
            {
                maDocGia = value;
            }
        }

        public string TenDocGia
        {
            get
            {
                return tenDocGia;
            }

            set
            {
                tenDocGia = value;
            }
        }

        public string StrMaVaTen
        {
            get
            {
                return strMaVaTen;
            }

            set
            {
                strMaVaTen = value;
            }
        }
    }
}
