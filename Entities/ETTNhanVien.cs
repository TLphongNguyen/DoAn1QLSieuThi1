using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTNhanVien
    {
        protected int ma_nhan_vien;
        protected string ho_ten;
        protected string gioi_tinh;
        protected string dia_chi;
        protected string so_dien_thoai;
        protected int MaLoai;
        public ETTNhanVien()
        {

        }
        public ETTNhanVien(ETTNhanVien ETTNV)
        {
            this.ma_nhan_vien = ETTNV.Ma_nhan_vien;
            this.ho_ten = ETTNV.Ho_ten;
            this.ho_ten = ETTNV.Gioi_tinh;
            this.ho_ten = ETTNV.Dia_chi;
            this.ho_ten = ETTNV.So_dien_thoai;
            this.MaLoai = ETTNV.Maloai;
        }
        public ETTNhanVien(int Ma_nhan_vien,string Ho_ten, string Gioi_tinh, string Dia_chi, string So_dien_thoai,int Maloai)
        {
            this.ma_nhan_vien = Ma_nhan_vien;
            this.ho_ten = Ho_ten;
            this.gioi_tinh = Gioi_tinh;
            this.dia_chi = Dia_chi;
            this.so_dien_thoai = So_dien_thoai;
            this.MaLoai = Maloai;
        }
        public ETTNhanVien(string Ho_ten, string Gioi_tinh, string Dia_chi, string So_dien_thoai,int Maloai)
        {
            this.ho_ten = Ho_ten;
            this.gioi_tinh = Gioi_tinh;
            this.dia_chi = Dia_chi;
            this.so_dien_thoai = So_dien_thoai;
            this.MaLoai = Maloai;

        }
        public int Ma_nhan_vien
        {
            get { return ma_nhan_vien; }
            set { ma_nhan_vien = value; }
        }
        public string Ho_ten
        {
            get{ return ho_ten; }
            set{ ho_ten = value; }
        }
        public string Gioi_tinh { 
            get{ return gioi_tinh; }
            set{ gioi_tinh = value; }
        }
        public string Dia_chi
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }
        public string So_dien_thoai
        {
            get { return so_dien_thoai; }
            set { so_dien_thoai = value; }
        }
        public int Maloai
        {
            get { return MaLoai; }
            set { MaLoai = value;}
        }
    }
}
