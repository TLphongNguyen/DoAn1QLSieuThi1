using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface INhaCCBUL
    {
        int Insert(ETTNhaCC ETTNC);
        int Delete(int ma_nha_cung_cap);
        int Update(ETTNhaCC ETTNC);
        IList<ETTNhaCC> getAll();
        ETTNhaCC getNhaCC_ID(int ma_nha_cung_cap);
        int getNhaCCID_Last();
        int checkNHaCC_ID(int ma_nha_cung_cap);
        IList<ETTNhaCC> Search(ETTNhaCC ETTNC);
        IList<ETTNhaCC> SearchLinq(ETTNhaCC ETTNC);
    }
}
