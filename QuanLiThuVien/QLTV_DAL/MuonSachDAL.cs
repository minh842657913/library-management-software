using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAL
{
    public class MuonSachDAL
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
        public MuonSachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<MuonSachDTO> select()
        {
            string query = string.Empty;
            query += "SELECT PHIEUMUON.maSach,SACH.tenSach";            
            query += "FROM PHIEUMUON,SACH";
            query += "where PHIEUMUON.maSach=SACH.maSach";

            List<MuonSachDTO> lsMuonSach = new List<MuonSachDTO>();

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
                                MuonSachDTO ms = new MuonSachDTO();
                                ms.MaSach = reader["maSach"].ToString();
                                ms.TenSach = reader["tenSach"].ToString();
                                lsMuonSach.Add(ms);
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
            return lsMuonSach;
        }

    }
}
