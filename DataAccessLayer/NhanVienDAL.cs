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
    public class NhanVienDAL : INhanVienDAL
    {
        private const string PARM_NvID = "@ma_nhan_vien";
        private const string PARM_NvName = "@ho_ten";
        private const string PARM_NvSex = "@gioi_tinh";
        private const string PARM_NvAddress = "@dia_chi";
        private const string PARM_NvPhone = "@so_dien_thoai";
        private const string PARM_MALOAI = "@MaLoai";


        /// <param name="ma_nhan_vien"
        /// <param name="ho_ten"
        /// <param name="gioi_tinh"
        /// <param name="dia_chi"      
        /// <param name="so_dien_thoai"      
        public int Insert(string ho_ten, string gioi_tinh, string dia_chi,string so_dien_thoai,int MaLoai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NvName,SqlDbType.NVarChar,100),
                new SqlParameter(PARM_NvSex,SqlDbType.NVarChar,10),
                new SqlParameter(PARM_NvAddress,SqlDbType.NVarChar,200),
                new SqlParameter(PARM_NvPhone,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_MALOAI,SqlDbType.Int),

            };
            parm[0].Value = ho_ten;
            parm[1].Value = gioi_tinh;
            parm[2].Value = dia_chi;
            parm[3].Value = so_dien_thoai;
            parm[4].Value = MaLoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_ins", parm);
        }
        /// <summary>
        /// Hàm xóa lớp được chỉ định bởi mã lớp
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public int Delete(int ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NvID,SqlDbType.Int)
            };
            parm[0].Value = ma_nhan_vien;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_del", parm);
        }
        /// <summary>
        /// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        /// </summary>
        /// <param name="ma_nhan_vien"
        /// <param name="ho_ten"
        /// <param name="gioi_tinh"
        /// <param name="dia_chi"      
        /// <param name="so_dien_thoai"      
        public int Update(int ma_nhan_vien, string ho_ten, string gioi_tinh, string dia_chi, string so_dien_thoai,int MaLoai)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NvID,SqlDbType.Int),
                new SqlParameter(PARM_NvName,SqlDbType.NVarChar,100),
                new SqlParameter(PARM_NvSex,SqlDbType.NVarChar,10),
                new SqlParameter(PARM_NvAddress,SqlDbType.NVarChar,200),
                new SqlParameter(PARM_NvPhone,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_MALOAI,SqlDbType.Int),
            };
            parm[0].Value = ma_nhan_vien;
            parm[1].Value = ho_ten;
            parm[2].Value = gioi_tinh;
            parm[3].Value = dia_chi;
            parm[4].Value = so_dien_thoai;
            parm[5].Value = MaLoai;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_Upd", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "nhan_vien_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ma_nhan_vien", typeof(int));
            table.Columns.Add("ho_ten", typeof(string));
            table.Columns.Add("gioi_tinh", typeof(string));
            table.Columns.Add("dia_chi", typeof(string));
            table.Columns.Add("so_dien_thoai", typeof(string));
            table.Columns.Add("MaLoai", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_nhan_vien"].ToString()), dra["ho_ten"].ToString(), dra["gioi_tinh"].ToString(), dra["dia_chi"].ToString(), dra["so_dien_thoai"].ToString(), int.Parse(dra["MaLoai"].ToString()));
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm lấy về thông tin một lớp học cụ thể
        /// </summary> 
        public DataTable getClass_ID(int ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NvID,SqlDbType.Int)
            };
            parm[0].Value = ma_nhan_vien;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_sel_id", parm);
            DataTable table = new DataTable();
            table.Columns.Add("ma_nhan_vien", typeof(int));
            table.Columns.Add("ho_ten", typeof(string));
            table.Columns.Add("gioi_tinh", typeof(string));
            table.Columns.Add("dia_chi", typeof(string));
            table.Columns.Add("so_dien_thoai", typeof(string));
            table.Columns.Add("MaLoai", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["ma_nhan_vien"].ToString()), dra["ho_ten"].ToString(), dra["gioi_tinh"].ToString(), dra["dia_chi"].ToString(), dra["so_dien_thoai"].ToString(), int.Parse(dra["MaLoai"].ToString()));
            }
            dra.Dispose();
            return table;
        }
        public int getclassID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ma_nhan_vien from nhan_vien order by ma_nhan_vien desc", null);
        }
        public int checkClass_ID(int ma_nhan_vien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NvID,SqlDbType.Int)
            };
            parm[0].Value = ma_nhan_vien;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "nhan_vien_Check", parm);
        }
    }
}
