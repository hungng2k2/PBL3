using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3.DTO
{
    public class MonAn
    {
        public MonAn()
        {
            this.ChiTietOrder = new HashSet<ChiTietOrder>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string id_MonAn { get; set; }
        public string TenMonAn { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string imagePath { get; set; } 
        public bool IsDeleted { get; set; }
        public virtual ICollection<ChiTietOrder> ChiTietOrder { get; set; }
    }
}
