using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Data;

namespace DataAccessLayer.Helper
{
    public class SqlConnectionData
    {
        //tạo chuỗi kết nối csdl
        protected static SqlConnection Connect()
        {
            string strcon = @"Data Source=PHONGGDEEPTRY\SQLEXPRESS;Initial Catalog=DoAn1NguyenTienLinhPhong;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;

        }

    }
    public class DataBaseAccses : SqlConnectionData
    {
        public static string CheckLoginDTO(User taikhoan)
        {
            string TaiKhoan = null;
            //ham jet noi toi csdl
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.userName);
            cmd.Parameters.AddWithValue("@pass", taikhoan.passWords);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TaiKhoan = reader.GetString(1);
                    return TaiKhoan;

                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "tài khoản hoặc mật khẩu không chính xác";
            }
            return TaiKhoan;
        }
    }
}
