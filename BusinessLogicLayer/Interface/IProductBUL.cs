using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IProductBUL
    {
        int Insert(ETTProduct ETTPR);
        int Delete(int ma_san_pham);
        int Update(ETTProduct ETTPR);
        int UpdateSL(ETTProduct sp);
        IList<ETTProduct> getAll();
        ETTProduct getProduct_ID(int ma_san_pham);
        int getProductID_Last();
        int checkProduct_ID(int ma_nhan_vien);
        IList<ETTProduct> Search(ETTProduct ETTPR);
        IList<dynamic> SearchLinq(string value);
        List<dynamic> getAllJoin();
        
    }
}
