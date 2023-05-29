using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ICTPNBUL
    {
        int Insert(ETTCTPN cls);
        int Delete(int PhieuNhapID);
        int Update(ETTCTPN cls);
        IList<ETTCTPN> getAll();

        int checkChiTietPN_ID(int classID);

        //void KetXuatWord(ETTCTPN mapn, string tennv, string ncc, string templatePath, string exportPath);
    }
}
