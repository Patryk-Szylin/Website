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
        private PraccingContext _context = new PraccingContext();

        public IEnumerable<Pracc> Praccs
        {
            get { return _context.Praccs; }
        }

        public void Add(Pracc practiceGame)
        {
            if (practiceGame != null)
            {
                _context.Praccs.Add(practiceGame);
                _context.SaveChanges();
            }
        }
    }
}
