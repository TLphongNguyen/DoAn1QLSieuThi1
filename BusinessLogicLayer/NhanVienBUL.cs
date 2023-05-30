using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;
using Utility;
using Entities;
using DocumentFormat.OpenXml.Drawing.Charts;
using DataAccessLayer.Interface;
using OpenXmlPowerTools;

namespace BusinessLogicLayer
{
    public class NhanVienBUL:INhanVienBUL
    {
        private readonly INhanVienDAL dal = new NhanVienDAL();
        ILoaiNhanVienBUL lnv = new LoaiNhanVienBUL();
        /// <param name="ETTNV">Thông tin lớp học được lấy từ tầng Presentation </param>
        public IList<dynamic> tl_nv()
        {
            var resultType = (from nv in this.getAll()
                              join lnv in lnv.getAll()
                              on nv.Maloai equals lnv.maLoai
                              select new { Ma_nhan_vien = nv.Ma_nhan_vien, Ho_ten = nv.Ho_ten, Gioi_tinh = nv.Gioi_tinh, Dia_chi = nv.Dia_chi, So_dien_thoai = nv.So_dien_thoai, maLoai = lnv.maLoai,tenLoai = lnv.tenLoai });
            return resultType.Cast<dynamic>().ToList();

        }
        public int Insert(ETTNhanVien ETTNV)
        {
            if (checkClass_ID(ETTNV.Ma_nhan_vien) == 0)
                return dal.Insert(ETTNV.Ho_ten, Tools.ChuanHoaXau(ETTNV.Gioi_tinh), Tools.ChuanHoaXau(ETTNV.Dia_chi), Tools.ChuanHoaXau(ETTNV.So_dien_thoai),ETTNV.Maloai);
            else return -1;

        }
        /// <summary>
        /// Hàm xóa thông tin lớp học khỏi CSDL với mã lớp được chỉ định từ tầng Presentation
        /// Nếu không xóa được lớp do lớp này không tồn tại hàm trả về giá trị -1
        /// </summary>
        /// <param name="ma_nhan_vien">Mã lớp</param>

        public int Delete(int ma_nhan_vien)
        {
            if (checkClass_ID(ma_nhan_vien) != 0)
                return dal.Delete(ma_nhan_vien);
            else return -1;
        }
        /// <summary>
        /// Hàm cập nhật lại thông tin một lớp học vào CSDL với thông tin mới được lấy từ tầng Presentation
        /// Nếu việc cập nhật thất bại do mã lớp không tồn tại thì hàm trả về -1
        /// </summary>
        /// <param name="cls">Thông tin lớp mới cần được cập nhật lại vào CSDL</param>

        public int Update(ETTNhanVien ETTNV)
        {
            if (checkClass_ID(ETTNV.Ma_nhan_vien) != 0)
                return dal.Update(ETTNV.Ma_nhan_vien, ETTNV.Ho_ten, Tools.ChuanHoaXau(ETTNV.Gioi_tinh), Tools.ChuanHoaXau(ETTNV.Dia_chi), Tools.ChuanHoaXau(ETTNV.So_dien_thoai),ETTNV.Maloai);
            else return -1;
        }
        /// <summary>
        /// Hàm trả về danh sách các lớp cóp trong CSDL
        /// </summary>

        public IList<ETTNhanVien> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTNhanVien> list = new List<ETTNhanVien>();
            foreach (DataRow row in table.Rows)
            {
                ETTNhanVien ETTNV = new ETTNhanVien();
                ETTNV.Ma_nhan_vien = row.Field<int>(0);
                ETTNV.Ho_ten = row.Field<string>(1);
                ETTNV.Gioi_tinh = row.Field<string>(2);
                ETTNV.Dia_chi = row.Field<string>(3);
                ETTNV.So_dien_thoai = row.Field<string>(4);
                ETTNV.Maloai = row.Field<int>(5);

                list.Add(ETTNV);
            }
            return list;
        }
       

        public ETTNhanVien getClass_ID(int ma_nhan_vien)
        {
            System.Data.DataTable table = dal.getClass_ID(ma_nhan_vien);
            if (checkClass_ID(ma_nhan_vien) != 0)
            {
                ETTNhanVien ETTNV = new ETTNhanVien();
                ETTNV.Ma_nhan_vien = table.Rows[0].Field<int>(0);
                ETTNV.Ho_ten = table.Rows[0].Field<string>(1);
                ETTNV.Gioi_tinh = table.Rows[0].Field<string>(2);
                ETTNV.Dia_chi = table.Rows[0].Field<string>(3);
                ETTNV.So_dien_thoai = table.Rows[0].Field<string>(4);
                ETTNV.Maloai = table.Rows[0].Field<int>(5);
                return ETTNV;
            }
            else return null;
        }
        public ETTNhanVien getMaLoai(int MaLoai)
        {
            System.Data.DataTable table = dal.getClass_ID(MaLoai);//khai báo dataTabale gán cho giá trị trả về từ hàm getClass_ID
            if (checkClass_ID(MaLoai) != 0)
            {
                ETTNhanVien ETTNV = new ETTNhanVien();
                ETTNV.Ma_nhan_vien = table.Rows[0].Field<int>(0);//gán bằng giá trị của cột số 0 trong hàng đầu tiên
                ETTNV.Ho_ten = table.Rows[0].Field<string>(1);
                ETTNV.Gioi_tinh = table.Rows[0].Field<string>(2);
                ETTNV.Dia_chi = table.Rows[0].Field<string>(3);
                ETTNV.So_dien_thoai = table.Rows[0].Field<string>(4);
                ETTNV.Maloai = table.Rows[0].Field<int>(5);
                return ETTNV;
            }
            else return null;
        }
        /// <summary>
        /// Hàm lấy về mã của bản ghi mới nhất trong bảng tbl_Classes
        /// </summary> 
        public int getclassID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getclassID_Last();
        }
        /// <summary>
        /// Kiểm tra xem một lớp cho bởi mã lớp có trong CSDL không?
        /// Nếu có hàm trả về giá trị khác 0 còn không có trả về giá trị bằng 0
        /// </summary>
        /// <param name="ma_nhan_vien">Mã lớp</param>

        public int checkClass_ID(int ma_nhan_vien)
        {
            return dal.checkClass_ID(ma_nhan_vien);
        }
        
         
        public IList<dynamic> SearchLinq(string tennv, int loainv)
        {
            if (tennv != "")
            {
                tennv = Tools.ChuanHoaXau(tennv);
            }
            return tl_nv().Where(x => ((string.IsNullOrEmpty(tennv) || x.ho_ten.Contains(tennv)) && (x.MaLoai == loainv || loainv == -5))).ToList();
        }

        public IList<dynamic> SearchmanvLinq(string tennv)
        {
            if (tennv != "")
            {
                tennv = Tools.ChuanHoaXau(tennv);
            }
            return (tl_nv().Where(x => (string.IsNullOrEmpty(tennv)) || x.Ho_ten.Contains(tennv)).ToList());
        }
        

    }
}
