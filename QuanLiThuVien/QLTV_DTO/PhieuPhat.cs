using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class PhieuPhat
    {
        string maDocGia;
        string tenDocGia;
        float tongNo;
        float conLai;

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

        public float TongNo
        {
            get
            {
                return tongNo;
            }

            set
            {
                tongNo = value;
            }
        }

        public float ConLai
        {
            get
            {
                return conLai;
            }

            set
            {
                conLai = value;
            }
        }
    }
}
