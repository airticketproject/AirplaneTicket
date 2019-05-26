using System;
using QLVMBDTO;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDAL
{
    public class KHDAL
    {

        private string connectionString;

        public KHDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool ThemKhachHang(KHDTO kh)
        {
            string query = string.Empty;
            query += "INSERT INTO [HanhKhach] ([MaHanhKhach], [TenHanhKhach], [CMND], [DienThoai])";
            query += "VALUES (@MaHanhKhach, @TenHanhKhach, @CMND, @DienThoai)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHanhKhach", kh.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenHanhKhach", kh.TenKhachHang);
                    cmd.Parameters.AddWithValue("@CMND", kh.cmndKhachHang);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.SDT);
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
        public bool SuaKhachHang(KHDTO kh)
        {
            string query = string.Empty;
            query += "UPDATE [HanhKhach] SET [TenHanhKhach] = @TenHanhKhach, [CMND] = @CMND, [DienThoai] = @DienThoai where [MaHanhKhach] = @MaHanhKhach";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHanhKhach", kh.MaKhachHang);
                    cmd.Parameters.AddWithValue("@TenHanhKhach", kh.TenKhachHang);
                    cmd.Parameters.AddWithValue("@CMND", kh.cmndKhachHang);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.SDT);
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
        public bool XoaKhachHang(KHDTO kh)
        {
            string query = string.Empty;
            query += "DELETE FROM [HanhKhach] where [MaHanhKhach] = @MaHanhKhach";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHanhKhach", kh.MaKhachHang);
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

        public List<KHDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaHanhKhach], [TenHanhKhach], [CMND], [DienThoai]";
            query += "FROM [HanhKhach]";

            List<KHDTO> lsKhachHang = new List<KHDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
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
                                KHDTO kh = new KHDTO();
                                kh.MaKhachHang = reader["MaHanhKhach"].ToString();
                                kh.TenKhachHang = reader["TenHanhKhach"].ToString();
                                kh.cmndKhachHang = reader["CMND"].ToString();
                                kh.SDT = reader["DienThoai"].ToString();
                                lsKhachHang.Add(kh);
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
            return lsKhachHang;
        }
    }
}
