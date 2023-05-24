using DataAccessLayer.Helper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class TaiKhoanAcces : DataBaseAccses
    {
        public string CheckLogin(User taikhoan)
        {
            string info = CheckLoginDTO(taikhoan);
            return info;
        }
    }
}
