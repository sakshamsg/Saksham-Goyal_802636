using MOD.TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Repository
{
    public interface ITechnologyRepository
    {
        void Technology_Add(Technology item);
        List<Technology> Technology_GetAll();
        void Technology_Update(Technology item);
        void Technology_Delete(int id);
    }
}
