using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repository;

namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _techRepository;
        public TechnologyController(ITechnologyRepository t_repository)
        {
            _techRepository = t_repository;
        }


        // GET: api/Technology
        [HttpGet]
        [Route("TechGetAll")]
        public List<Technology> Get()
        {
            return _techRepository.Technology_GetAll();
        }

        // GET: api/Technology/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Technology
        [HttpPost]
        [Route("AddTech")]
        public IActionResult Post([FromBody] Technology item)
        {
            _techRepository.Technology_Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        [Route("TechUpdate")]
        public void Put(Technology item)
        {
            _techRepository.Technology_Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("TechDelete/{id}")]
        public void Delete(int id)
        {
            _techRepository.Technology_Delete(id);
        }
    }
}
