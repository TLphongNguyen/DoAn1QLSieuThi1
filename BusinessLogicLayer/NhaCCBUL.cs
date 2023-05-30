using BusinessLogicLayer.Interface;
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
    public class NhaCCBUL:INhaCCBUL
    {
        private readonly INhaCCDAL dal = new NhaCCDAL();

        public int Insert(ETTNhaCC ETTCC)
        {
            if (checkNHaCC_ID(ETTCC.Ma_nha_cung_cap) == 0)
                return dal.Insert(ETTCC.Ten_nha_cung_cap,  Tools.ChuanHoaXau(ETTCC.Dia_chi), Tools.ChuanHoaXau(ETTCC.So_dien_thoai));
            else return -1;

        }
        


        public int Delete(int ma_nha_cung_cap)
        {
            if (checkNHaCC_ID(ma_nha_cung_cap) != 0)
                return dal.Delete(ma_nha_cung_cap);
            else return -1;
        }
        

        public int Update(ETTNhaCC ETTCC)
        {
            if (checkNHaCC_ID(ETTCC.Ma_nha_cung_cap) != 0)
                return dal.Update(ETTCC.Ma_nha_cung_cap, ETTCC.Ten_nha_cung_cap,Tools.ChuanHoaXau(ETTCC.Dia_chi), Tools.ChuanHoaXau(ETTCC.So_dien_thoai));
            else return -1;
        }
        

        public IList<ETTNhaCC> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<ETTNhaCC> list = new List<ETTNhaCC>();
            foreach (DataRow row in table.Rows)
            {
                ETTNhaCC ETTCC = new ETTNhaCC();
                ETTCC.Ma_nha_cung_cap = row.Field<int>(0);
                ETTCC.Ten_nha_cung_cap = row.Field<string>(1);
                ETTCC.Dia_chi = row.Field<string>(2);
                ETTCC.So_dien_thoai = row.Field<string>(3);
                list.Add(ETTCC);
            }
            return list;
        }
       

        public ETTNhaCC getNhaCC_ID(int ma_nha_cung_cap)
        {
            System.Data.DataTable table = dal.getNhaCC_ID(ma_nha_cung_cap);
            if (checkNHaCC_ID(ma_nha_cung_cap) != 0)
            {
                ETTNhaCC ETTCC = new ETTNhaCC();
                ETTCC.Ma_nha_cung_cap = table.Rows[0].Field<int>(0);
                ETTCC.Ten_nha_cung_cap = table.Rows[0].Field<string>(1);
                ETTCC.Dia_chi = table.Rows[0].Field<string>(2);
                ETTCC.So_dien_thoai = table.Rows[0].Field<string>(3);
                return ETTCC;
            }
            else return null;
        }
       
        public int getNhaCCID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getNhaCCID_Last();
        }
        

        public int checkNHaCC_ID(int ma_nha_cung_cap)
        {
            return dal.checkNHaCC_ID(ma_nha_cung_cap);
        }
        
        public IList<ETTNhaCC> Search(ETTNhaCC ETTCC)
        {
            IList<ETTNhaCC> list = getAll();
            IList<ETTNhaCC> kq = new List<ETTNhaCC>();
            //Voi gai tri ngam dinh ban dau
            if (ETTCC.Ten_nha_cung_cap == null && ETTCC.Dia_chi == null && ETTCC.So_dien_thoai == null)
            {
                kq = list;
            }
            //Tim theo ten nha cc
            if (ETTCC.Ten_nha_cung_cap != null && ETTCC.Dia_chi == null && ETTCC.So_dien_thoai == null)
            {
                foreach (ETTNhaCC ETT in list)
                    if (ETT.Ten_nha_cung_cap.IndexOf(ETTCC.Ten_nha_cung_cap) >= 0)
                    {
                        kq.Add(new ETTNhaCC(ETT));
                    }
            }
            // Tim theo dia chi
            else if (ETTCC.Ten_nha_cung_cap == null && ETTCC.Dia_chi != null && ETTCC.So_dien_thoai == null)
            {
                foreach (ETTNhaCC ETT in list)
                    if (ETT.Dia_chi.IndexOf(ETTCC.Dia_chi) >= 0)
                    {
                        kq.Add(new ETTNhaCC(ETT));
                    }
            }
            //Tim theo so dien thoai
            else if (ETTCC.Ten_nha_cung_cap == null&& ETTCC.Dia_chi == null && ETTCC.So_dien_thoai != null)
            {
                foreach (ETTNhaCC ETT in list)
                    if (ETT.So_dien_thoai.IndexOf(ETTCC.So_dien_thoai) >= 0)
                    {
                        kq.Add(new ETTNhaCC(ETT));
                    }
            }
          
            else kq = null;
            return kq;
        }
       
        public IList<ETTNhaCC> SearchLinq(ETTNhaCC ETT)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(ETT.Ten_nha_cung_cap) || x.Ten_nha_cung_cap.Contains(ETT.Ten_nha_cung_cap))
            && (string.IsNullOrEmpty(x.Dia_chi) || x.Dia_chi.Contains(ETT.Dia_chi))
            && (string.IsNullOrEmpty(x.So_dien_thoai) || x.So_dien_thoai.Contains(ETT.So_dien_thoai))).ToList();
        }

     
    }
}
