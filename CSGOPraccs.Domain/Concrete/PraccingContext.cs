using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGOPraccs.Domain.Entities;
using System.Data.Entity;

namespace CSGOPraccs.Domain.Concrete
{
    public class PraccingContext : DbContext
    {
        public DbSet<Pracc> Praccs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
