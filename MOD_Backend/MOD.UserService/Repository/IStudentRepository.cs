using MOD.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Repository
{
    public interface IStudentRepository
    {
        void Student_Add(Student item);
        List<Student> Student_GetAll();
        void Student_Update(Student item);
        void Student_Delete(string id);

        IEnumerable<Mentor> SearchMentor(string skill);
    }
}
