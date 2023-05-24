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
    public class ProductDAL : IProductDAL
    {
        private const string PARM_PrID = "@ma_san_pham";
        private const string PARM_PrName = "@ten_san_pham";
        private const string PARM_CatID = "@ma_loai_hang";
        private const string PARM_PrPri = "@gia_tien";
        private const string PARM_PrQuan = "@so_luong";

   
        public int Insert(string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrName,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_CatID,SqlDbType.Int),
                new SqlParameter(PARM_PrPri,SqlDbType.Float),
                new SqlParameter(PARM_PrQuan,SqlDbType.Int),

            };
            parm[0].Value = ten_san_pham;
            parm[1].Value = ma_loai_hang;
            parm[2].Value = gia_tien;
            parm[3].Value = so_luong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_ins", parm);
        }


        public int Delete(int ma_loai_hang)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrID,SqlDbType.Int)
            };
            parm[0].Value = ma_loai_hang;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_del", parm);
        }
        /// <summary>
        /// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        /// </summary>
   
        public int Update(int ma_san_pham, string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrID,SqlDbType.Int),
                new SqlParameter(PARM_PrName,SqlDbType.NVarChar,255),
                new SqlParameter(PARM_CatID,SqlDbType.Int),
                new SqlParameter(PARM_PrPri,SqlDbType.Float),
                new SqlParameter(PARM_PrQuan,SqlDbType.Int),
            };
            parm[0].Value = ma_san_pham;
            parm[1].Value = ten_san_pham;
            parm[2].Value = ma_loai_hang;
            parm[3].Value = gia_tien;
            parm[4].Value = so_luong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_Upd", parm);
        }
        public int UpdateSL(ETTProduct sp)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrID,SqlDbType.Int),
                new SqlParameter(PARM_PrQuan,SqlDbType.Int),
            };
            parm[0].Value = sp.MSP; ;
            parm[1].Value = sp.SL;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "SanPham_UpdSL", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_san_pham", typeof(int));
            table.Columns.Add("ten_san_pham", typeof(string));
            table.Columns.Add("ma_loai_hang", typeof(int));
            table.Columns.Add("gia_tien", typeof(float));
            table.Columns.Add("so_luong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_san_pham"].ToString()), dra["ten_san_pham"].ToString(), int.Parse(dra["ma_loai_hang"].ToString()), float.Parse(dra["gia_tien"].ToString()), int.Parse(dra["so_luong"].ToString()));
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm lấy về thông tin một lớp học cụ thể
        /// </summary> 
        public DataTable getProduct_ID(int ma_san_pham)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrID,SqlDbType.Int)
            };
            parm[0].Value = ma_san_pham;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_sel_id", parm);
            DataTable table = new DataTable();
            table.Columns.Add("ma_san_pham", typeof(int));
            table.Columns.Add("ten_san_pham", typeof(string));
            table.Columns.Add("ma_loai_hang", typeof(int));
            table.Columns.Add("gia_tien", typeof(float));
            table.Columns.Add("so_luong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_san_pham"].ToString()), dra["ten_san_pham"].ToString(), int.Parse(dra["ma_loai_hang"].ToString()), float.Parse(dra["gia_tien"].ToString()), int.Parse(dra["so_luong"].ToString()));
            }
            dra.Dispose();
            return table;
        }
        public int getProductID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ma_san_pham from MatHang order by ma_san_pham desc", null);
        }
        public int checkProduct_ID(int ma_san_pham)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_PrID,SqlDbType.Int)
            };
            parm[0].Value = ma_san_pham;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "Product_Check", parm);
        }
        public int Insert(ETTProduct pro)
        {
            return Insert(pro.TSP, pro.MLH, pro.GT, pro.SL);
        }
    }
}
