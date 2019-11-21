using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Establishment : General
    {
        public virtual IEnumerable<Dish> Dishes { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Site { get; set; }


    }
}
