using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UserContext _context;
        public StudentRepository(UserContext context)
        {
            _context = context;
        }
        public void Student_Add(Student item)
        {
            _context.Students.Add(item);
            _context.SaveChanges();
        }

        public void Student_Delete(string id)
        {
            var item = _context.Students.Find(id);
            _context.Students.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<Mentor> SearchMentor(string skill)
        {
            var obj = _context.Mentors.Where(s => s.Mentor_Skills == skill).ToList();
            return obj;
        }

        public List<Student> Student_GetAll()
        {
            return _context.Students.ToList();
        }

        public void Student_Update(Student item)
        {
            _context.Entry(item).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
