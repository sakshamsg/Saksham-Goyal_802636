using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    [Table("Technology")]
    public class Technology
    {
        [Key]
        [Column("ID")]
        public int Tech_id { get; set; }
        [StringLength(30)]
        [Column("Name")]
        public string Tech_name { get; set; }
        //[Column("Name")]
        public string TOC { get; set; }
        [Column("Fees")]
        public int Tech_Fees { get; set; }
        [Column("Duration")]
        public int Tech_Duration { get; set; }
    }
}
