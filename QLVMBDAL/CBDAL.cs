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
    public class CBDAL  
    {
        private string connectionString;

        public CBDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Thêm chuyến bay
        public bool ThemChuyenBay(CBDTO cb)
        {
            string query = string.Empty;
            query += "INSERT INTO [LichChuyenBay] ([MaChuyenBay], [SanBayDi], [SanBayDen], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [SoLuongGheHang2], [GiaVe]) ";
            query += "VALUES (@MaChuyenBay,@SanBayDi,@SanBayDen,@NgayGio,@ThoiGianBay,@SoLuongGheHang1,@SoLuongGheHang2,@GiaVe) ";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", cb.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@SanBayDi", cb.SanBayDi);
                    cmd.Parameters.AddWithValue("@SanBayDen", cb.SanBayDen);
                    cmd.Parameters.AddWithValue("@NgayGio", cb.TGKhoiHanh);
                    cmd.Parameters.AddWithValue("@ThoiGianBay", cb.TGBay);
                    cmd.Parameters.AddWithValue("@SoLuongGheHang1", cb.SLGheHang1);
                    cmd.Parameters.AddWithValue("@SoLuongGheHang2", cb.SLGheHang2);
                    cmd.Parameters.AddWithValue("@GiaVe", cb.GiaVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        cb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        
        //Xoá chuyến bay
        public bool XoaChuyenBay(CBDTO cb)
        {
            string query = string.Empty;
            query += "DELETE FROM LichChuyenBay WHERE [MaChuyenBay] = @MaChuyenBay";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", cb.MaChuyenBay);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        cb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Sửa chuyến bay
        public bool SuaChuyenBay(CBDTO cb)
        {
            string query = string.Empty;
            query += "UPDATE [LichChuyenBay] SET [SanBayDi] = @SanBayDi, [SanBayDen] = @SanBayDen, [NgayGio] = @NgayGio, [ThoiGianBay] = @ThoiGianBay, [SoLuongGheHang1] = @SoLuongGheHang1, [SoLuongGheHang2] = @SoLuongGheHang2, [GiaVe] = @GiaVe ";
            query += "WHERE [MaChuyenBay] = @MaChuyenBay";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", cb.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@SanBayDi", cb.SanBayDi);
                    cmd.Parameters.AddWithValue("@SanBayDen", cb.SanBayDen);
                    cmd.Parameters.AddWithValue("@NgayGio", cb.TGKhoiHanh);
                    cmd.Parameters.AddWithValue("@ThoiGianBay", cb.TGBay);
                    cmd.Parameters.AddWithValue("@SoLuongGheHang1", cb.SLGheHang1);
                    cmd.Parameters.AddWithValue("@SoLuongGheHang2", cb.SLGheHang2);
                    cmd.Parameters.AddWithValue("@GiaVe", cb.GiaVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        cb.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<CBDTO> select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [LichChuyenBay]";

            List<CBDTO> lsChuyenBay = new List<CBDTO>();

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
                                CBDTO cb = new CBDTO();
                                cb.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                cb.SanBayDi = reader["SanBayDi"].ToString();
                                cb.SanBayDen = reader["SanBayDen"].ToString();
                                cb.TGKhoiHanh = reader["NgayGio"].ToString();
                                cb.TGBay = int.Parse(reader["ThoiGianBay"].ToString());
                                cb.SLGheHang1 = int.Parse(reader["SoLuongGheHang1"].ToString());
                                cb.SLGheHang2 = int.Parse(reader["SoLuongGheHang2"].ToString());
                                cb.GiaVe = int.Parse(reader["GiaVe"].ToString());

                                lsChuyenBay.Add(cb);
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

        public List<CBDTO> search(string valueDen, string valueDi)
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM [LichChuyenBay]";
            query += "WHERE ([SanBayDi]=@di)";
            query += "AND ([SanBayDen]=@den)";


            List<CBDTO> lsChuyenBay = new List<CBDTO>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@di", valueDi);
                    cmd.Parameters.AddWithValue("@den", valueDen);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CBDTO cb = new CBDTO();
                                cb.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                cb.SanBayDi = reader["SanBayDi"].ToString();
                                cb.SanBayDen = reader["SanBayDen"].ToString();
                                cb.TGKhoiHanh = reader["NgayGio"].ToString();
                                cb.TGBay = int.Parse(reader["ThoiGianBay"].ToString());
                                cb.SLGheHang1 = int.Parse(reader["SoLuongGheHang1"].ToString());
                                cb.SLGheHang2 = int.Parse(reader["SoLuongGheHang2"].ToString());
                                cb.GiaVe = int.Parse(reader["GiaVe"].ToString());

                                lsChuyenBay.Add(cb);
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
