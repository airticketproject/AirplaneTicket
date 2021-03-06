﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;


namespace QLVMBDAL
{
    public class CTDAL
    {
        private string connectionString;

        public CTDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Thêm chuyến bay
        public bool ThemChiTietSanBay(CTDTO ct)
        {
            string query = string.Empty;
            query += "INSERT INTO [ChiTietSanBayTrungGian] ([MaChuyenBay], [MaSanBay], [ThoiGianDung], [GhiChu]) ";
            query += "VALUES (@MaChuyenBay,@MaSanBay,@ThoiGianDung,@GhiChu)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", ct.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaSanBay", ct.MaSanBay);
                    cmd.Parameters.AddWithValue("@ThoiGianDung", ct.TGDung);
                    cmd.Parameters.AddWithValue("@GhiChu", ct.GhiChu);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        ct.Error = ex.Message.Remove(0,65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Xoá chuyến bay
        public bool SuaChiTietSanBay(CTDTO ct)
        {
            string query = string.Empty;
            query += "UPDATE [ChiTietSanBayTrungGian] SET [ThoiGianDung] = @ThoiGianDung, [GhiChu] = @GhiChu WHERE [MaChuyenBay] = @MaChuyenBay and [MaSanBay] = @MaSanBay";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", ct.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaSanBay", ct.MaSanBay);
                    cmd.Parameters.AddWithValue("@ThoiGianDung", ct.TGDung);
                    cmd.Parameters.AddWithValue("@GhiChu", ct.GhiChu);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        ct.Error = ex.Message;
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        //Sửa chuyến bay
        public bool XoaChiTietSanBay(CTDTO ct)
        {
            string query = string.Empty;
            query += "DELETE FROM [ChiTietSanBayTrungGian] WHERE [MaChuyenBay] = @MaChuyenBay AND [MaSanBay] = @MaSanBay";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChuyenBay", ct.MaChuyenBay);
                    cmd.Parameters.AddWithValue("@MaSanBay", ct.MaSanBay);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        ct.Error = ex.Message;
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<CTDTO> select()
        {
            string query = string.Empty;
            //query += "SELECT MaChuyenBay, sb.TenSanBay, ThoiGianDung, GhiChu ";
            //query += "From ChiTietSanBayTrungGian ct, SanBay sb ";
            //query += "Where ct.MaSanBay = sb.MaSanBay ";
            query += "SELECT * From [ChiTietSanBayTrungGian]";
            List<CTDTO> lsChiTiet = new List<CTDTO>();

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
                                CTDTO cttg = new CTDTO();
                                cttg.MaChuyenBay = reader["MaChuyenBay"].ToString();
                                cttg.MaSanBay = reader["MaSanBay"].ToString();
                                cttg.TGDung = int.Parse(reader["ThoiGianDung"].ToString());
                                cttg.GhiChu = reader["GhiChu"].ToString();

                                lsChiTiet.Add(cttg);
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
