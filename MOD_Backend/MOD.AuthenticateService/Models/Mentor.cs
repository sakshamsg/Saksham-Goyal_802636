using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]

        public string MentorId { get; set; }
        [StringLength(30)]
        [Column("Name")]
        public string MentorName { get; set; }
        [Column("Email")]
        public string Mentor_EmailId { get; set; }
        [Column("ContactNumber")]
        public int Mentor_PhoneNumber { get; set; }
        [Column("Password")]
        public string Mentor_Password { get; set; }
        [Column("Experience")]
        public int Mentor_YrsOfExp { get; set; }
        [Column("Skill")]
        public string Mentor_Skills { get; set; }
        [Column("Timeslot")]
        public string Mentor_Timeslot { get; set; }
    }
}
