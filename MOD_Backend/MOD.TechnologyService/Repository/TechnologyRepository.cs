using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repository
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly TechnologyContext _context;
        public TechnologyRepository(TechnologyContext context)
        {
            _context = context;
        }

        public void Technology_Add(Technology item)
        {
            _context.Technologies.Add(item);
            _context.SaveChanges();
        }

        public void Technology_Delete(int id)
        {
            var item = _context.Technologies.Find(id);
            _context.Technologies.Remove(item);
            _context.SaveChanges();
        }

        public List<Technology> Technology_GetAll()
        {
            return _context.Technologies.ToList();
        }

        public void Technology_Update(Technology item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
