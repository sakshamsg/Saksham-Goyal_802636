using Microsoft.EntityFrameworkCore;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Context
{
    public class LoginContext: DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
                
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
    }
}
