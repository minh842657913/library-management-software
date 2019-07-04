using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class LoaiDocGia
    {
        string maLoaiDocGia;
        string loaiDG;

        public string MaLoaiDocGia
        {
            get
            {
                return maLoaiDocGia;
            }

            set
            {
                maLoaiDocGia = value;
            }
        }

        public string LoaiDG
        {
            get
            {
                return loaiDG;
            }

            set
            {
                loaiDG = value;
            }
        }
    }
}
