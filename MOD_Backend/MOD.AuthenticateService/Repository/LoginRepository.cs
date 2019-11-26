using MOD.AuthenticateService.Context;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string mid, string pwd)
        {
            return _context.Mentors.SingleOrDefault(data => data.MentorId == mid && data.Mentor_Password == pwd);
            //if (obj != null)
            //    return true;
            //else
            //    return false;
        }

        public Student StudentLogin(string uid, string pwd)
        {
            return _context.Students.SingleOrDefault(data => data.StudentId == uid && data.Student_Password == pwd);
            //if (obj != null)
            //    return true;
            //else
            //    return false;
        }
    }
}
