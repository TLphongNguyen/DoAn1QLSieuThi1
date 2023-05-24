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
    public class ChiTietHoaDonDAL : IChiTietHoaDonDAL
    {
        private const string PARM_MACTHD = "@MaHoaDonCT";
        private const string PARM_MAHD = "@ma_hoa_don";
        private const string PARM_MASP = "@ma_san_pham";
        private const string PARM_SOLUONG = "@so_luong";
        private const string PARM_DONGIA = "@gia_ban";
        public int Insert(ETTChiTietHoaDon x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHD,SqlDbType.Int),
                new SqlParameter(PARM_MASP,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Decimal),

            };
            parm[0].Value = x.Ma_hoa_don;
            parm[1].Value = x.Ma_san_pham;
            parm[2].Value = x.So_luong;
            parm[3].Value = x.Gia_ban;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "CTHD_ins", parm);
        }

        public int Update(ETTChiTietHoaDon x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHD,SqlDbType.Int),
                new SqlParameter(PARM_MAHD,SqlDbType.Int),
                new SqlParameter(PARM_MASP,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Decimal),
            };
            parm[0].Value = x.mahoadonct;
            parm[1].Value = x.Ma_hoa_don;
            parm[2].Value = x.Ma_san_pham;
            parm[3].Value = x.So_luong;
            parm[4].Value = x.Gia_ban;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "CTHD_Upd", parm);
        }
        public int Delete(int x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACTHD,SqlDbType.Int),new SqlParameter(PARM_MAHD,SqlDbType.Int),
            };
            parm[0].Value = x;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "CTHD_del", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "CTHD_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHoaDonCT", typeof(int));
            table.Columns.Add("ma_hoa_don", typeof(int));
            table.Columns.Add("ma_san_pham", typeof(int));
            table.Columns.Add("so_luong", typeof(int));
            table.Columns.Add("gia_ban", typeof(decimal));
            while (dra.Read())
            {
                int MaHoaDonCT = 0;
                if (!DBNull.Value.Equals(dra["MaHoaDonCT"]))
                {
                    MaHoaDonCT = Convert.ToInt32(dra["MaHoaDonCT"]);
                }
                int ma_hoa_don = 0;
                if (!DBNull.Value.Equals(dra["ma_hoa_don"]))
                {
                    ma_hoa_don = Convert.ToInt32(dra["ma_hoa_don"]);
                }
                int ma_san_pham = 0;
                if (!DBNull.Value.Equals(dra["ma_san_pham"]))
                {
                    ma_san_pham = Convert.ToInt32(dra["ma_san_pham"]);
                }
                int so_luong = 0;
                if (!DBNull.Value.Equals(dra["so_luong"]))
                {
                    so_luong = Convert.ToInt32(dra["so_luong"]);
                }
                decimal gia_ban = 0;
                if (!DBNull.Value.Equals(dra["gia_ban"]))
                {
                    gia_ban = Convert.ToDecimal(dra["gia_ban"]);
                }
                table.Rows.Add(MaHoaDonCT, ma_hoa_don, ma_hoa_don, so_luong, gia_ban);
            }
            dra.Dispose();
            return table;
        }
    }
}
