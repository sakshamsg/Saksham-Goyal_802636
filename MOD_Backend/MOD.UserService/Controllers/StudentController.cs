using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using MOD.UserService.Repository;

namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository st_repository)
        {
            _studentRepository = st_repository;
        }


        // GET: api/Student
        [HttpGet]
        [Route("StudentGetAll")]
        public List<Student> Get()
        {
            return _studentRepository.Student_GetAll();
        }

        [HttpGet]
            [Route("Search/{skill}")]
            public IEnumerable<Mentor> Get(string skill)
        {
            return _studentRepository.SearchMentor(skill);
        }



        // POST: api/Student
        [HttpPost]
        [Route("StudentAdd")]
        public IActionResult Post([FromBody] Student item)
        {
            _studentRepository.Student_Add(item);
            return Ok("Record Added..");
        }



        // PUT: api/Student/5
        [HttpPut("{id}")]
        [Route("StudentUpdate")]
        public void Put(Student item)
        {
            _studentRepository.Student_Update(item);
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("StudentDelete/{id}")]
        public void Delete(string id)
        {
            _studentRepository.Student_Delete(id);
        }
    }
}
