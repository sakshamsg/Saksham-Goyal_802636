using Microsoft.EntityFrameworkCore;
using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Context
{
    public class UserContext: DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-C54CLC7\SAKSHAM; 
        //        Database= MOD_Db;
        //        Trusted_Connection=True;");
        //}
        ////DbSet
        public UserContext(DbContextOptions<UserContext> options):base(options)
        { 

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
    }
}
