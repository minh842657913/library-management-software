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
    Modified date: 24/06/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của loại sách (lớp liên kết dữ liệu)
    */
    public class LoaiSachDAL
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

        public LoaiSachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<LoaiSach> Select()
        {
            string query = string.Empty;
            query += "SELECT [maLoaiSach], [theLoai]";
            query += "FROM [LOAISACH]";

            List<LoaiSach> listLoaiSach = new List<LoaiSach>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                LoaiSach loaiSach = new LoaiSach();
                                loaiSach.MaLoaiSach = reader["maLoaiSach"].ToString();
                                loaiSach.TheLoai = reader["theLoai"].ToString();                             
                                listLoaiSach.Add(loaiSach);
                            }
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
            return listLoaiSach;
        }

    }
}
