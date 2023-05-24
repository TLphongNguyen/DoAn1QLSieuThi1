using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IChiTietHoaDonDAL
    {
        int Insert(ETTChiTietHoaDon x);
        int Update(ETTChiTietHoaDon x);
        int Delete(int MaHoaDonCT);
        DataTable getAll();
    }
}
