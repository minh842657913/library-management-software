using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class TacGia
    {
        string maTacGia;
        string tenTacGia;

        public string MaTacGia
        {
            get
            {
                return maTacGia;
            }

            set
            {
                maTacGia = value;
            }
        }

        public string TenTacGia
        {
            get
            {
                return tenTacGia;
            }

            set
            {
                tenTacGia = value;
            }
        }
    }
}
