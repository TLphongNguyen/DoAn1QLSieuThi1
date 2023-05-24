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
        IList<ETTNhanVien> Search(ETTNhanVien ETTNV);
        IList<ETTNhanVien> SearchLinq(ETTNhanVien ETTNV, int ma_nhan_vien);
        IList<dynamic> SearchmanvLinq(int manv);
        IList<dynamic> tl_nv();
        void KetXuatWord(int ma_nhan_vien, string templatePath, string exportPath);
    }
}
