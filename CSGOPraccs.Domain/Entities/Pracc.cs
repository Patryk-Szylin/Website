﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOPraccs.Domain.Entities
{
    public class Pracc
    {
        public int PraccID { get; set; }
        public string Map { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
