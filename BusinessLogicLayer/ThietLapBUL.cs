﻿using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public  class ThietLapBUL : IThietLapBUL
    {
        private readonly IThietLapDAL dal = new ThietLapDAL();
        INhanVienBUL bul = new NhanVienBUL();
        /// <param name="ETTNV">Thông tin lớp học được lấy từ tầng Presentation </param>


        public IList<dynamic> tl_nv()
        {
            var resultType = (from tl in this.getAll()
                          join nv in bul.getAll()
                          on tl.Ma_nhan_vien equals nv.Ma_nhan_vien
                          select new {Ma_nhan_vien=nv.Ma_nhan_vien,Ho_ten=nv.Ho_ten,Gioi_tinh = nv.Gioi_tinh,Dia_chi = nv.Dia_chi,So_dien_thoai = nv.So_dien_thoai,idLogin=tl.idLogin,userName= tl.userName,passWords= tl.passWords});
            return resultType.Cast<dynamic>().ToList();

        }
        public int checkTaiKhoan(ETTThietLap tk)
        {
            return dal.checkTaiKhoan(tk);

        }

        public int Insert(ETTThietLap ETTTL)
        {
            if (checkLogin_ID(ETTTL.idLogin) == 0)
                return dal.Insert(ETTTL.userName, Tools.ChuanHoaXau(ETTTL.passWords), ETTTL.Ma_nhan_vien) ;
            else return -1;

        }
       

        public int Delete(int IdLogin)
        {
            if (checkLogin_ID(IdLogin) != 0)
                return dal.Delete(IdLogin);
            else return -1;
        }
        

        public int Update(ETTThietLap ETTTL)
        {
            if (checkLogin_ID(ETTTL.idLogin) != 0)
                return dal.Update(ETTTL.idLogin, ETTTL.userName, Tools.ChuanHoaXau(ETTTL.passWords), ETTTL.Ma_nhan_vien);
            else return -1;
        }
       

        public IList<ETTThietLap> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTThietLap> list = new List<ETTThietLap>();
            foreach (DataRow row in table.Rows)
            {
                ETTThietLap ETTTL = new ETTThietLap();
                ETTTL.idLogin = row.Field<int>(0);
                ETTTL.userName = row.Field<string>(1);
                ETTTL.passWords = row.Field<string>(2);
                ETTTL.Ma_nhan_vien = row.Field<int>(3);
                list.Add(ETTTL);
            }
            return list;
        }
        

        public ETTThietLap getLogin_ID(int IdLogin)
        {
            System.Data.DataTable table = dal.getLogin_ID(IdLogin);
            if (checkLogin_ID(IdLogin) != 0)
            {
                ETTThietLap ETTTL = new ETTThietLap();
                ETTTL.idLogin = table.Rows[0].Field<int>(0);
                ETTTL.userName = table.Rows[0].Field<string>(1);
                ETTTL.passWords = table.Rows[0].Field<string>(2);
                ETTTL.Ma_nhan_vien = table.Rows[0].Field<int>(3);
                return ETTTL;
            }
            else return null;
        }
        public bool checkTaiKhoan_IsExist(string tk, string mk)
        {
            bool isAccountExist = getAll().Any(account =>
            {
                return account.userName == tk && mk == account.passWords;
            });
            return isAccountExist;
        }
        public ETTNhanVien GetNhanVien(int manv)
        {
            ETTNhanVien thongtinnv = bul.getAll().FirstOrDefault(t => t.Ma_nhan_vien == manv);
            return thongtinnv;
        }
        public ETTThietLap TaiKhoanLogin(string tk, string mk)
        {
            if (checkTaiKhoan_IsExist(tk, mk))
            {
                ETTThietLap taiKhoanTimThay = getAll().FirstOrDefault(t => t.userName == tk && t.passWords == mk);
                return taiKhoanTimThay;
            }
            else
            {
                return null;
            }
        }
        
        
        public int getLoginID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getLoginID_Last();
        }
       

        public int checkLogin_ID(int IdLogin)
        {
            return dal.checkLogin_ID(IdLogin);
        }
        
        public IList<ETTThietLap> Search(ETTThietLap ETTTL)
        {
            IList<ETTThietLap> list = getAll();
            IList<ETTThietLap> kq = new List<ETTThietLap>();
            //Voi gai tri ngam dinh ban dau
            if (ETTTL.userName == null && ETTTL.passWords== null && ETTTL.Ma_nhan_vien == 0)
            {
                kq = list;
            }
            //Tim theo ten lop
            if (ETTTL.userName == null && ETTTL.passWords == null && ETTTL.Ma_nhan_vien == 0)
            {
                foreach (ETTThietLap ETT in list)
                    if (ETT.Ma_nhan_vien.ToString().IndexOf(ETTTL.Ma_nhan_vien.ToString()) >= 0)
                    {
                        kq.Add(new ETTThietLap(ETT));
                    }
            }
           
            
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        
        public IList<ETTThietLap> SearchLinq(ETTThietLap ETT)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(ETT.userName) || x.userName.Contains(ETT.userName))
            && (string.IsNullOrEmpty(x.passWords) || x.passWords.Contains(ETT.passWords))
            && (string.IsNullOrEmpty(x.Ma_nhan_vien.ToString()) || x.Ma_nhan_vien.ToString().Contains(ETT.Ma_nhan_vien.ToString()))).ToList();
        }

        
    }
}
