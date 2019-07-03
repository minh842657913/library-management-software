using System;
using QLTV_DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace QLTV_DAL
{
    /* 
    Program: Quản lí thư viện 
    Written by: Nguyễn Thành Luân
    Modified by: Nguyễn Thành Luân 
    Modified date: 23/05/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của tác giả (lớp liên kết dữ liệu)
    */
    public class TacGiaDAL
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

        public TacGiaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

    }
}
