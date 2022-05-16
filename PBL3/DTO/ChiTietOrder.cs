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
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)][Required]
        public int id_ChiTietOrder { get; set; }
        public string id_Order { get; set; }
        public string id_MonAn { get; set; }
        public int SoLuong { get; set; }
        [ForeignKey("id_MonAn")]
        public virtual Order Order { get; set; }
        [ForeignKey("id_MonAn")]
        public virtual MonAn MonAn { get; set; }
    }
}
