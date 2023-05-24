using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ICategoryDAL
    {
        int Insert(string ten_loai_hang);
        int Delete(int ma_loai_hang);
        int Update(int ma_loai_hang, string ten_loai_hang);
        DataTable getAll();
        DataTable getLoaiHang_ID(int ma_loai_hang);
        int getLoaiHangID_Last();
        int checkLoaiHang_ID(int ma_loai_hang);
    }
}
