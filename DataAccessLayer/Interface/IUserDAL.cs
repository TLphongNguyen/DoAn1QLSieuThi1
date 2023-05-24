using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IUserDAL
    {
        int checkTaiKhoan(User tk);
        int Insert(User tk);
        int Update(User tk);
        int Delete(int manv);
        int checkTaiKhoanID(int manv);
        DataTable getAll();
    }
}
