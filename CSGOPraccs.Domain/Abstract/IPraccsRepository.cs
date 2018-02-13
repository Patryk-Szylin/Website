using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGOPraccs.Domain.Entities;

namespace CSGOPraccs.Domain.Abstract
{
    public interface IPraccsRepository
    {
        IEnumerable<Pracc> Praccs { get; }
    }
}
