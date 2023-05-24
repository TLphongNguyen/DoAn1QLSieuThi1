using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Interface;


namespace DataAccessLayer
{
    public class CategoryDAL : ICategoryDAL
    {
        private const string PARM_CtID = "@ma_loai_hang";
        private const string PARM_CtName = "@ten_loai_hang";


        /// <param name="ma_loai_hang"
        /// <param name="ten_loai_hang"     
        public int Insert(string ten_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CtName,SqlDbType.NVarChar,255)
                

            };
            parm[0].Value = ten_loai_hang;
            
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_ins", parm);
        }
        /// <summary>
        /// Hàm xóa lớp được chỉ định bởi mã lớp
        /// </summary>
        /// <param name="ma_loai_hang">Mã lớp</param>

        public int Delete(int ma_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CtID,SqlDbType.Int)
            };
            parm[0].Value = ma_loai_hang;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_del", parm);
        }
    
        public int Update(int ma_loai_hang, string ten_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CtID,SqlDbType.Int),
                new SqlParameter(PARM_CtName,SqlDbType.NVarChar,255),

            };
            parm[0].Value = ma_loai_hang;
            parm[1].Value = ten_loai_hang;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_Upd", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_loai_hang", typeof(int));
            table.Columns.Add("ten_loai_hang", typeof(string));

            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_loai_hang"].ToString()), dra["ten_loai_hang"].ToString());
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm lấy về thông tin một loại hàng cụ thể
        /// </summary> 
        public DataTable getLoaiHang_ID(int ma_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CtID,SqlDbType.Int)
            };
            parm[0].Value = ma_loai_hang;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_sel_id", parm);
            DataTable table = new DataTable();
            table.Columns.Add("ma_loai_hang", typeof(int));
            table.Columns.Add("ten_loai_hang", typeof(string));

            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_loai_hang"].ToString()), dra["ten_loai_hang"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int getLoaiHangID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ma_loai_hang from loai_hang order by ma_loai_hang desc", null);
        }
        public int checkLoaiHang_ID(int ma_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CtID,SqlDbType.Int)
            };
            parm[0].Value = ma_loai_hang;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "loai_hang_Check", parm);
        }
    }
}
