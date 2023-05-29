using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ThongKeBUL : IThongKeBUL
    {
        IChiTietHoaDonBUL bllcthd = new ChiTietHoaDonBUL();
        ICTPNBUL bllctpn = new CTPNBUL();
        IProductBUL bllsp = new ProductBUL();
        INhanVienBUL bllkh = new NhanVienBUL();
        ICategoryBUL ctg = new CategoryBUL();

        public int Tongsp()
        {
            return bllcthd.getAll().Sum(x => x.So_luong);
        }

        public decimal Tongdaonhthu()
        {
            return (from cthd in bllcthd.getAll()
                    join ctpn in bllctpn.getAll() on cthd.Ma_san_pham equals ctpn.MaSanPham
                    select new
                    {
                        Result = cthd.Gia_ban - Convert.ToDecimal(ctpn.DonGia) * cthd.So_luong
                    }).Sum(x => (x.Result));
        }

        public int Tongkhdk()
        {
            return bllkh.getAll().Count() - 1;
        }
        public int TongLh()
        {
            return ctg.getAll().Count() - 1;
        }
    }
}
