using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOPraccs.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual List<Pracc> Praccs { get; set; }
    }
}
