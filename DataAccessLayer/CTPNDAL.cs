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
    public class CTPNDAL : ICTPNDAL
    {
        private const string PARM_CHITIETPN = "@ma_chi_tiet";
        private const string PARM_MAPN = "@ma_phieu_nhap";
        private const string PARM_SP = "@ma_san_pham";
        private const string PARM_SOLUONG = "@so_luong";
        private const string PARM_DONGIA = "@don_gia";
        public int Insert(int maphieunhap, int mathuoc, int soluong, float dongia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPN,SqlDbType.Int),
                new SqlParameter(PARM_SP,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
            };
            parm[0].Value = maphieunhap;
            parm[1].Value = mathuoc;
            parm[2].Value = soluong;
            parm[3].Value = dongia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Insert", parm);
        }

        public int Delete(int machitietphieunhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int)
            };
            parm[0].Value = machitietphieunhap;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Del", parm);
        }

        public int Update(int machitietphieunhap, int maphieunhap, int mathuoc, int soluong, float dongia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int),
                new SqlParameter(PARM_MAPN,SqlDbType.Int),
                new SqlParameter(PARM_SP,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
            };
            parm[0].Value = machitietphieunhap;
            parm[1].Value = maphieunhap;
            parm[2].Value = mathuoc;
            parm[2].Value = soluong;
            parm[3].Value = dongia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Update", parm);
        }

        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_chi_tiet", typeof(int));
            table.Columns.Add("ma_phieu_nhap", typeof(int));
            table.Columns.Add("ma_san_pham", typeof(int));
            table.Columns.Add("so_luong", typeof(int));
            table.Columns.Add("don_gia", typeof(float));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_chi_tiet"].ToString()), dra["ma_phieu_nhap"].ToString(), dra["ma_san_pham"].ToString(), dra["so_luong"].ToString(), dra["don_gia"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkChiTietPN_ID(int machitietphieunhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int)
            };
            parm[0].Value = machitietphieunhap;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Check", parm);
        }
    }
}
