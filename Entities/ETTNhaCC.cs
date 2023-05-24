using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTNhaCC
    {
        protected int ma_nha_cung_cap;
        protected string ten_nha_cung_cap;
        protected string dia_chi;
        protected string so_dien_thoai;
        public ETTNhaCC() { }
        public ETTNhaCC(ETTNhaCC ETTNC)
        {
            this.ma_nha_cung_cap = ETTNC.ma_nha_cung_cap;
            this.ten_nha_cung_cap = ETTNC.ten_nha_cung_cap;
            this.dia_chi = ETTNC.dia_chi;
            this.so_dien_thoai = ETTNC.so_dien_thoai;
        }
        public ETTNhaCC(int ma_nha_cung_cap, string ten_nha_cung_cap, string dia_chi, string so_dien_thoai)
        {
            this.ma_nha_cung_cap = ma_nha_cung_cap;
            this.ten_nha_cung_cap = ten_nha_cung_cap;
            this.dia_chi = dia_chi;
            this.so_dien_thoai = so_dien_thoai;
        }
        public ETTNhaCC( string ten_nha_cung_cap, string dia_chi, string so_dien_thoai)
        {
     
            this.ten_nha_cung_cap = ten_nha_cung_cap;
            this.dia_chi = dia_chi;
            this.so_dien_thoai = so_dien_thoai;
        }
        public int Ma_nha_cung_cap
        {
            get { return ma_nha_cung_cap; }
            set { ma_nha_cung_cap = value; }
        }
        public string Ten_nha_cung_cap { 
            get { return ten_nha_cung_cap; }
            set { ten_nha_cung_cap = value; }
        }
        public string  Dia_chi
        {
            get { return dia_chi; }
            set { dia_chi = value;}
        }
        public string So_dien_thoai { 
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }

    }
}
