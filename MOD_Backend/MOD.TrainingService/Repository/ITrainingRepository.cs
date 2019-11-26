using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Repository
{
    public interface ITrainingRepository
    {
        void Training_Add(Training item);
        List<Training> Training_GetAll();
        List<Training> GetByStatus(string sts);
        void Update(Training item);
    }
}
