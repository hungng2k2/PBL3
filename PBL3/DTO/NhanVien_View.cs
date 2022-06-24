using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class NhanVien_View
    {
        public string id_NhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public String GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
