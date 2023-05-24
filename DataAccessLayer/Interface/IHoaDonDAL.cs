using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IHoaDonDAL
    {
        int Insert(DateTime Ngay_ban, int Ma_nhan_vien);
        int Update(int Ma_hoa_don,DateTime Ngay_ban, int Ma_nhan_vien);
        int Delete(int ma_hoa_don);
        int checkHoaDon_ID(int ma_hoa_don);

        DataTable getAll();
    }
}
