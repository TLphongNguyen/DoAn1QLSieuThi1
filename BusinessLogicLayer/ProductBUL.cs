using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using Entities;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public class ProductBUL: IProductBUL
    {
        IProductDAL dal = new ProductDAL();
        ICategoryBUL dalC = new CategoryBUL();
        public int Insert(ETTProduct ETTPR)
        {
            if (checkProduct_ID(ETTPR.MSP) == 0)
                return dal.Insert(ETTPR.TSP, ETTPR.MLH, ETTPR.GT, ETTPR.SL);
            else return -1;

        }


        /// <summary>
        /// Hàm xóa thông tin lớp học khỏi CSDL với mã lớp được chỉ định từ tầng Presentation
        /// Nếu không xóa được lớp do lớp này không tồn tại hàm trả về giá trị -1
        /// </summary>


        public int Delete(int ma_san_pham)
        {
            if (checkProduct_ID(ma_san_pham) != 0)
                return dal.Delete(ma_san_pham);
            else return -1;
        }
        /// <summary>
        /// Hàm cập nhật lại thông tin một lớp học vào CSDL với thông tin mới được lấy từ tầng Presentation
        /// Nếu việc cập nhật thất bại do mã lớp không tồn tại thì hàm trả về -1
        /// </summary>
        /// <param name="cls">Thông tin lớp mới cần được cập nhật lại vào CSDL</param>

        public int Update(ETTProduct ETTPR)
        {
            if (checkProduct_ID(ETTPR.MSP) != 0)
                return dal.Update(ETTPR.MSP, ETTPR.TSP, ETTPR.MLH, ETTPR.GT, ETTPR.SL);
            else return -1;
        }
        public int UpdateSL(ETTProduct sp)
        {
            return dal.UpdateSL(sp);
        }
        /// <summary>
        /// Hàm trả về danh sách các lớp cóp trong CSDL
        /// </summary>

        public IList<ETTProduct> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTProduct> list = new List<ETTProduct>();
            foreach (DataRow row in table.Rows)
            {
                ETTProduct ETTPR = new ETTProduct();
                ETTPR.MSP = row.Field<int>(0);
                ETTPR.TSP = row.Field<string>(1);
                ETTPR.MLH = row.Field<int>(2);
                ETTPR.GT = row.Field<float>(3);
                ETTPR.SL = row.Field<int>(4);
                list.Add(ETTPR);
            }
            return list;
        }
        /// <summary>
        /// Hàm trả về thông tin cụ thể một lớp đã được chỉ định
        /// Nếu mã lớp không tồn tại hàm trả về giá trị null
        /// </summary>


        public ETTProduct getProduct_ID(int ma_san_pham)
        {
            System.Data.DataTable table = dal.getProduct_ID(ma_san_pham);
            if (checkProduct_ID(ma_san_pham) != 0)
            {
                ETTProduct ETTPR = new ETTProduct();
                ETTPR.MSP = table.Rows[0].Field<int>(0);
                ETTPR.TSP = table.Rows[0].Field<string>(1);
                ETTPR.MLH = table.Rows[0].Field<int>(2);
                ETTPR.GT = table.Rows[0].Field<float>(3);
                ETTPR.SL = table.Rows[0].Field<int>(4);
                return ETTPR;
            }
            else return null;
        }
        /// <summary>
        /// Hàm lấy về mã của bản ghi mới nhất trong bảng tbl_Classes
        /// </summary> 
        public int getProductID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getProductID_Last();
        }
        /// <summary>
        /// Kiểm tra xem một lớp cho bởi mã lớp có trong CSDL không?
        /// Nếu có hàm trả về giá trị khác 0 còn không có trả về giá trị bằng 0
        /// </summary>
        /// <param name="ma_nhan_vien">Mã lớp</param>

        public int checkProduct_ID(int ma_san_pham)
        {
            return dal.checkProduct_ID(ma_san_pham);
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học 
        /// </summary>
        /// <param name="cls">Thông tin lớp</param> 
        public IList<ETTProduct> Search(ETTProduct ETTPR)
        {
            IList<ETTProduct> list = getAll();
            IList<ETTProduct> kq = new List<ETTProduct>();
            //Voi gai tri ngam dinh ban dau
            if (ETTPR.TSP == null && ETTPR.MLH == null && ETTPR.GT == null && ETTPR.SL == null)
            {
                kq = list;
            }
            //Tim theo ten sản phẩm
            if (ETTPR.TSP != null && ETTPR.MLH == null && ETTPR.GT == null && ETTPR.SL == null)
            {
                foreach (ETTProduct ETT in list)
                    if (ETT.TSP.IndexOf(ETTPR.TSP) >= 0)
                    {
                        kq.Add(new ETTProduct(ETT));
                    }
            }
            //Tim theo giá tiền
            else if (ETTPR.TSP == null && ETTPR.MLH == null && ETTPR.GT != null && ETTPR.SL == null)
            {
                foreach (ETTProduct ETT in list)
                    if (ETT.GT.ToString().IndexOf(ETTPR.GT.ToString()) >= 0)
                    {
                        kq.Add(new ETTProduct(ETT));
                    }
            }
            //Tim theo so luong
            else if (ETTPR.TSP == null && ETTPR.MLH == null && ETTPR.GT == null && ETTPR.SL != null)
            {
                foreach (ETTProduct ETT in list)
                    if (ETT.SL.ToString().IndexOf(ETTPR.SL.ToString()) >= 0)
                    {
                        kq.Add(new ETTProduct(ETT));
                    }
            }
            
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học dùng Linq
        /// </summary>
        /// <param name="cls">Thông tin lớp</param> 
        public IList<dynamic> SearchLinq(string value)
        {
            return getAllJoin().Where(ETTPR => (string.IsNullOrEmpty(value) || ETTPR.MSP.ToString().Contains(value) ||
                (ETTPR.TSP == value) ||
                (string.IsNullOrEmpty(value) || ETTPR.TSP.ToString().Contains(value)))).ToList();
        }
        public List<dynamic> getAllJoin()
        {
            var product_Category = (from pd in this.getAll()
                                    join Ct in dalC.getAll() on pd.MLH equals Ct.Ma_loai_hang
                                    select new { MaSanPham = pd.MSP, TenSanPham = pd.TSP, /*MaLH = pd.MLH,*/ Giaban = pd.GT, SoLuong = pd.SL, TenLoaiHang = Ct.Ten_loai_hang,/*maloaihang = Ct.Ma_loai_hang*/ });
            return product_Category.Cast<dynamic>().ToList();
        }

        
    }
}
