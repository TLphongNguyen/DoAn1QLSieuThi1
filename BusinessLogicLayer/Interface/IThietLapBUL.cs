using DocumentFormat.OpenXml.Bibliography;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IThietLapBUL
    {
        int Insert(ETTThietLap ETTTL);
        int Delete(int IdLogin);
        int Update(ETTThietLap ETTTL);
        IList<ETTThietLap> getAll();
        ETTThietLap getLogin_ID(int IdLogin);
        int getLoginID_Last();
        int checkLogin_ID(int IdLogin);
        IList<ETTThietLap> Search(ETTThietLap ETTTL);
        IList<ETTThietLap> SearchLinq(ETTThietLap ETTTL);
        bool checkTaiKhoan_IsExist(string tk, string mk);
        IList<dynamic> tl_nv();
        ETTNhanVien GetNhanVien(int manv);
        ETTThietLap TaiKhoanLogin(string tk, string mk);
        int checkTaiKhoan(ETTThietLap tk);
        


    }
}
