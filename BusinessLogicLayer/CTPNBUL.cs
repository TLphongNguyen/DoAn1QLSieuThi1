using BusinessLogicLayer.Interface;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CTPNBUL : ICTPNBUL
    {
        private readonly CTPNDAL dal = new CTPNDAL();

        public int Insert(ETTCTPN cls)
        {
            if (checkChiTietPN_ID(cls.MaCT) == 0)
                return dal.Insert(cls.MaPhieuNhap, cls.MaSanPham, cls.SoLuong, cls.DonGia);
            else return -1;
        }
        public int Delete(int machitietphieunhap)
        {
            if (checkChiTietPN_ID(machitietphieunhap) != 0)
                return dal.Delete(machitietphieunhap);
            else return -1;
        }

        public int Update(ETTCTPN cls)
        {
            if (checkChiTietPN_ID(cls.MaCT) != 0)
                return dal.Update(cls.MaCT, cls.MaPhieuNhap, cls.MaSanPham, cls.SoLuong, cls.DonGia);
            else return -1;
        }

        public IList<ETTCTPN> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            Console.WriteLine(table);
            IList<ETTCTPN> list = new List<ETTCTPN>();
            foreach (DataRow row in table.Rows)
            {
                ETTCTPN cls = new ETTCTPN();
                cls.MaCT = row.Field<int>(0);
                cls.MaPhieuNhap = row.Field<int>(1);
                cls.MaSanPham = row.Field<int>(2);
                cls.SoLuong = row.Field<int>(3);
                cls.DonGia = row.Field<float>(4);
                list.Add(cls);
            }
            return list;
        }

        public int checkChiTietPN_ID(int PhieuNhapID)
        {
            return dal.checkChiTietPN_ID(PhieuNhapID);
        }

        //public void KetXuatWord(ETTPhieuNhap mapn, string ncc, string tennv, string templatePath, string exportPath)
        //{
        //    IList<ETTCTPN> list = getAll();
        //    IList<ETTCTPN> newlist = list.Where(pn => pn.MaPhieuNhap == mapn.MaPhieuNhap).ToList();
        //    Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
        //    dictionaryData.Add("tongtien", mapn.MaPhieuNhap.ToString());
        //    dictionaryData.Add("tennhanvien", tennv);
        //    dictionaryData.Add("tenncc", ncc);
        //    System.IO.File.Copy(templatePath, exportPath, true);
        //    ExportDocx.CreatePhieuNhapTemplate(exportPath, dictionaryData, newlist);
        //}
    }
}
