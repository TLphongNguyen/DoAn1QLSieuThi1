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
    public class PhieuNhapDAL : IPhieuNhapDAL
    {
        private const string PARM_MAPHIEUNHAP = "@ma_phieu_nhap";
        private const string PARM_NCCID = "@ma_nha_cung_cap";
        private const string PARM_NGAYNHAP = "@ngay_nhap";
        
        public int Insert( DateTime ngaynhap, int mancc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.DateTime),
                new SqlParameter(PARM_NCCID,SqlDbType.Int)
                
            };
            parm[0].Value = ngaynhap;
            parm[1].Value = mancc;
           
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "PhieuNhap_ins", parm);
        }

        public int Delete(int manhapID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int)
            };
            parm[0].Value = manhapID;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "PhieuNhap_del", parm);
        }

        public int Update(int maphieunhap, DateTime ngaynhap, int mancc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int),
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.DateTime),
                new SqlParameter(PARM_NCCID,SqlDbType.Int)
                
            };
            parm[0].Value = maphieunhap;
            parm[1].Value = ngaynhap;
            parm[2].Value = mancc;
            
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "PhieuNhap_Upd", parm);
        }

        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaPhieuNhap", typeof(int));
            table.Columns.Add("NgayNhap", typeof(DateTime));
            table.Columns.Add("MaNCC", typeof(int));

            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_phieu_nhap"].ToString()), DateTime.Parse(dra["ngay_nhap"].ToString()), int.Parse(dra["ma_nha_cung_cap"].ToString()));
            }
            dra.Dispose();
            return table;
        }

        public int checkPhieuNhap_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int)
            };
            parm[0].Value = classID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Check", parm);
        }
    }
}
