using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;

namespace QLVMBDAL
{
    public class DTTDAL
    {
        private string connectionString;
        public DTTDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Gọi Procedure
        public bool GoiProcAdd(int thang, int nam)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("proc_BaoCaoDoanhThuThang", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@thang", thang));
                    cmd.Parameters.Add(new SqlParameter("@nam", nam));
                    con.Open();
                    try
                    {
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

                return true;
            }
        }

        public bool GoiProcClear()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("proc_ClearThang", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

                return true;
            }
        }

        public List<DTTDTO> select(int thang, int nam)
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [DoanhThuTheoThang]";
            query += "WHERE ([Thang]=@thang)";
            query += "AND ([Nam]=@nam)";

            List<DTTDTO> lsChiTiet = new List<DTTDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DTTDTO dttt = new DTTDTO();
                                dttt.Thang = int.Parse(reader["Thang"].ToString());
                                dttt.Nam = int.Parse(reader["Nam"].ToString());
                                dttt.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                dttt.SoLuongVe = int.Parse(reader["SoLuongVe"].ToString());
                                dttt.DoanhThu = int.Parse(reader["DoanhThu"].ToString());
                                dttt.TiLe = float.Parse(reader["TiLe"].ToString());

                                lsChiTiet.Add(dttt);
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
            return lsChiTiet;
        }
    }
}
