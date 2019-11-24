using DAL.Entity;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class EFUnitOfWork : IUnitOfWork
    {
        private EFDbContext db;
        private EstablishmentRepository establishmentRepository;
        private UserRepository userRepository;
        private DishRepository dishRepository;
        private OrderRepository orderRepository;
     
        public EFUnitOfWork(DbContextOptions<EFDbContext> options)
        {
            //var optionBuilder = new DbContextOptionsBuilder<EFDbContext>();
            //optionBuilder.UseLazyLoadingProxies().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FastQDB;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DAL"));
            db= new EFDbContext(options);
           
        }
        public IRepository<Dish> Dishes
        {
            get
            {
               
                if (dishRepository == null)
                    dishRepository = new DishRepository(db);
                return dishRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public IRepository<Establishment> Establishments
        {
            get
            {
                if (establishmentRepository == null)
                    establishmentRepository = new EstablishmentRepository(db);
                return establishmentRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
