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

            List<LoaiSach> lsLoaiSach = new List<LoaiSach>();

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
                                LoaiSach lSa = new LoaiSach();
                                lSa.MaLoaiSach = reader["maLoaiSach"].ToString();
                                lSa.TheLoai = reader["theLoai"].ToString();                             
                                lsLoaiSach.Add(lSa);
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
            return lsLoaiSach;
        }

    }
}
