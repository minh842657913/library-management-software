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
    public class DocGiaDAL
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

        public DocGiaDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool Them(DocGia dg)
        {
            string query = string.Empty;
            query += "INSERT INTO [DOCGiA] ([maDocGia], [hoTen], [diaChi], [email], [ngaySinh])";
            query += "VALUES (@maDocGia, @hoTen, @diaChi, @email, @ngaySinh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDocGia", dg.MaDocGia);
                    cmd.Parameters.AddWithValue("@hoTen", dg.HoTen);
                    cmd.Parameters.AddWithValue("@diaChi", dg.DiaChi);
                    cmd.Parameters.AddWithValue("@email", dg.Email);
                    cmd.Parameters.AddWithValue("@ngaySinh", dg.NgaySinh);
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

        public bool Sua(DocGia dg)
        {
            string query = string.Empty;
            query += "UPDATE DOCGIA SET [hoTen] = @hoTen, [diaChi] = @diaChi, [email] = @email, ";
            query += "[ngaySinh] = @ngaySinh WHERE[maDocGia] = @maDocGia";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDocGia", dg.MaDocGia);
                    cmd.Parameters.AddWithValue("@hoTen", dg.HoTen);
                    cmd.Parameters.AddWithValue("@diaChi", dg.DiaChi);
                    cmd.Parameters.AddWithValue("@email", dg.Email);
                    cmd.Parameters.AddWithValue("@ngaySinh", dg.NgaySinh);
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

        public bool Xoa(DocGia dg)
        {
            string query = string.Empty;
            query += "DELETE FROM [DOCGIA] WHERE [maDocGia] = @maDocGia";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDocGia", dg.MaDocGia);
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
