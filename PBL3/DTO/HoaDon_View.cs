using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class HoaDon_View
    {
        public string id_HoaDon { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public double TongTien { get; set; }
    }
}
