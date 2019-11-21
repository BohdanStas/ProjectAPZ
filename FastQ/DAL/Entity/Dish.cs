using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Dish : General
    {

        public int Price { get; set; }

        public string Category { get; set; }

        public int EstablishmentId { get; set; }

        public virtual Establishment Establishment { get; set; }

    }
}
