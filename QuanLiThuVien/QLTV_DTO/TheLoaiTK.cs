using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class TheLoaiTK
    {
        private int stt;
        private string tenTheLoai;
        private int soLuotMuon;
        private double tiLe;

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

        public string TenTheLoai
        {
            get
            {
                return tenTheLoai;
            }

            set
            {
                tenTheLoai = value;
            }
        }

        public int SoLuotMuon
        {
            get
            {
                return soLuotMuon;
            }

            set
            {
                soLuotMuon = value;
            }
        }

        public double TiLe
        {
            get
            {
                return tiLe;
            }

            set
            {
                tiLe = value;
                tiLe = Math.Round(tiLe, 2);
            }
        }
    }
}
