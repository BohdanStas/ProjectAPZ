using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class User : General
    {
        public string Sername { get; set; }

        public string Patronomic { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
