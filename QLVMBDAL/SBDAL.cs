using QLVMBDTO;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDAL
{
    public class SBDAL
    {
        private string connectionString;

        public SBDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        
        //Thêm sân bay
        public bool ThemSanBay(SBDTO sb)
        {
            string query = string.Empty;
            query += "INSERT INTO [SanBay] ([MaSanBay], [TenSanBay]) ";
            query += "VALUES (@MaSanBay, @TenSanBay)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSanBay", sb.MaSanBay);
                    cmd.Parameters.AddWithValue("@TenSanBay", sb.TenSanBay);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        sb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Sửa sân bay
        public bool SuaSanBay(SBDTO sb)
        {
            string query = string.Empty;
            query += "UPDATE [SanBay] SET [TenSanBay] = @TenSanBay WHERE [MaSanBay] = @MaSanBay";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSanBay", sb.MaSanBay);
                    cmd.Parameters.AddWithValue("@TenSanBay", sb.TenSanBay);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        sb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Xoá sân bay
        public bool XoaSanBay(SBDTO sb)
        {
            string query = string.Empty;
            query += "DELETE FROM [SanBay] WHERE [MaSanBay] = @MaSanBay";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand()) 
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSanBay", sb.MaSanBay);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        sb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<SBDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [SanBay]";

            List<SBDTO> lsSanBay = new List<SBDTO>();

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
                                SBDTO sb = new SBDTO();
                                sb.TenSanBay = reader["TenSanBay"].ToString();
                                sb.MaSanBay = reader["MaSanBay"].ToString();
                                lsSanBay.Add(sb);
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
            return lsSanBay;
        }
    }
}
