using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Order
    {
        public Order()
        {
            this.ChiTietOrder = new HashSet<ChiTietOrder>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        public string id_Order { get; set; }
        public string id_KhachHang { get; set; }
        public string id_NhanVien { get; set; }
        [ForeignKey("id_KhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        [ForeignKey("id_NhanVien")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<ChiTietOrder> ChiTietOrder { get; set; }
        
    }
}
