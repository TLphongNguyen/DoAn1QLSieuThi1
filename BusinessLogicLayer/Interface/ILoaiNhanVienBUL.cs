using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ILoaiNhanVienBUL
    {
        IList<ETTLoaiNhanVien> getAll();
        int Insert(ETTLoaiNhanVien x);
        int Update(ETTLoaiNhanVien x);
        int Delete(int ma);

    }
}
