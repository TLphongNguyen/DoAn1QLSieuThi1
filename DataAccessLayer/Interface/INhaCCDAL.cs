using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface INhaCCDAL
    {
        int Insert(string ten_nha_cung_cap, string dia_chi, string so_dien_thoai);
        int Delete(int ma_nha_cung_cap);
        int Update(int ma_nha_cung_cap, string ten_nha_cung_cap,string dia_chi, string so_dien_thoai);
        DataTable getAll();
        DataTable getNhaCC_ID(int ma_nha_cung_cap);
        int getNhaCCID_Last();
        int checkNHaCC_ID(int ma_nha_cung_cap);
    }
}
