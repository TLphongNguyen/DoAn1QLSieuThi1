using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IThietLapDAL
    {
        int Insert(string UserName, string PassWords,int ma_nhan_vien);
        int Delete(int IdLogin);
        int Update(int IdLogin, string UserName, string PassWords, int ma_nhan_vien);
        DataTable getAll();
        DataTable getLogin_ID(int IdLogin);
        int getLoginID_Last();
        int checkLogin_ID(int IdLogin);
        int checkTaiKhoan(ETTThietLap tk);
        
    }
}
