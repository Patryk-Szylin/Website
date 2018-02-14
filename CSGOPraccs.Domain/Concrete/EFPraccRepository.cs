using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGOPraccs.Domain.Abstract;
using CSGOPraccs.Domain.Entities;

namespace CSGOPraccs.Domain.Concrete
{
    public class EFPraccRepository : IPraccRepository
    {
        private EFDbContext _context = new EFDbContext();

        public IEnumerable<Pracc> Praccs
        {
            get { return _context.Praccs; }
        }
    }
}
