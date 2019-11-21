using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        public EFDbContext(DbContextOptions<EFDbContext> options)
        : base(options)
        {
        }
    }

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDbContext>
    {
        public EFDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<EFDbContext>(); 
            optionBuilder.UseLazyLoadingProxies().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FastQDB;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DAL"));
            return new EFDbContext(optionBuilder.Options);
        }
    }
}
