using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {
            this.HoaDon = new HashSet<HoaDon>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string id_NhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        [StringLength(10)]
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        public string ChucVu { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
