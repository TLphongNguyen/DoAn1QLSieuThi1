using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IPhieuNhapBUL
    {
        int Insert(ETTPhieuNhap cls);
        int Delete(int phieunhapID);
        int Update(ETTPhieuNhap cls);
        IList<ETTPhieuNhap> getAll();
        int checkPhieuNhap_ID(int phieunhapID);
        ETTPhieuNhap GetLastPN();
       
    }
}
