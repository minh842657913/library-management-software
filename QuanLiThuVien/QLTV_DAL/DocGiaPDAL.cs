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
    public class DocGiaPDAL
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

        public DocGiaPDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DocGiaP> SelectAll()
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT [DOCGIA].[maDocGia], [hoTen]";
            strQuery += " FROM [DOCGIA], [THONGTINNO]";
            strQuery += " WHERE [DOCGIA].[maDocGia] = [THONGTINNO].[maDocGia]";

            List<DocGiaP> listDocGiaP = new List<DocGiaP>();

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
                            while (reader.Read())
                            {
                                DocGiaP docGiaP = new DocGiaP();

                                docGiaP.MaDocGia = reader["maDocGia"].ToString();
                                docGiaP.TenDocGia = reader["hoTen"].ToString();
                                docGiaP.StrMaVaTen = reader["maDocGia"].ToString() + " - " + reader["hoTen"].ToString();
                                listDocGiaP.Add(docGiaP);
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
            return listDocGiaP;
        }

        public bool UpdateTongNo(PhieuPhat infoDocGia)
        {
            string strQuery = String.Empty;
            strQuery += " UPDATE THONGTINNO SET [tongNo] = @conLai";
            strQuery += " WHERE [maDocGia] = @maDocGia";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@maDocGia", infoDocGia.MaDocGia);
                    cmd.Parameters.AddWithValue("@conLai", infoDocGia.ConLai);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
