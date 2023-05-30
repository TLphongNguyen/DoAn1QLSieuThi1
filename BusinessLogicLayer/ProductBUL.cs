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




        public int Delete(int ma_san_pham)
        {
            if (checkProduct_ID(ma_san_pham) != 0)
                return dal.Delete(ma_san_pham);
            else return -1;
        }
        

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
        
        public int getProductID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getProductID_Last();
        }
        

        public int checkProduct_ID(int ma_san_pham)
        {
            return dal.checkProduct_ID(ma_san_pham);
        }
        
        
        public IList<ETTProduct> SearchLinq(ETTProduct ETT)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(ETT.TSP) || x.TSP.Contains(ETT.TSP))).ToList();
        }
       
        public List<dynamic> getAllJoin()
        {
            var product_Category = (from pd in this.getAll()
                                    join Ct in dalC.getAll() on pd.MLH equals Ct.Ma_loai_hang
                                    select new { MaSanPham = pd.MSP, TenSanPham = pd.TSP, TenLoaiHang = Ct.Ten_loai_hang,/*MaLH = pd.MLH,*/ Giaban = pd.GT, SoLuong = pd.SL, /*maloaihang = Ct.Ma_loai_hang*/ });
            return product_Category.Cast<dynamic>().ToList();
        }

        
    }
}
