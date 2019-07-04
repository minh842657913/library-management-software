using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class LoaiSach
    {
        string maLoaiSach;
        string theLoai;

        public string MaLoaiSach
        {
            get
            {
                return maLoaiSach;
            }

            set
            {
                maLoaiSach = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return theLoai;
            }

            set
            {
                theLoai = value;
            }
        }
    }
}
