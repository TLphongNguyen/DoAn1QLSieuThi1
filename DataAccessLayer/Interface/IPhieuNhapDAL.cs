using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IPhieuNhapDAL
    {
        int Insert( DateTime ngaynhap, int mancc);
        int Delete(int maphieunhap);
        int Update(int maphieunhap, DateTime ngaynhap, int mancc);
        DataTable getAll();
        int checkPhieuNhap_ID(int maphieunhap);
    }
}
