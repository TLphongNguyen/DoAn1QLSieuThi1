using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IChiTietHoaDonBUL
    {
        int Insert(ETTChiTietHoaDon x);
        int Update(ETTChiTietHoaDon x);
        int Delete(int ma);
        IList<ETTChiTietHoaDon> getAll();
      
        void KetXuatWord(string name, int ma_hoa_don, float tongtien, string tennv, string templatePath, string exportPath);

    }
}
