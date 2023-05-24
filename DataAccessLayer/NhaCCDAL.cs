using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhaCCDAL:INhaCCDAL
    {
        private const string PARM_NCCID = "@ma_nha_cung_cap";
        private const string PARM_NCCName = "@ten_nha_cung_cap";
        private const string PARM_NvAddress = "@dia_chi";
        private const string PARM_NvPhone = "@so_dien_thoai";
        public int Insert(string ten_nha_cung_cap, string dia_chi, string so_dien_thoai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NCCName,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_NvAddress,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_NvPhone,SqlDbType.NVarChar,20),

            };
            parm[0].Value = ten_nha_cung_cap;
            parm[1].Value = dia_chi;
            parm[2].Value = so_dien_thoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_ins", parm);
        }
        public int Delete(int ma_nha_cung_cap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NCCID,SqlDbType.Int)
            };
            parm[0].Value = ma_nha_cung_cap;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_del", parm);
        }
        /// <summary>
        /// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        /// </summary>     
        public int Update(int ma_nha_cung_cap, string ten_nha_cung_cap, string dia_chi, string so_dien_thoai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NCCID,SqlDbType.Int),
                new SqlParameter(PARM_NCCName,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_NvAddress,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_NvPhone,SqlDbType.NVarChar,20),
            };
            parm[0].Value = ma_nha_cung_cap;
            parm[1].Value = ten_nha_cung_cap;
            parm[2].Value = dia_chi;
            parm[3].Value = so_dien_thoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_Upd", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_nha_cung_cap", typeof(int));
            table.Columns.Add("ten_nha_cung_cap", typeof(string));
            table.Columns.Add("dia_chi", typeof(string));
            table.Columns.Add("so_dien_thoai", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_nha_cung_cap"].ToString()), dra["ten_nha_cung_cap"].ToString(), dra["dia_chi"].ToString(), dra["so_dien_thoai"].ToString());
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm lấy về thông tin một lớp học cụ thể
        /// </summary> 
        public DataTable getNhaCC_ID(int ma_nha_cung_cap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NCCID,SqlDbType.Int)
            };
            parm[0].Value = ma_nha_cung_cap;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_sel_id", parm);
            DataTable table = new DataTable();
            table.Columns.Add("ma_nha_cung_cap", typeof(int));
            table.Columns.Add("ten_nha_cung_cap", typeof(string));
            table.Columns.Add("dia_chi", typeof(string));
            table.Columns.Add("so_dien_thoai", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_nhan_vien"].ToString()), dra["ho_ten"].ToString(), dra["dia_chi"].ToString(), dra["so_dien_thoai"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int getNhaCCID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ma_nha_cung_cap from nha_cung_cap order by ma_nha_cung_cap desc", null);
        }
        public int checkNHaCC_ID(int ma_nha_cung_cap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NCCID,SqlDbType.Int)
            };
            parm[0].Value = ma_nha_cung_cap;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_Check", parm);
        }
    }
    
}
