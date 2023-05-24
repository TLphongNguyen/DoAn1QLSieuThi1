using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface INhanVienDAL
    {
        int Insert(string ho_ten, string gioi_tinh, string dia_chi,string so_dien_thoai,int MaLoai);
        int Delete(int ma_nhan_vien);
        int Update(int ma_nhan_vien, string ho_ten, string gioi_tinh, string dia_chi, string so_dien_thoai,int MaLoai);
        DataTable getAll();
        DataTable getClass_ID(int ma_nhan_vien);
        int getclassID_Last();
        int checkClass_ID(int ma_nhan_vien);
    }
}
