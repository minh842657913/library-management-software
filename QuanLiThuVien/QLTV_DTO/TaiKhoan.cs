using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class TaiKhoan
    {
        string tenTaiKhoan;
        string matKhau;

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public Boolean equals(TaiKhoan obj)
        {
            if (this.tenTaiKhoan.Equals(obj.tenTaiKhoan) && this.matKhau.Equals(obj.matKhau))
                return true;
            return false;
        }
    }
}
