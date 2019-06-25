using System;
using QLVMBDTO;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDAL
{
    public class DSDAL
    {
        private string connectionString;

        public DSDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DSDTO> select()
        {
            string query = string.Empty;
            query += "SELECT a.MaChuyenBay, a.SanBayDi, a.SanBayDen, a.NgayGio, a.ThoiGianBay, b.SoGheTrong, b.SoGheDaDat ";
            query += "FROM LichChuyenBay a, DanhSachChuyenBay b ";
            query += "WHERE a.MaChuyenBay = b.MaChuyenBay";
            List<DSDTO> lsChuyenBay = new List<DSDTO>();

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
                                DSDTO ds = new DSDTO();
                                ds.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                ds.SanBayDi = reader["SanBayDi"].ToString();
                                ds.SanBayDen = reader["SanBayDen"].ToString();
                                ds.TGKhoiHanh = reader["NgayGio"].ToString();
                                ds.TGBay = int.Parse(reader["ThoiGianBay"].ToString());
                                ds.SoGheTrong = int.Parse(reader["SoGheTrong"].ToString());
                                ds.SoGheDaDat = int.Parse(reader["SoGheDaDat"].ToString());

                                lsChuyenBay.Add(ds);
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
            return lsChuyenBay;
        }
    }
}
