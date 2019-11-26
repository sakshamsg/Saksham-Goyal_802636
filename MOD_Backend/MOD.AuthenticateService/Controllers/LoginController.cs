using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.AuthenticateService.Models;
using MOD.AuthenticateService.Repository;

namespace MOD.AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;
        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Validate/{id}/{pwd}")]
        public Token Get(string id, string pwd)
        { 
            if(_repository.StudentLogin(id,pwd) != null)
            {
                Student response = _repository.StudentLogin(id, pwd);
                return new Token() { message = "User", token = response.Student_Name };
            }
            else if (_repository.MentorLogin(id, pwd) != null)
            {
                Mentor response = _repository.MentorLogin(id, pwd);
                return new Token() { message = "Mentor", token = response.MentorName };
            }
            else if (id=="123" && pwd=="admin")
            {
                return new Token() { message = "Admin", token = "Admin" };
            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };
            }
        }
        
        
    }
}
