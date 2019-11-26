using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _tRepository;
        public TrainingController(ITrainingRepository t_repository)
        {
            _tRepository = t_repository;
        }

        // GET: api/Training
        [HttpGet]
        [Route("TrngGetAll")]
        public List<Training> Get()
        {
            return _tRepository.Training_GetAll();
        }

        // GET: api/Training/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{sts}")]
        public List<Training> Get(string sts)
        {
            return _tRepository.GetByStatus(sts);
        }

        // POST: api/Training
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _tRepository.Training_Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update")]
        public void Put(Training item)
        {
            _tRepository.Update(item);
        }

    }
}
