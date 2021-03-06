﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using QLVMBDTO;

namespace QLVMBDAL
{
    public class TSDAL
    {
        private string connectionString;

        public TSDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //Cập nhật tham số
        public bool CapNhatThamSo(TSDTO ts)
        {
            string query = string.Empty;
            query += "UPDATE [ThamSo] SET ";
            query += "[ThoiGianBayToiThieu] = @ThoiGianBayToiThieu, [SoLuongSanBayTrungGianToiDa] = @SoLuongSanBayTrungGianToiDa, ";
            query += "[ThoiGianDungToiDa] = @ThoiGianDungToiDa, [ThoiGianDungToiThieu] = @ThoiGianDungToiThieu, ";
            query += "[ThoiGianChamNhatKhiDatVe] = @ThoiGianChamNhatKhiDatVe, [ThoiGianHuyVe] = @ThoiGianHuyVe";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ThoiGianBayToiThieu", ts.ThoiGianBayToiThieu);
                    cmd.Parameters.AddWithValue("@SoLuongSanBayTrungGianToiDa", ts.SoLuongSanBayTrungGianToiDa);
                    cmd.Parameters.AddWithValue("@ThoiGianDungToiDa", ts.ThoiGianDungToiDa);
                    cmd.Parameters.AddWithValue("@ThoiGianDungToiThieu", ts.ThoiGianDungToiThieu);
                    cmd.Parameters.AddWithValue("@ThoiGianChamNhatKhiDatVe", ts.ThoiGianChamNhatKhiDatVe);
                    cmd.Parameters.AddWithValue("@ThoiGianHuyVe", ts.ThoiGianHuyVe);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        ts.Error = ex.Message.Remove(0, 65).Trim();
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
