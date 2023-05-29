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
    public class LoaiNhanVienDAL : ILoaiNhanVienDAL
    {
        private const string PARM_MALOAI = "@MaLoai";
        private const string PARM_TENLOAI = "@TenLoai";

        public int Insert(ETTLoaiNhanVien x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MALOAI,SqlDbType.Int),
                new SqlParameter(PARM_TENLOAI,SqlDbType.NVarChar,50),
            };
            parm[0].Value = x.maLoai;
            parm[1].Value = x.tenLoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "LoaiNV_ins", parm);
        }

        public int Update(ETTLoaiNhanVien x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MALOAI,SqlDbType.Int),
                new SqlParameter(PARM_TENLOAI,SqlDbType.NVarChar,50),
            };
            parm[0].Value = x.maLoai;
            parm[1].Value = x.maLoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "LoaiNv_Upd", parm);
        }
        public int Delete(int x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MALOAI,SqlDbType.Int),
            };
            parm[0].Value = x;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "LoaiNV_del", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_LoaiNhanVien_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaLoai", typeof(int));
            table.Columns.Add("TenLoai", typeof(string));
            while (dra.Read())
            {
                int MaLoai = 0;
                if (!DBNull.Value.Equals(dra["MaLoai"]))
                {
                    MaLoai = Convert.ToInt32(dra["MaLoai"]);
                }

                string TenLoai = string.Empty;
                if (!DBNull.Value.Equals(dra["TenLoai"]))
                {
                    TenLoai = dra["TenLoai"].ToString();
                }
                table.Rows.Add(MaLoai, TenLoai);
            }
            dra.Dispose();
            return table;
        }
    }
}
