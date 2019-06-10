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
            query += "INSERT INTO [Ve] ([MaVe], [MaHanhKhach], [MaChuyenBay], [MaLoaiVe])";
            query += "VALUES (@MaVe,@MaHanhKhach,@MaChuyenBay,@MaLoaiVe)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaVe", vb.MaVe);
                    cmd.Parameters.AddWithValue("@MaHanhKhach", vb.MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", vb.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaLoaiVe", vb.MaLoaiVe);
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

        //Xoá chuyến bay
        public bool XoaChuyenBay(VBDTO cb)
        {
            //string query = string.Empty;
            //query += "DELETE FROM [LichChuyenBay] WHERE [MaChuyenBay] = @MaChuyenBay";
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        cmd.CommandText = query;
            //        cmd.Parameters.AddWithValue("@MaChuyenBay", cb.MaChuyenBay);
            //        try
            //        {
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //            con.Dispose();
            //        }
            //        catch (Exception ex)
            //        {
            //            con.Close();
            //            return false;
            //        }
            //    }
            //}
            return true;
        }

        //Sửa chuyến bay
        public bool SuaChuyenBay(VBDTO cb)
        {
            //string query = string.Empty;
            //query += "UPDATE [LichChuyenBay] SET [SanBayDi] = @SanBayDi, [SanBayDen] = @SanBayDen, [NgayGio] = @NgayGio, [ThoiGianBay] = @ThoiGianBay, [SoLuongGheHang1] = @SoLuongGheHang1, [SoLuongGheHang2] = @SoLuongGheHang2";
            //query += "WHERE [MaChuyenBay] = @MaChuyenBay";

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        cmd.CommandText = query;
            //        cmd.Parameters.AddWithValue("@MaChuyenBay", cb.MaChuyenBay);
            //        cmd.Parameters.AddWithValue("@SanBayDi", cb.SanBayDi);
            //        cmd.Parameters.AddWithValue("@SanBayDen", cb.SanBayDen);
            //        cmd.Parameters.AddWithValue("@NgayGio", cb.TGKhoiHanh);
            //        cmd.Parameters.AddWithValue("@ThoiGianBay", cb.TGBay);
            //        cmd.Parameters.AddWithValue("@SoLuongGheHang1", cb.SLGheHang1);
            //        cmd.Parameters.AddWithValue("@SoLuongGheHang2", cb.SLGheHang2);
            //        try
            //        {
            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //            con.Dispose();
            //        }
            //        catch (Exception ex)
            //        {
            //            con.Close();
            //            return false;
            //        }
            //    }
            //}
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

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                VBDTO vb = new VBDTO();
                                vb.MaVe = reader["MaVe"].ToString();
                                vb.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                vb.MaHanhKhach = reader["MaHanhKhach"].ToString();
                                vb.MaLoaiVe = reader["MaLoaiVe"].ToString();

                                lsVeBay.Add(vb);
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
            return lsVeBay;
        }
    }
}
