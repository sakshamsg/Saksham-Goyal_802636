using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        
        public void Mentor_Add(Mentor item)
        {
            _context.Mentors.Add(item);
            _context.SaveChanges();
        }

        public void Mentor_Delete(string id)
        {
            var item = _context.Mentors.Find(id);
            _context.Mentors.Remove(item);
            _context.SaveChanges();
        }

        public List<Mentor> Mentor_GetAll()
        {
            return _context.Mentors.ToList();
        }

        public void Mentor_Update(Mentor item)
        {
            _context.Entry(item).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
