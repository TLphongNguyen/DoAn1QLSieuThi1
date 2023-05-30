using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface INhanVienBUL
    {
        int Insert(ETTNhanVien ETTNV);
        int Delete(int ma_nhan_vien);
        int Update(ETTNhanVien ETTNV);
        IList<ETTNhanVien> getAll();
        ETTNhanVien getClass_ID(int ma_nhan_vien);
        int getclassID_Last();
        int checkClass_ID(int ma_nhan_vien);
        ETTNhanVien getMaLoai(int MaLoai);
        IList<dynamic> SearchLinq(string tennv, int loainv);
        IList<dynamic> SearchmanvLinq(string tenNV);
        IList<dynamic> tl_nv();
        
    }
}
