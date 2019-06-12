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

        public bool Them(Sach sa)
        {
            string query = string.Empty;
            query += "INSERT INTO [SACH] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [maNXB], [ngayNhap], [triGia])";
            query += "VALUES (@maSach, @tenSach, @maLoaiSach, @maTacGia, @namXuatBan, @maNXB, @ngayNhap, @triGia)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSach", sa.MaSach);
                    cmd.Parameters.AddWithValue("@tenSach", sa.TenSach);
                    cmd.Parameters.AddWithValue("@maLoaiSach", sa.LoaiSach);
                    cmd.Parameters.AddWithValue("@maTacGia", sa.MaTacGia);
                    cmd.Parameters.AddWithValue("@namXuatBan", sa.NamXuatBan);
                    cmd.Parameters.AddWithValue("@maNXB", sa.MaNhaXuatBan);
                    cmd.Parameters.AddWithValue("@ngayNhap", sa.NgayNhap);
                    cmd.Parameters.AddWithValue("@triGia", sa.TriGia);
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

        public bool Sua(Sach sa)
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
                    cmd.Parameters.AddWithValue("@maSach", sa.MaSach);
                    cmd.Parameters.AddWithValue("@tenSach", sa.TenSach);
                    cmd.Parameters.AddWithValue("@maLoaiSach", sa.LoaiSach);
                    cmd.Parameters.AddWithValue("@maTacGia", sa.MaTacGia);
                    cmd.Parameters.AddWithValue("@namXuatBan", sa.NamXuatBan);
                    cmd.Parameters.AddWithValue("@maNXB", sa.MaNhaXuatBan);
                    cmd.Parameters.AddWithValue("@triGia", sa.TriGia);
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

        public bool Xoa(Sach sa)
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
                    cmd.Parameters.AddWithValue("@maSach", sa.MaSach);
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