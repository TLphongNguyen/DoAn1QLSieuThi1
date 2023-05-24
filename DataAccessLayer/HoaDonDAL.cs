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
    public class HoaDonDAL:IHoaDonDAL 
    {
        private const string PARM_MaHD = "@ma_hoa_don";
        private const string PARM_NgayBan = "@ngay_ban";
        private const string PARM_MaNv = "@ma_nhan_vien";


        public int Insert(DateTime Ngay_ban, int Ma_nhan_vien )
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NgayBan,SqlDbType.DateTime),
                new SqlParameter(PARM_MaNv,SqlDbType.Int),
              

            };
            parm[0].Value = Ngay_ban;
            parm[1].Value = Ma_nhan_vien;
            
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_ins", parm);
        }

        public int Update(int Ma_hoa_don, DateTime Ngay_ban, int Ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MaHD,SqlDbType.Int),
                new SqlParameter(PARM_NgayBan,SqlDbType.DateTime),
                new SqlParameter(PARM_MaNv,SqlDbType.Int),
                
            };
            parm[0].Value = Ma_hoa_don;
            parm[1].Value = Ngay_ban;
            parm[2].Value = Ma_nhan_vien;
           
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_Upd", parm);
        }
        public int Delete(int x)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MaHD,SqlDbType.Int),
            };
            parm[0].Value = x;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_del", parm);
        }
        public int checkHoaDon_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MaHD,SqlDbType.Int)
            };
            parm[0].Value = classID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "HoaDOn_Check", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_hoa_don", typeof(int));
            table.Columns.Add("ngay_ban", typeof(DateTime));
            table.Columns.Add("ma_nhan_vien", typeof(int));

            while (dra.Read())
            {
                int ma_hoa_don = 0;
                if (!DBNull.Value.Equals(dra["ma_hoa_don"]))
                {
                    ma_hoa_don = Convert.ToInt32(dra["ma_hoa_don"]);
                }
                DateTime ngay_ban = DateTime.MinValue;
                if (!DBNull.Value.Equals(dra["ngay_ban"]))
                {
                    ngay_ban = Convert.ToDateTime(dra["ngay_ban"]);
                }
                int ma_nhan_vien = 0;
                if (!DBNull.Value.Equals(dra["ma_nhan_vien"]))
                {
                    ma_nhan_vien = Convert.ToInt32(dra["ma_nhan_vien"]);
                }
                
                table.Rows.Add(ma_hoa_don, ngay_ban, ma_nhan_vien);
            }
            dra.Dispose();
            return table;
        }
    }
}
