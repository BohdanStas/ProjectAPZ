using DAL.Entity;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    class EstablishmentRepository : IRepository<Establishment>
    {
        private EFDbContext db;
        public EstablishmentRepository(EFDbContext context)
        {
            db = context;
        }

        public void Create(Establishment item)
        {
            db.Establishments.Add(item);
        }

        public void Delete(int id)
        {
            db.Establishments.Remove(db.Establishments.Find(id));
        }

        public IEnumerable<Establishment> Find(Func<Establishment, bool> predicate)
        {
            return db.Establishments.Where(predicate).ToList();
        }

        public Establishment Get(int id)
        {
            return db.Establishments.Find(id);
        }

        public IEnumerable<Establishment> GetAll()
        {
            return db.Establishments;
        }

        public void Update(Establishment item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
