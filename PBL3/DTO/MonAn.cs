using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3.DTO
{
    public class MonAn
    {
        public MonAn()
        {
            this.Order = new HashSet<Order>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string id_MonAn { get; set; }
        public string TenMonAn { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public string imagePath { get; set; } 
        public virtual ICollection<Order> Order { get; set; }
    }
}
