using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietOrder
    {
        [Key][Required]
        public string id_ChiTietOrder { get; set; }
        public string id_Order { get; set; }
        public string id_MonAn { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        [ForeignKey("id_Order")]
        public virtual Order Order { get; set; }
        [ForeignKey("id_MonAn")]
        public virtual MonAn MonAn { get; set; }
    }
}
