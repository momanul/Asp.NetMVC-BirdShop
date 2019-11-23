using BirdShopMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BirdShopMvcProject.DAL
{
    public class BirdShopContext:DbContext
    {
        public BirdShopContext():base("BirdShopContext")
        { }
        public DbSet<Dealers> Dealers { get; set; }
        public DbSet<Birds> Birds { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}