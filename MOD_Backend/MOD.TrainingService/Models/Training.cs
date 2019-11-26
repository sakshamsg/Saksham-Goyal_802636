using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        [Column("ID")]
        public int Training_id { get; set; }
       // [Column("S_ID")]
        public string Student_id { get; set; }
        [Column("Name")]
        public string Tech_name { get; set; }
       // [Column("M_ID")]
        public string Mentor_id { get; set; }
        
        public string Timeslot { get; set; }

        public string Status { get; set; }

        public string Progress { get; set; }

        public string Rating { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
