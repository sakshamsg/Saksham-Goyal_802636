using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Models;
using MOD.PaymentService.Repository;

namespace MOD.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _pRepository;
        public PaymentController(IPaymentRepository p_repository)
        {
            _pRepository = p_repository;
        }


        // GET: api/Payment
        [HttpGet]
        [Route("PymtGetAll")]
        public List<Payment> Get()
        {
            return _pRepository.Payment_GetAll();
        }

        // GET: api/Payment/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Payment Get(int id)
        {
            return _pRepository.GetById(id);
        }

        // POST: api/Payment
        [HttpPost]
        [Route("AddPayment")]
        public IActionResult Post([FromBody] Payment item)
        {
            _pRepository.Payment_Add(item);
            return Ok("Record Added..");
        }


    }
}
