using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [Column("ID")]
        public int Payment_id { get; set; }
        [Column("S_ID")]
        public string Student_id { get; set; }
        //[Column("Name")]
        public double Amount { get; set; }
        [Column("M_ID")]
        public string Mentor_id { get; set; }
        [Column("MtrAmount")]
        public double Mentor_Amount { get; set; }
    }
}
