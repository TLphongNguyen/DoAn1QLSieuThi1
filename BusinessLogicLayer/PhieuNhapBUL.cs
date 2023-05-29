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

namespace BusinessLogicLayer
{
    public class PhieuNhapBUL : IPhieuNhapBUL
    {
        private readonly IPhieuNhapDAL dal = new PhieuNhapDAL();

        public int Insert(ETTPhieuNhap cls)
        {
            if (checkPhieuNhap_ID(cls.MaPhieuNhap) == 0)
                return dal.Insert( cls.NgayNhap, cls.MaNCC);
            else return -1;
        }

        public int Delete(int phieunhapID)
        {
            if (checkPhieuNhap_ID(phieunhapID) != 0)
                return dal.Delete(phieunhapID);
            else return -1;
        }

        public int Update(ETTPhieuNhap cls)
        {
            if (checkPhieuNhap_ID(cls.MaPhieuNhap) != 0)
                return dal.Update(cls.MaPhieuNhap, cls.NgayNhap, cls.MaNCC);
            else return -1;
        }

        public IList<ETTPhieuNhap> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTPhieuNhap> list = new List<ETTPhieuNhap>();
            foreach (DataRow row in table.Rows)
            {
                ETTPhieuNhap cls = new ETTPhieuNhap();
                cls.MaPhieuNhap = row.Field<int>(0);
                cls.NgayNhap = row.Field<DateTime>(1);
                cls.MaNCC = row.Field<int>(2);
                list.Add(cls);
            }
            return list;
        }

        public int checkPhieuNhap_ID(int classID)
        {
            return dal.checkPhieuNhap_ID(classID);
        }

        public IList<ETTPhieuNhap> SearchLinq(ETTPhieuNhap cls)
        {
            return getAll();
        }
        public ETTPhieuNhap GetLastPN()
        {
            ETTPhieuNhap phieuNhapCuoiCung = getAll().OrderByDescending(p => p.MaPhieuNhap).FirstOrDefault();
            return phieuNhapCuoiCung;
        }

        
    }
}
