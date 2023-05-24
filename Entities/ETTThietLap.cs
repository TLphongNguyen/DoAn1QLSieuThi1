using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTThietLap
    {
        protected int IdLogin;
        protected string UserName;
        protected string PassWords;
        protected int ma_nhan_vien;
        public ETTThietLap() {

        }
        public ETTThietLap(ETTThietLap ETT)
        {
            this.IdLogin = ETT.IdLogin;
            this.UserName = ETT.UserName;
            this.PassWords = ETT.PassWords;
            this.ma_nhan_vien = ETT.ma_nhan_vien;

        }
        public ETTThietLap(int idLogin , string userName, string passWords, int Ma_nhan_vien)
        {
            this.IdLogin = idLogin;
            this.UserName = userName;
            this.PassWords = passWords;
            this.ma_nhan_vien = Ma_nhan_vien;
        }
        public ETTThietLap( string userName, string passWords, int Ma_nhan_vien)
        {
            this.UserName = userName;
            this.PassWords = passWords;
            this.ma_nhan_vien = Ma_nhan_vien;
        }
        public ETTThietLap(string userName, string passWords)
        {
            this.UserName = userName;
            this.PassWords = passWords;
        }
        public int idLogin
        {
            get { return IdLogin; }
            set { IdLogin = value; }
        }
        public string userName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public string passWords {
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
