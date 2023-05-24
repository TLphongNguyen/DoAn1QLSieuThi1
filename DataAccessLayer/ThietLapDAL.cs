using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class ThietLapDAL : IThietLapDAL
    {
        private const string PARM_LoginID = "@IdLogin";
        private const string PARM_Username = "@UserName";
        private const string PARM_Pass = "@PassWords";
        private const string PARM_NvID = "@ma_nhan_vien";

     
        public int Insert(string UserName, string PassWords, int ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                
                new SqlParameter(PARM_Username,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_Pass,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_NvID,SqlDbType.Int),

            };
            parm[0].Value = UserName;
            parm[1].Value = PassWords;
            parm[2].Value = ma_nhan_vien;
            
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_ins", parm);
        }
        /// <summary>
        /// Hàm xóa lớp được chỉ định bởi mã lớp
        /// </summary>
        /// <param name="IdLogin">Mã lớp</param>

        public int Delete(int IdLogin)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_LoginID,SqlDbType.Int)
            };
            parm[0].Value = IdLogin;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_del", parm);
        }
        /// <summary>
        /// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        /// </summary>
     
        public int Update(int IdLogin, string UserName, string PassWords, int ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_LoginID,SqlDbType.Int),
                new SqlParameter(PARM_Username,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_Pass,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_NvID,SqlDbType.Int),

            };
            parm[0].Value = IdLogin;
            parm[1].Value = UserName;
            parm[2].Value = PassWords;
            parm[3].Value = ma_nhan_vien;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_Upd", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("IdLogin", typeof(int));
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("PassWords", typeof(string));
            table.Columns.Add("ma_nhan_vien", typeof(int));
            
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["IdLogin"].ToString()), dra["UserName"].ToString(), dra["PassWords"].ToString(), dra["ma_nhan_vien"].ToString());
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm lấy về thông tin một lớp học cụ thể
        /// </summary> 
        public DataTable getLogin_ID(int IdLogin)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_LoginID,SqlDbType.Int)
            };
            parm[0].Value = IdLogin;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_sel_id", parm);
            DataTable table = new DataTable();
            table.Columns.Add("IdLogin", typeof(int));
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("PassWords", typeof(string));
            table.Columns.Add("ma_nhan_vien", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["IdLogin"].ToString()), dra["UserName"].ToString(), dra["PassWords"].ToString(), dra["ma_nhan_vien"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int checkTaiKhoan(ETTThietLap tk)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_Username,SqlDbType.VarChar,20),
                new SqlParameter(PARM_Pass,SqlDbType.VarChar,20),
            };
            
                parm[0].Value = tk.userName;
            
                parm[1].Value = tk.passWords;
            
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "TaiKhoanCheck", parm);
        }
        public int getLoginID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 IdLogin from Login order by IdLogin desc", null);
        }
        public int checkLogin_ID(int IdLogin)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_LoginID,SqlDbType.Int)
            };
            parm[0].Value = IdLogin;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Login_Check", parm);
        }
    }
}
