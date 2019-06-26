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
    public class TheLoaiTKDAL
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

        public TheLoaiTKDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public int SelectSum(string[] strThangNam)
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT COUNT(*) AS [tongLuotMuon]";
            strQuery += " FROM [LOAISACH], [PHIEUMUON], [SACH]";
            strQuery += " WHERE ([PHIEUMUON].[maSach] = [SACH].[maSach] AND [SACH].[maLoaiSach] = [LOAISACH].[maLoaiSach]";
            strQuery += " AND MONTH([ngayMuon]) = @ThangTK AND YEAR([ngayMuon]) = @NamTK)";

            int intTongLuotMuon = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@ThangTK", strThangNam[0]);
                    cmd.Parameters.AddWithValue("@NamTK", strThangNam[1]);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                intTongLuotMuon = int.Parse(reader["tongLuotMuon"].ToString());
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                        return 1;
                    }
                }
            }
            return intTongLuotMuon;
        }

        public List<TheLoaiTK> Select(string[] strThangNam, int intTongLuotMuon)
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT [LOAISACH].[theLoai], COUNT([theLoai]) AS soLuotMuon";
            strQuery += " FROM [LOAISACH], [PHIEUMUON], [SACH]";
            strQuery += " WHERE ([PHIEUMUON].[maSach] = [SACH].[maSach] AND [SACH].[maLoaiSach] = [LOAISACH].[maLoaiSach]";
            strQuery += " AND MONTH([ngayMuon]) = @ThangTK AND YEAR([ngayMuon]) = @NamTK)";
            strQuery += " GROUP BY [theLoai]";

            List<TheLoaiTK> listTheLoai = new List<TheLoaiTK>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@ThangTK", strThangNam[0]);
                    cmd.Parameters.AddWithValue("@NamTK", strThangNam[1]);

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
                                TheLoaiTK theLoaiTK = new TheLoaiTK();
                                theLoaiTK.Stt = count += 1;
                                theLoaiTK.TenTheLoai = reader["theLoai"].ToString();
                                theLoaiTK.SoLuotMuon = int.Parse(reader["soLuotMuon"].ToString());
                                theLoaiTK.TiLe = int.Parse(reader["soLuotMuon"].ToString()) * 100 / (double)intTongLuotMuon;
                                listTheLoai.Add(theLoaiTK);
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
            return listTheLoai;

        }
    }
}
