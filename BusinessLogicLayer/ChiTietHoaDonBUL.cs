using BusinessLogicLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ChiTietHoaDonBUL : IChiTietHoaDonBUL
    {
        IChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();
        public IList<ETTChiTietHoaDon> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTChiTietHoaDon> list = new List<ETTChiTietHoaDon>();
            foreach (DataRow row in table.Rows)
            {
                ETTChiTietHoaDon CTHD = new ETTChiTietHoaDon();
                CTHD.mahoadonct = row.Field<int>(0);
                CTHD.Ma_hoa_don = row.Field<int>(1);
                CTHD.Ma_san_pham = row.Field<int>(2);
                CTHD.So_luong = row.Field<int>(3);
                CTHD.Gia_ban = row.Field<decimal>(4);
                list.Add(CTHD);
            }
            return list;
        }



        public int Insert(ETTChiTietHoaDon sp)
        {
            return dal.Insert(sp);
        }

        public int Update(ETTChiTietHoaDon sp)
        {
            return dal.Update(sp);
        }

        public int Delete(int masp)
        {
            return dal.Delete(masp);
        }
        public void KetXuatWord(string name, int ma_hoa_don, float tongtien, string templatePath, string exportPath)
        {
            IChiTietHoaDonBUL chitiet = new ChiTietHoaDonBUL();
            IList<ETTChiTietHoaDon> list = chitiet.getAll();
            IList<ETTChiTietHoaDon> newList = list.Where(ct => ct.Ma_hoa_don == ma_hoa_don).ToList();           
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("tennhanvien", name);
            dictionaryData.Add("tongtien", tongtien.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateChiTietTemplate(exportPath, dictionaryData, newList);
        }
    }
}
