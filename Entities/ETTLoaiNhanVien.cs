using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTLoaiNhanVien
    {
        protected int MaLoai;
        protected string TenLoai;
        public ETTLoaiNhanVien() { }
        public ETTLoaiNhanVien(ETTLoaiNhanVien LNV)
        {
            this.MaLoai = LNV.MaLoai;
            this.TenLoai = LNV.TenLoai;
        }
        public ETTLoaiNhanVien(int maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }
        public int maLoai
        {
            get { return this.MaLoai; }
            set { this.MaLoai = value; }
        }
        public string tenLoai
        {
            get { return this.TenLoai; }
            set { this.TenLoai = value; }

        }
    }
}
