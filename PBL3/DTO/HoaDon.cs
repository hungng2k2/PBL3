using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class HoaDon
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string id_HoaDon { get; set; }
        public string id_Order { get; set; }
        public DateTime NgayLap { get; set; }        
        public bool IsDelete { get; set; }
        [ForeignKey("id_Order")]
        public virtual Order Order { get; set; }
    }
}
