using DataAccessLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer.Interface
{
    public class TaiKhoanBLL
    {
        TaiKhoanAcces tkAccess = new TaiKhoanAcces();
        public string CheckLogin(User taikhoan)
        {
            //kiem tra nghiep vu
            if (taikhoan.userName == "")
            {
                return "requeid_TaiKhoan";
            }
            else if (taikhoan.passWords == "")
            {
                return "requeid_PassWord";
            }
            string info = tkAccess.CheckLogin(taikhoan);
            return info;
        }
    }
}
