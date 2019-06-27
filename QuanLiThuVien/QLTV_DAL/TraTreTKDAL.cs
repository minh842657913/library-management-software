using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;
using System.Data.SqlClient;

namespace QLTV_DAL
{
    public class TraTreTKDAL
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

        public TraTreTKDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<TraTreTK> Select(string strNamThangNgay)
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT [tenSach], [ngayMuon], [ngayTra], CONVERT(int,[ngayTra]) - CONVERT(int,[ngayMuon]) AS [soNgayMuon]";
            strQuery += " FROM [PHIEUMUON], [SACH], [PHIEUTRA]";
            strQuery += " WHERE [PHIEUMUON].[maSach] = [SACH].[maSach] AND [PHIEUMUON].[maPhieuMuon] = [PHIEUTRA].[maPhieuMuon]";
            strQuery += " AND [ngayTra] = @strNgayTra";

            List<TraTreTK> listTraTre = new List<TraTreTK>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@strNgayTra", strNamThangNgay);

                    try
                    {
                        //Mo ket noi
                        con.Open();

                        SqlDataReader reader = null;
                        //Thuc thi doan Query
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                
                                if (int.Parse(reader["soNgayMuon"].ToString()) > 90)
                                {
                                    TraTreTK traTreTK = new TraTreTK();
                                    traTreTK.Stt = count += 1;
                                    traTreTK.TenSach = reader["tenSach"].ToString();
                                    traTreTK.NgayMuon = reader["ngayMuon"].ToString();
                                    traTreTK.SoNgayTraTre = int.Parse(reader["soNgayMuon"].ToString()) - 90;

                                    listTraTre.Add(traTreTK);
                                }
                                else
                                {
                                    continue;
                                }
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
            return listTraTre;

        }
    }
}
