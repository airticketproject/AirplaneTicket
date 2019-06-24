using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDAL;
using QLVMBDTO;
using System.Data.SqlClient;
using System.Configuration;


namespace QLVMBDAL
{
    public class VBDAL
    {
        private string connectionString;

        public VBDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Thêm chuyến bay
        public bool ThemVeBay(VBDTO vb)
        {
            string query = string.Empty;
            query += "INSERT INTO [Ve] ([MaVe], [MaHanhKhach], [MaChuyenBay], [MaHangVe]) ";
            query += "VALUES (@MaVe,@MaHanhKhach,@MaChuyenBay,@MaHangVe)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHanhKhach", vb.MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", vb.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaHangVe", vb.MaHangVe);
                    cmd.Parameters.AddWithValue("@MaVe", vb.MaVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        vb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Xoá chuyến bay
        public bool XoaVeBay(VBDTO vb)
        {
            string query = string.Empty;
            query += "DELETE FROM [Ve] WHERE [MaVe] = @MaVe";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaVe", vb.MaVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        vb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<VBDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [VE]";

            List<VBDTO> lsVeBay = new List<VBDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    VBDTO vb = new VBDTO();

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                vb.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                vb.MaHanhKhach = reader["MaHanhKhach"].ToString();
                                vb.MaHangVe = reader["MaHangVe"].ToString();

                                lsVeBay.Add(vb);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        vb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return null;
                    }
                }
            }
            return lsVeBay;
        }
    }

}

