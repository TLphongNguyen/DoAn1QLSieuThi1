using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ICategoryBUL
    {
        int Insert(ETTCategory ETTCT);
        int Delete(int ma_loai_hang);
        int Update(ETTCategory ETTCT);
        IList<ETTCategory> getAll();
        ETTCategory getLoaiHang_ID(int ma_loai_hang);
        int getLoaiHangID_Last();
        int checkLoaiHang_ID(int ma_loai_hang);
        IList<ETTCategory> SearchLinq(ETTCategory ETTCT);
    }
}
