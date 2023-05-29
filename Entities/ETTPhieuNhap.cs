using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTPhieuNhap
    {
        protected int ma_phieu_nhap;
        protected DateTime ngay_nhap;
        protected int ma_nha_cung_cap;
        public ETTPhieuNhap() { }
        public ETTPhieuNhap(ETTPhieuNhap ETT)
        {
            this.ma_phieu_nhap = ETT.MaPhieuNhap;
            this.ngay_nhap = ETT.NgayNhap;
            this.ma_nha_cung_cap = ETT.MaNCC;
        }
        public ETTPhieuNhap(int MaPhieuNhap, DateTime NgayNhap, int MaNCC)
        {
            this.ma_phieu_nhap = MaPhieuNhap;
            this.ngay_nhap = NgayNhap;
            this.ma_nha_cung_cap = MaNCC;
        }
        public ETTPhieuNhap(DateTime NgayNhap, int MaNCC)
        {
            this.ngay_nhap = NgayNhap;
            this.ma_nha_cung_cap = MaNCC;
        }
        public int MaPhieuNhap
        {
            get { return ma_phieu_nhap; }
            set { ma_phieu_nhap = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngay_nhap; }
            set { ngay_nhap = value; }
        }
        public int MaNCC
        {
            get { return ma_nha_cung_cap; }
            set { ma_nha_cung_cap = value; }
        }

    }
}
