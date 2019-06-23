using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using System.Configuration;


namespace QLVMBDAL
{
    public class HVDAL
    {
        private string connectionString;

        public HVDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Thêm hạng vé
        public bool ThemHangVe(HVDTO hv)
        {
            string query = string.Empty;
            query += "INSERT INTO [HangVe] ([MaHangVe], [TenHangVe], [TiLeDonGia]) ";
            query += "VALUES (@MaHangVe,@TenHangVe,@TiLeDonGia)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHangVe", hv.MaHangVe);
                    cmd.Parameters.AddWithValue("@TenHangVe", hv.TenHangVe);
                    cmd.Parameters.AddWithValue("@TiLeDonGia", hv.TiLeDonGia);
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

        //Xoá hạng vé
        public bool XoaHangVe(HVDTO hv)
        {
            string query = string.Empty;
            query += "DELETE FROM [HangVe] WHERE MaHangVe = @MaHangVe";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHangVe", hv.MaHangVe);
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

        //Sửa hạng vé
        public bool SuaHangVe(HVDTO hv)
        {
            string query = string.Empty;
            query += "UPDATE [HangVe] SET [TenHangVe] = @TenHangVe, [TiLeDonGia] = @TiLeDonGia ";
            query += "WHERE [MaHangVe] = @MaHangVe";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHangVe", hv.MaHangVe);
                    cmd.Parameters.AddWithValue("@TenHangVe", hv.TenHangVe);
                    cmd.Parameters.AddWithValue("@TiLeDonGia", hv.TiLeDonGia);
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

        public List<HVDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [HangVe]";

            List<HVDTO> lsHangVe = new List<HVDTO>();

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
                                HVDTO hv = new HVDTO();
                                hv.MaHangVe = reader["MaHangVe"].ToString();
                                hv.TenHangVe = reader["TenHangVe"].ToString();
                                hv.TiLeDonGia = float.Parse(reader["TiLeDonGia"].ToString());

                                lsHangVe.Add(hv);
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
            return lsHangVe;
        }

    }
}
