using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class TraTreTK
    {
        private int stt;
        private string tenSach;
        private string ngayMuon;
        private int soNgayTraTre;

        public int Stt
        {
            get
            {
                return stt;
            }

            set
            {
                stt = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public string NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public int SoNgayTraTre
        {
            get
            {
                return soNgayTraTre;
            }

            set
            {
                soNgayTraTre = value;
            }
        }
    }
}
