using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IProductDAL
    {
        int Insert(string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong);
        int Insert(ETTProduct pro);
        int Delete(int ma_san_pham);
        int Update(int ma_san_pham, string ten_san_pham, int ma_loai_hang, float gia_tien, int so_luong);
        int UpdateSL(ETTProduct sp);
        DataTable getAll();
        DataTable getProduct_ID(int ma_san_pham);
        int getProductID_Last();
        int checkProduct_ID(int ma_san_pham);
    }
}
