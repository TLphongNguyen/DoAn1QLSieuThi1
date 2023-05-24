using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTChiTietHoaDon
    {
        protected int MaHoaDonCT;
        protected int ma_hoa_don;
        protected int ma_san_pham;
        protected int so_luong;
        protected decimal gia_ban;
        public ETTChiTietHoaDon() { }
        public ETTChiTietHoaDon(ETTChiTietHoaDon CTHD)
        {

        }
        public ETTChiTietHoaDon(int maHoaDonCT, int ma_hoa_don, int ma_san_pham, int so_luong, decimal gia_ban)
        {
            this.MaHoaDonCT = maHoaDonCT;
            this.ma_hoa_don = ma_hoa_don;
            this.ma_san_pham = ma_san_pham;
            this.so_luong = so_luong;
            this.gia_ban = gia_ban;
        }
        public ETTChiTietHoaDon( int ma_hoa_don, int ma_san_pham, int so_luong, decimal gia_ban)
        {
            this.ma_hoa_don = ma_hoa_don;
            this.ma_san_pham = ma_san_pham;
            this.so_luong = so_luong;
            this.gia_ban = gia_ban;
        }
        public ETTChiTietHoaDon(int ma_hoa_don,int so_luong, decimal gia_ban)
        {
            this.ma_hoa_don = ma_hoa_don;

            this.so_luong = so_luong;
            this.gia_ban = gia_ban;
        }
        public int mahoadonct
        {
            get { return MaHoaDonCT; }
            set { MaHoaDonCT = value; }
        }
        public int Ma_hoa_don
        {
            get { return ma_hoa_don; }
            set { ma_hoa_don = value; }
        }
        public int Ma_san_pham
        {
            get { return ma_san_pham; }
            set { ma_san_pham = value; }
        }
        public int So_luong
        {
            get { return so_luong; }
            set { so_luong = value; }
        }
        public decimal Gia_ban
        {
            get { return gia_ban; }
            set { gia_ban = value; }
        }

    }
}
