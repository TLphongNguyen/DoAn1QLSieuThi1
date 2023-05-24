using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using Utility;

namespace BusinessLogicLayer
{
    public class CategoryBUL : ICategoryBUL
    {
        private readonly ICategoryDAL dal = new CategoryDAL();
        public int Insert(ETTCategory ETTCT)
        {
            if (checkLoaiHang_ID(ETTCT.Ma_loai_hang) == 0)
                return dal.Insert(ETTCT.Ten_loai_hang);
            else return -1;

        }
        /// <summary>
        /// Hàm xóa thông tin lớp học khỏi CSDL với mã lớp được chỉ định từ tầng Presentation
        /// Nếu không xóa được lớp do lớp này không tồn tại hàm trả về giá trị -1
        /// </summary>
        /// <param name="ma_loai_hang">Mã lớp</param>

        public int Delete(int ma_loai_hang)
        {
            if (checkLoaiHang_ID(ma_loai_hang) != 0)
                return dal.Delete(ma_loai_hang);
            else return -1;
        }
        /// <summary>
        /// Hàm cập nhật lại thông tin một lớp học vào CSDL với thông tin mới được lấy từ tầng Presentation
        /// Nếu việc cập nhật thất bại do mã lớp không tồn tại thì hàm trả về -1
        /// </summary>
        /// <param name="cls">Thông tin lớp mới cần được cập nhật lại vào CSDL</param>

        public int Update(ETTCategory ETTCT)
        {
            if (checkLoaiHang_ID(ETTCT.Ma_loai_hang) != 0)
                return dal.Update(ETTCT.Ma_loai_hang, ETTCT.Ten_loai_hang);
            else return -1;
        }
        /// <summary>
        /// Hàm trả về danh sách các lớp cóp trong CSDL
        /// </summary>

        public IList<ETTCategory> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTCategory> list = new List<ETTCategory>();
            foreach (DataRow row in table.Rows)
            {
                ETTCategory ETTCT = new ETTCategory();
                ETTCT.Ma_loai_hang = row.Field<int>(0);
                ETTCT.Ten_loai_hang = row.Field<string>(1);
                list.Add(ETTCT);
            }
            return list;
        }
        /// <summary>
        /// Hàm trả về thông tin cụ thể một lớp đã được chỉ định
        /// Nếu mã lớp không tồn tại hàm trả về giá trị null
        /// </summary>
        /// <param name="ma_loai_hang">Mã lớp</param>

        public ETTCategory getLoaiHang_ID(int ma_loai_hang)
        {
            System.Data.DataTable table = dal.getLoaiHang_ID(ma_loai_hang);
            if (checkLoaiHang_ID(ma_loai_hang) != 0)
            {
                ETTCategory ETTCT = new ETTCategory();
                ETTCT.Ma_loai_hang = table.Rows[0].Field<int>(0);
                ETTCT.Ten_loai_hang = table.Rows[0].Field<string>(1);

                return ETTCT;
            }
            else return null;
        }
        /// <summary>
        /// Hàm lấy về mã của bản ghi mới nhất trong bảng tbl_Classes
        /// </summary> 
        public int getLoaiHangID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getLoaiHangID_Last();
        }
        /// <summary>
        /// Kiểm tra xem một lớp cho bởi mã lớp có trong CSDL không?
        /// Nếu có hàm trả về giá trị khác 0 còn không có trả về giá trị bằng 0
        /// </summary>
        /// <param name="ma_loai_hang">Mã lớp</param>

        public int checkLoaiHang_ID(int ma_loai_hang)
        {
            return dal.checkLoaiHang_ID(ma_loai_hang);
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học 
        /// </summary>
        /// <param name="ETTCT">Thông tin lớp</param> 
        public IList<ETTCategory> Search(ETTCategory ETTCT)
        {
            IList<ETTCategory> list = getAll();
            IList<ETTCategory> kq = new List<ETTCategory>();
            //Voi gai tri ngam dinh ban dau
            if (ETTCT.Ten_loai_hang == null)
            {
                kq = list;
            }
            //Tim theo ten lop
            if (ETTCT.Ten_loai_hang != null )
            {
                foreach (ETTCategory ETT in list)
                    if (ETT.Ten_loai_hang.IndexOf(ETTCT.Ten_loai_hang) >= 0)
                    {
                        kq.Add(new ETTCategory(ETT));
                    }
            }
            
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học dùng Linq
        /// </summary>
        /// <param name="ETT">Thông tin lớp</param> 
        public IList<ETTCategory> SearchLinq(ETTCategory ETT)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(ETT.Ten_loai_hang) || x.Ten_loai_hang.Contains(ETT.Ten_loai_hang))).ToList();
        }

        


    }
}
