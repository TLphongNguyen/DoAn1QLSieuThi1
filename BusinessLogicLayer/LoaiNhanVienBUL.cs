using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Utility;

namespace BusinessLogicLayer
{
    public class LoaiNhanVienBUL : ILoaiNhanVienBUL
    {
        private readonly ILoaiNhanVienDAL dal = new LoaiNhanVienDAL();
        public int Insert(ETTLoaiNhanVien x)
        {
            x.maLoai = x.maLoai;
            x.tenLoai = Tools.ChuanHoaXau(x.tenLoai);
            return dal.Insert(x);
        }

        public int Update(ETTLoaiNhanVien x)
        {
            x.tenLoai = Tools.ChuanHoaXau(x.tenLoai);
            return dal.Insert(x);
        }
        public int Delete(int ma)
        {
            return dal.Delete(ma);
        }
        public IList<
            ETTLoaiNhanVien> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTLoaiNhanVien> list = new List<ETTLoaiNhanVien>();
            foreach (DataRow row in table.Rows)
            {
                ETTLoaiNhanVien cls = new ETTLoaiNhanVien();
                cls.maLoai = row.Field<int>(0);
                cls.tenLoai = row.Field<string>(1);
                list.Add(cls);
            }
            return list;
        }
    }
}
