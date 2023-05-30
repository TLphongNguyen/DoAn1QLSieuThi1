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
        

        public int Delete(int ma_loai_hang)
        {
            if (checkLoaiHang_ID(ma_loai_hang) != 0)
                return dal.Delete(ma_loai_hang);
            else return -1;
        }
        

        public int Update(ETTCategory ETTCT)
        {
            if (checkLoaiHang_ID(ETTCT.Ma_loai_hang) != 0)
                return dal.Update(ETTCT.Ma_loai_hang, ETTCT.Ten_loai_hang);
            else return -1;
        }
        

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
         
        public int getLoaiHangID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getLoaiHangID_Last();
        }
        

        public int checkLoaiHang_ID(int ma_loai_hang)
        {
            return dal.checkLoaiHang_ID(ma_loai_hang);
        }
        
       
        
        public IList<ETTCategory> SearchLinq(ETTCategory ETT)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(ETT.Ten_loai_hang) || x.Ten_loai_hang.Contains(ETT.Ten_loai_hang))).ToList();
        }

        


    }
}
