using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void Payment_Add(Payment item)
        {
            _context.Payments.Add(item);
            _context.SaveChanges();
        }

        public Payment GetById(int id)
        {
            return _context.Payments.Find(id);
            //return _context.Employees.SingleOrDefault(i=>i.Eid==id);
        }

        public List<Payment> Payment_GetAll()
        {
            return _context.Payments.ToList();
        }
    }
}
