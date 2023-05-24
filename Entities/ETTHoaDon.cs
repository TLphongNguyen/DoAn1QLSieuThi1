using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTHoaDon
    {
        protected int ma_hoa_don;
        protected DateTime ngay_ban;
        protected int ma_nhan_vien;
        public ETTHoaDon() { }
        public ETTHoaDon(ETTHoaDon ETTHD)
        {
            this.ma_hoa_don = ETTHD.ma_hoa_don;
            this.ngay_ban = ETTHD.ngay_ban;
            this.ma_nhan_vien = ETTHD.ma_nhan_vien;

        }
        
        public ETTHoaDon(int ma_hoa_don, DateTime ngay_ban, int ma_nhan_vien)
        {
            this.ma_hoa_don = ma_hoa_don;
            this.ngay_ban = ngay_ban;
            this.ma_nhan_vien = ma_nhan_vien;
        }
        public ETTHoaDon(DateTime ngay_ban, int ma_nhan_vien)
        {
            this.ngay_ban = ngay_ban;
            this.ma_nhan_vien = ma_nhan_vien;
        }

        public int Ma_hoa_don
        {
            get { return ma_hoa_don; }
            set { ma_hoa_don = value; }
        }
        public DateTime Ngay_ban
        {
            get { return ngay_ban; }
            set { ngay_ban = value; }
        }
        public int Ma_nhan_vien
        {
            get { return ma_nhan_vien; }
            set { ma_nhan_vien = value; }
        }
    }
}
