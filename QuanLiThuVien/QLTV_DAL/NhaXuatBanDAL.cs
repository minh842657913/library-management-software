using System;
using QLTV_DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
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
