using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTProduct
    {
        protected int ma_san_pham;
        protected string ten_san_pham;
        protected int ma_loai_hang;
        protected float gia_tien;
        protected int so_luong;
        public ETTProduct()
        {

        }
        public ETTProduct(ETTProduct ETTPD)
        {
            this.ma_san_pham = ETTPD.ma_san_pham;
            this.ten_san_pham = ETTPD.ten_san_pham;
            this.ma_loai_hang = ETTPD.ma_loai_hang;
            this.gia_tien  = ETTPD.gia_tien;
            this.so_luong = ETTPD.so_luong;
        }
        public ETTProduct(int ma_san_pham, string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong)
        {
            this.ma_san_pham = ma_san_pham;
            this.ten_san_pham = ten_san_pham;
            this.ma_loai_hang = ma_loai_hang;
            this.gia_tien = gia_tien;
            this.so_luong = so_luong;
        }
        public ETTProduct(int ma_san_pham, int so_luong)
        {
            this.ma_san_pham = ma_san_pham;
            this.so_luong = so_luong;

        }
        public ETTProduct( string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong)
        {
            this.ten_san_pham = ten_san_pham;
            this.ma_loai_hang = ma_loai_hang;
            this.gia_tien = gia_tien;
            this.so_luong = so_luong;
        }
        public int MSP
        {
            get { return ma_san_pham; }
            set { ma_san_pham = value; }
        }
        public string TSP
        {
            get { return ten_san_pham; }
            set { ten_san_pham = value; }
        }
        public int MLH
        {
            get { return ma_loai_hang; }
            set
            {
                ma_loai_hang = value;
            }
        }
        public float GT
        {
            get { return gia_tien; }
            set { gia_tien = value; }
        }
        public int SL
        {
            get { return so_luong; }
            set { so_luong = value; }
        }
    }
}
