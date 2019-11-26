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
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _mentorRepository;
        public MentorController(IMentorRepository mt_repository)
        {
            _mentorRepository = mt_repository;
        }


        // GET: api/Mentor
        [HttpGet]
        [Route("MentorGetAll")]
        public List<Mentor> Get()
        {
            return _mentorRepository.Mentor_GetAll();
        }


        // POST: api/Mentor
        [HttpPost]
        [Route("MentorAdd")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _mentorRepository.Mentor_Add(item);
            return Ok("Record Added..");
        }



        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("MentorUpdate")]
        public void Put(Mentor item)
        {
            _mentorRepository.Mentor_Update(item);
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("MentorDelete/{id}")]
        public void Delete(string id)
        {
            _mentorRepository.Mentor_Delete(id);
        }
    }
}
