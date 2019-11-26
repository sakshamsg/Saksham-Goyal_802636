using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]

        public string StudentId { get; set; }
        [StringLength(30)]
        [Column("Name")]
        public string Student_Name { get; set; }
        [Column("Email")]
        public string Student_EmailId { get; set; }
        [Column("ContactNumber")]
        public int Student_PhoneNumber { get; set; }
        [Column("Password")]
        public string Student_Password { get; set; }
    }
}
