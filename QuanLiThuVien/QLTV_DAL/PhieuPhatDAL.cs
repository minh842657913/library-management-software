using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using QLTV_DTO;

namespace QLTV_DAL
{
    public class PhieuPhatDAL
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

        public PhieuPhatDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public PhieuPhat Select(string strMaDocGia)
        {
            string strQuery = string.Empty;
            strQuery += " SELECT [DOCGIA].[maDocGia], [hoTen], [tongNo]";
            strQuery += " FROM [THONGTINNO], [DOCGIA]";
            strQuery += " WHERE ([DOCGIA].[maDocGia] = [THONGTINNO].[maDocGia] AND [DOCGIA].[maDocGia] = @maDocGia)";

            PhieuPhat phieuPhat = new PhieuPhat();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@maDocGia", strMaDocGia);

                    try
                    {
                        //Mo ket noi
                        con.Open();

                        SqlDataReader reader = null;
                        //Thuc thi doan Query
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                phieuPhat.MaDocGia = reader["maDocGia"].ToString();
                                phieuPhat.TongNo = float.Parse(reader["tongNo"].ToString());
                                phieuPhat.TenDocGia = reader["hoTen"].ToString();
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
            return phieuPhat;
        }
    }
}
