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
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;

namespace BusinessLogicLayer
{
    public class HoaDonBUL : IHoaDonBUL
    {
        private readonly IHoaDonDAL dal = new HoaDonDAL();
        INhanVienBUL bllnv = new NhanVienBUL();
        IProductBUL bllsp = new ProductBUL();
        IChiTietHoaDonBUL bllcthd = new ChiTietHoaDonBUL();

        public int Insert(ETTHoaDon x)
        {
            if (checkHoaDon_ID(x.Ma_hoa_don) == 0)
                return dal.Insert(x.Ngay_ban,x.Ma_nhan_vien);
            else return -1;

        }
        public int Delete(int ma_hoa_don)
        {
            if (checkHoaDon_ID(ma_hoa_don) != 0)
                return dal.Delete(ma_hoa_don);
            else return -1;
        }

        public int checkHoaDon_ID(int ma_hoa_don)
        {
            return dal.checkHoaDon_ID(ma_hoa_don);
        }

        public int Update(ETTHoaDon x)
        {
            if (checkHoaDon_ID(x.Ma_hoa_don) != 0)
                return dal.Update(x.Ma_hoa_don, x.Ngay_ban, x.Ma_nhan_vien);
            else return -1;
        }

        public IList<ETTHoaDon> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTHoaDon> list = new List<ETTHoaDon>();
            foreach (DataRow row in table.Rows)
            {
                ETTHoaDon cls = new ETTHoaDon();
                cls.Ma_hoa_don = row.Field<int>(0);
                cls.Ngay_ban = row.Field<DateTime>(1);
                cls.Ma_nhan_vien = row.Field<int>(2);
                list.Add(cls);
            }
            return list;
        }

        public IList<dynamic> lastHD()
        {
            IList<dynamic> list = new List<dynamic>();
            var lastOrder = getAll().OrderByDescending(o => o.Ma_hoa_don).FirstOrDefault();
            list.Add(lastOrder);
            return list;
        }
        
        public List<dynamic> cthd_sp(int mahd)
        {

            var resultType = (from cthd in bllcthd.getAll()
                              join sp in bllsp.getAll()
                              on cthd.Ma_san_pham equals sp.MSP
                              where cthd.Ma_hoa_don == mahd
                              select new
                              {
                                  TenSP = sp.TSP,
                                  
                                  SoLuong = cthd.So_luong,
                                  GiaBan = cthd.Gia_ban,
                                  Tong = cthd.Gia_ban
                              });
            return resultType.Cast<dynamic>().ToList();
        }
        //public void KetXuatWord(string name, int mahd, float tongtien, string templatePath, string exportPath)
        //{
        //    IHoaDonBUL HD = new HoaDonBUL();
            
        //    IList<ETTHoaDon> list = HD.getAll();
        //    IList<ETTHoaDon> newList = list.Where(ct => ct.Ma_hoa_don == MaNV).ToList();
        //    Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
        //    dictionaryData.Add("tenkhachhang",name);
        //    dictionaryData.Add("tongtien", tongtien.ToString());
        //    System.IO.File.Copy(templatePath, exportPath, true);
        //    ExportDocx.CreateChiTietTemplate(exportPath, dictionaryData, newList);
        //}

    }
}
