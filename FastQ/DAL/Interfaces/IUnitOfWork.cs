using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Establishment> Establishments { get; }
        IRepository<Dish> Dishes { get; }
        IRepository<Order> Orders { get; }

        void Save();

    }
}
