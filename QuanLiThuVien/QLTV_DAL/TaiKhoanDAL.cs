using System;
using QLTV_DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class TaiKhoanDAL
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

        public TaiKhoanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public TaiKhoan Select()
        {
            string strQuery = string.Empty;
            strQuery += " SELECT [maTaiKhoan],[tenTaiKhoan], [matKhau] FROM TAIKHOAN ";
            TaiKhoan taiKhoan = new TaiKhoan();


            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            reader.Read();
                            taiKhoan.TenTaiKhoan = reader["tenTaiKhoan"].ToString();
                            taiKhoan.MatKhau = reader["matKhau"].ToString();                            
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return taiKhoan;
        }
    }
}
