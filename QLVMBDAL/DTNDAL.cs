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
    public class DTNDAL
    {
        private string connectionString;
        public DTNDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Gọi Procedure
        public bool GoiProcAdd(int nam)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("proc_BaoCaoDoanhThuNam", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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


        public List<DTNDTO> select(int nam)
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [DoanhThuTheoNam]";
            query += "WHERE ([Nam]=@nam)";

            List<DTNDTO> lsChiTiet = new List<DTNDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
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
                                DTNDTO dtn = new DTNDTO();
                                dtn.Thang = int.Parse(reader["Thang"].ToString());
                                dtn.Nam = int.Parse(reader["Nam"].ToString());
                                dtn.SoChuyenBay = int.Parse(reader["SoChuyenBay"].ToString());
                                dtn.DoanhThu = int.Parse(reader["DoanhThu"].ToString());
                                dtn.TiLe = float.Parse(reader["TiLe"].ToString());

                                lsChiTiet.Add(dtn);
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