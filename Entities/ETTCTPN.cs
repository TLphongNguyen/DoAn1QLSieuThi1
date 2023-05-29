using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTCTPN
    {
        protected int ma_chi_tiet;
        protected int ma_phieu_nhap;
        protected int ma_san_pham;
        protected int so_luong;
        protected float don_gia;
        public ETTCTPN()
        {

        }
        public ETTCTPN(ETTCTPN ETT)
        {
            this.ma_chi_tiet = ETT.MaCT; ;
            this.ma_phieu_nhap = ETT.MaPhieuNhap;
            this.ma_san_pham = ETT.MaSanPham;
            this.so_luong = ETT.SoLuong;
            this.don_gia = ETT.DonGia;

        }
        public ETTCTPN(int MaCT, int MaPhieuNhap, int MaSanPham , int SoLuong, float DonGia)
        {
            this.ma_chi_tiet = MaCT;
            this.ma_phieu_nhap = MaPhieuNhap;
            this.ma_san_pham = MaSanPham;
            this.so_luong = SoLuong;
            this.don_gia = DonGia;
        }
        public ETTCTPN(int MaPhieuNhap, int MaSanPham, int SoLuong, float DonGia)
        {
            this.ma_phieu_nhap = MaPhieuNhap;
            this.ma_san_pham = MaSanPham;
            this.so_luong = SoLuong;
            this.don_gia = DonGia;
        }
        public int MaCT
        {
            get { return ma_chi_tiet; }
            set { ma_chi_tiet = value; }
        }
        public int MaPhieuNhap
        {
            get { return ma_phieu_nhap; }
            set { ma_phieu_nhap = value; }
        }
        public int MaSanPham
        {
            get { return ma_san_pham; }
            set { ma_san_pham = value; }
        }
        public int SoLuong
        {
            get { return so_luong; }
            set { so_luong = value; }
        }
        public float DonGia
        {
            get { return don_gia; }
            set { don_gia = value; }
        }
    }
}
