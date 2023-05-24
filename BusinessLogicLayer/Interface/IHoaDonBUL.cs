using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IHoaDonBUL
    {
        int Insert(ETTHoaDon x);
        int Update(ETTHoaDon x);
        int Delete(int ma);
        IList<ETTHoaDon> getAll();
        IList<dynamic> lastHD();
        //void KetXuatWord(int MaNV, string templatePath, string exportPath);

    }
}
