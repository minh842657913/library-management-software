using System;
using QLTV_DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Thành Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 23/05/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của nhà xuất bản (lớp liên kết dữ liệu)
    */
    public class NhaXuatBanDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }

            set
            {
                connectionString = value;
            }
        }

        public NhaXuatBanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

    }
}
