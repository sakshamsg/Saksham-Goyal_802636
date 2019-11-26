using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public interface IMentorRepository
    {
        void Mentor_Add(Mentor item);
        List<Mentor> Mentor_GetAll();
        void Mentor_Update(Mentor item);
        void Mentor_Delete(string id);
    }
}
