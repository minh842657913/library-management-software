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
    public class SachDAL
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

        public SachDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool Them(Sach sach)
        {
            string query = string.Empty;
            query += "INSERT INTO [SACH] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [maNXB], [ngayNhap], [soLuongTon], [triGia])";
            query += "VALUES (@maSach, @tenSach, @maLoaiSach, @maTacGia, @namXuatBan, @maNXB, @ngayNhap, @triGia)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSach", sach.MaSach);
                    cmd.Parameters.AddWithValue("@tenSach", sach.TenSach);
                    cmd.Parameters.AddWithValue("@maLoaiSach", sach.MaLoaiSach);
                    cmd.Parameters.AddWithValue("@maTacGia", sach.MaTacGia);
                    cmd.Parameters.AddWithValue("@namXuatBan", sach.NamXuatBan);
                    cmd.Parameters.AddWithValue("@maNXB", sach.MaNhaXuatBan);
                    cmd.Parameters.AddWithValue("@ngayNhap", sach.NgayNhap);
                    cmd.Parameters.AddWithValue("@soLuongTon", sach.SoLuongTon);
                    cmd.Parameters.AddWithValue("@triGia", sach.TriGia);
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

        public bool Sua(Sach sach)
        {
            string query = string.Empty;
            query += "UPDATE SACH SET [tenSach] = @tenSach, [maLoaiSach] = @maLoaiSach, [maTacGia] = @maTacGia, [namXuatBan] = @namXuatBan, ";
            query += "[maNXB] = @maNXB, [triGia] = @triGia WHERE[maSach] = @maSach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSach", sach.MaSach);
                    cmd.Parameters.AddWithValue("@tenSach", sach.TenSach);
                    cmd.Parameters.AddWithValue("@maLoaiSach", sach.MaLoaiSach);
                    cmd.Parameters.AddWithValue("@maTacGia", sach.MaTacGia);
                    cmd.Parameters.AddWithValue("@namXuatBan", sach.NamXuatBan);
                    cmd.Parameters.AddWithValue("@maNXB", sach.MaNhaXuatBan);
                    cmd.Parameters.AddWithValue("@triGia", sach.TriGia);
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

        public bool Xoa(Sach sach)
        {
            string query = string.Empty;
            query += "DELETE FROM [SACH] WHERE [maSach] = @maSach";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSach", sach.MaSach);
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

        public List<Sach> Select()
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT [maSach], [tenSach], [LOAISACH].[theLoai], [TACGIA].[tentacGia], [namXuatBan], [NHAXUATBAN].[tenNXB], [ngayNhap],";
            strQuery += " [soLuongTon], [triGia]";
            strQuery += " FROM [SACH], [LOAISACH], [TACGIA], [NHAXUATBAN]";
            strQuery += " WHERE ([LOAISACH].[maLoaiSach] = [SACH].[maLoaiSach] AND [TACGIA].[maTacGia] = [SACH].[maTacGia] AND";
            strQuery += " [NHAXUATBAN].[maNXB] = [SACH].[maNXB])";

            List<Sach> listSach = new List<Sach>();

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

                        if(reader.HasRows == true)
                        {
                            while(reader.Read())
                            {
                                Sach sach = new Sach();
                                sach.MaSach = reader["maSach"].ToString();
                                sach.TenSach = reader["tenSach"].ToString();
                                sach.LoaiSach = reader["theLoai"].ToString();
                                sach.TacGia = reader["tenTacGia"].ToString();
                                sach.NamXuatBan = int.Parse(reader["namXuatBan"].ToString());
                                sach.NhaXuatBan = reader["tenNXB"].ToString();
                                sach.NgayNhap = reader["ngayNhap"].ToString();
                                sach.SoLuongTon = int.Parse(reader["soLuongTon"].ToString());
                                sach.TriGia = double.Parse(reader["triGia"].ToString());

                                listSach.Add(sach); 
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listSach;
        }

        public List<Sach> SelectByKeyword(string strTuKhoa)
        {
            //Tao cau truy van
            string strQuery = string.Empty;
            strQuery += " SELECT [maSach], [tenSach], [LOAISACH].[theLoai], [TACGIA].[tenTacGia], [namXuatBan], [NHAXUATBAN].[tenNXB], [ngayNhap],";
            strQuery += " [soLuongTon], [triGia]";
            strQuery += " FROM [SACH], [LOAISACH], [TACGIA], [NHAXUATBAN]";
            strQuery += " WHERE ([LOAISACH].[maLoaiSach] = [SACH].[maLoaiSach] AND [TACGIA].[maTacGia] = [SACH].[maTacGia] AND";
            strQuery += " [NHAXUATBAN].[maNXB] = [SACH].[maNXB])";

            strQuery += " AND (([maSach] LIKE CONCAT('%',@strTuKhoa,'%'))";
            strQuery += " OR ([tenSach] LIKE CONCAT('%',@strTuKhoa,'%'))";
            strQuery += " OR ([tenTacGia] LIKE CONCAT('%',@strTuKhoa,'%')))";

            List<Sach> listSach = new List<Sach>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@strTuKhoa", strTuKhoa);

                    try
                    {
                        //Mo ket noi
                        con.Open();

                        SqlDataReader reader = null;
                        //Thuc thi doan Query
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while(reader.Read())
                            {
                                Sach sach = new Sach();
                                sach.MaSach = reader["maSach"].ToString();
                                sach.TenSach = reader["tenSach"].ToString();
                                sach.LoaiSach = reader["theLoai"].ToString();
                                sach.TacGia = reader["tenTacGia"].ToString();
                                sach.NamXuatBan = int.Parse(reader["namXuatBan"].ToString());
                                sach.NhaXuatBan = reader["tenNXB"].ToString();
                                sach.NgayNhap = reader["ngayNhap"].ToString();
                                sach.SoLuongTon = int.Parse(reader["soLuongTon"].ToString());
                                sach.TriGia = double.Parse(reader["triGia"].ToString());

                                listSach.Add(sach);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listSach;

        }
    }
}