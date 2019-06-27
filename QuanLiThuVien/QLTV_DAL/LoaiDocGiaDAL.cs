using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class LoaiDocGiaDAL
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

        public LoaiDocGiaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<QLTV_DTO.LoaiDocGia> Select()
        {
            string query = string.Empty;
            query += "SELECT [maLoaiDG], [loaiDG]";
            query += "FROM [LOAIDOCGIA]";

            List<LoaiDocGia> lsLoaiDocGia = new List<LoaiDocGia>();

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
                                LoaiDocGia lSa = new LoaiDocGia();
                                lSa.MaLoaiDocGia = reader["maLoaiDG"].ToString();
                                lSa.LoaiDG = reader["loaiDG"].ToString();
                                lsLoaiDocGia.Add(lSa);
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
            return lsLoaiDocGia;
        }

        public static implicit operator LoaiDocGiaDAL(LoaiSachDAL v)
        {
            throw new NotImplementedException();
        }
    }
}

