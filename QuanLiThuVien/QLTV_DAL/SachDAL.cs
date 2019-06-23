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
    Modified date: 22/06/2019
    Description: Class mô tả các thuộc tính phương thức cần thiết của sách (lớp liên kết dữ liệu)
    */
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
            query += "INSERT INTO [SACH] ([maSach], [tenSach], [maLoaiSach], [maTacGia], [namXuatBan], [maNXB], [ngayNhap], [triGia])";
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
                    cmd.Parameters.AddWithValue("@maLoaiSach", sach.LoaiSach);
                    cmd.Parameters.AddWithValue("@maTacGia", sach.MaTacGia);
                    cmd.Parameters.AddWithValue("@namXuatBan", sach.NamXuatBan);
                    cmd.Parameters.AddWithValue("@maNXB", sach.MaNhaXuatBan);
                    cmd.Parameters.AddWithValue("@ngayNhap", sach.NgayNhap);
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
                    cmd.Parameters.AddWithValue("@maLoaiSach", sach.LoaiSach);
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
    }
}