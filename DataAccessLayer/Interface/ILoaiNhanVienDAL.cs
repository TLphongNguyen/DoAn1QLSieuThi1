using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ILoaiNhanVienDAL
    {
        int Insert(ETTLoaiNhanVien x);
        int Update(ETTLoaiNhanVien x);
        int Delete(int ma);
        DataTable getAll();
    }
}
