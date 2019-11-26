using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {

        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }

        public List<Training> GetByStatus(string sts)
        {
            return _context.Trainings.Where(s => s.Status == sts).ToList();
        }

        public void Training_Add(Training item)
        {
            _context.Trainings.Add(item);
            _context.SaveChanges();
        }

        public List<Training> Training_GetAll()
        {
            return _context.Trainings.ToList();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
