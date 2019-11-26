using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
    public interface ILoginRepository
    {
        Student StudentLogin(string uid, string pwd);
        Mentor MentorLogin(string mid, string pwd);
    }
}
