using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class User
    {
        protected int IdLogin;
        protected string UserName;
        protected string PassWords;
        protected int ma_nhan_vien;
        public User()
        {

        }
        public User(int idLogin, string userName, string passWords, int ma_nhan_vien)
        {
            
           
            this.idlogin = idLogin;
            this.userName = userName;
            this.passWords = passWords;
            this.Ma_nhan_vien = ma_nhan_vien;
        }

        public User( string userName, string passWords, int Ma_nhan_vien)
        {
            
            this.UserName = userName;
            this.PassWords = passWords;
            this.ma_nhan_vien = Ma_nhan_vien;
        }
        public int idlogin
        {
            get { return IdLogin; }
            set { IdLogin = value; }
        } 
        public string userName
        {
            get{ return UserName; }
            set{ UserName = value; }
        }
        public string passWords
        {
            get { return PassWords; }
            set { PassWords = value; }
        }
        public int Ma_nhan_vien
        {
            get { return ma_nhan_vien; }    
            set { ma_nhan_vien = value; }
        }
    }
}
