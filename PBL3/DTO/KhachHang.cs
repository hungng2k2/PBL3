using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        public KhachHang()
        {
            this.Order = new HashSet<Order>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string id_KhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
