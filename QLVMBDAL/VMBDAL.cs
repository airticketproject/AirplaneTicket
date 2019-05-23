using System;
using QLVMBDTO;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDAL
{
    public class VMBDAL  
    {
        private string connectionString;

        public VMBDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }


        public bool ThemChuyenBay(VMBDTO cb)
        {
            string query = string.Empty;
            query += "INSERT INTO [LichChuyenBay] ([MaChuyenBay], [SanBayDi], [SanBayDen], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [SoLuongGheHang2])";
            query += "VALUES (@MaChuyenBay,@SanBayDi,@SanBayDen,@NgayGio,@ThoiGianBay,@SoLuongGheHang1,@SoLuongGheHang2)";
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

        public bool XoaChuyenBay(VMBDTO cb)
        {
            //string query = string.Empty;
            //query += "DELETE FROM [tblKieuNau] WHERE [maKieuNau] = @maKieuNau";
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        cmd.CommandText = query;
            //        cmd.Parameters.AddWithValue("@maKieuNau", kn.Ma);
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

        public bool SuaChuyenBay(VMBDTO cb)
        {
            //string query = string.Empty;
            //query += "UPDATE [tblKieuNau] SET [tenKieuNau] = @tenKieuNau, [mota] = @mota WHERE [maKieuNau] = @maKieuNau";
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = con;
            //        cmd.CommandType = System.Data.CommandType.Text;
            //        cmd.CommandText = query;
            //        cmd.Parameters.AddWithValue("@maKieuNau", cb.Ma);
            //        cmd.Parameters.AddWithValue("@tenKieuNau", cb.Ten);
            //        cmd.Parameters.AddWithValue("@mota", cb.Mota);
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

        public List<VMBDTO> select()
        {
            return null;
        }
    }
}
