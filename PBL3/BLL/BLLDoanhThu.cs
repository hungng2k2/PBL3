using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public dynamic ThongKe(DateTime start, DateTime end)
        {
            start = start.Date;
            end = end.Date;
            var q = db.HoaDon
                .Where(hd => DbFunctions.TruncateTime(hd.NgayLap) >= start && DbFunctions.TruncateTime(hd.NgayLap) <= end)
                .GroupBy(hd => hd.NgayLap)
                .Select(gr => new
                {
                    Ngay = gr.Key,
                    SoLuongHoaDon = gr.Count(),
                    TongNhap = gr.Sum(hd => hd.Order.TongNhap),
                    TongBan = gr.Sum(hd => hd.Order.TongTien),
                    TienLoi = gr.Sum(hd => hd.Order.TongTien) - gr.Sum(hd => hd.Order.TongNhap),
                });
            return q.ToList();
        }

    }
}
