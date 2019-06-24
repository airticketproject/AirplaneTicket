using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using QLVMBDTO;

namespace QLVMBDAL
{
    public class PDVDAL
    {
        private string connectionString;

        public PDVDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool ThemPhieuDatVe(PDVDTO pd)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhieuDatVe] ([MaPhieuDat], [MaHanhKhach], [MaChuyenBay], [MaHangVe]) ";
            query += "VALUES (@MaPhieuDat,@MaHanhKhach,@MaChuyenBay,@MaHangVe)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHanhKhach", pd.MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", pd.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaPhieuDat", pd.MaPhieuDat);
                    cmd.Parameters.AddWithValue("@MaHangVe", pd.MaHangVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        pd.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public bool XoaPhieuDatVe(PDVDTO pd)
        {
            string query = string.Empty;
            query += "DELETE FROM [PhieuDatVe] WHERE [MaPhieuDat] = @MaPhieuDat";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", pd.MaPhieuDat);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        pd.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<PDVDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [PhieuDatVe]";

            List<PDVDTO> listPhieuDatVe = new List<PDVDTO>();

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
                                PDVDTO pd = new PDVDTO();
                                pd.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                pd.MaHanhKhach = reader["MaHanhKhach"].ToString();
                                pd.MaHangVe = reader["MaHangVe"].ToString();

                                listPhieuDatVe.Add(pd);
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
            return listPhieuDatVe;
        }
    }
}
