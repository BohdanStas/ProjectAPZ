using DAL.Entity;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    class DishRepository : IRepository<Dish>
    {
        private EFDbContext db;

        public DishRepository(EFDbContext context)
        {
            db = context;
        }

        public void Create(Dish item)
        {
            db.Dishes.Add(item);
        }

        public void Delete(int id)
        {
            db.Dishes.Remove(db.Dishes.Find(id));
        }

        public IEnumerable<Dish> Find(Func<Dish, bool> predicate)
        {
            return db.Dishes.Where(predicate).ToList();
        }

        public Dish Get(int id)
        {
            return db.Dishes.Find(id);
        }

        public IEnumerable<Dish> GetAll()
        {
            return db.Dishes;
        }

        public void Update(Dish item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
