using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSGOPraccs.Domain.Entities;

namespace CSGOPraccs.WebUI.Models
{
    public class PraccListViewModel
    {
        public IEnumerable<Pracc> Praccs { get; set; }
    }
}