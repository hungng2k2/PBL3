using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLDoanhThu
    {
        QLCHTAN db = new QLCHTAN();
        private static BLLDoanhThu _Instance;

        public static BLLDoanhThu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLDoanhThu();
                }
                return _Instance;
            }
            private set { }
        }

        private BLLDoanhThu()
        {

        }
        public dynamic ThongKe(DateTime tungay, DateTime denngay)
        {
            // thống kê doanh thu từ ngày đến ngày
            var query = from hd in db.HoaDon where hd.NgayLap >= tungay && hd.NgayLap <= denngay
                        group hd by hd.NgayLap into g
                        select new
                        {
                            Ngay = g.Key,
                            SoLuongHoaDon = g.Count(),
                            TongNhap = g.Sum(hd => hd.Order.TongNhap),
                            TongBan = g.Sum(hd => hd.Order.TongTien),
                            TienLoi = g.Sum(hd => hd.Order.TongTien) - g.Sum(hd => hd.Order.TongNhap),
                        };
            return query.ToList();
        }

    }
}
