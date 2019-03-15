using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using F1WebApp_CodeFirstSeededDb.Models;

namespace F1WebApp_CodeFirstSeededDb.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("F1DbSeeded")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Constructor> Constructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}