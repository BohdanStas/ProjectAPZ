using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public int ToalPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime Time { get; set; }

        public int EstablishmentId { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Establishment Establishment { get; set; }
    }
}
