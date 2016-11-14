using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_kujna.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace E_kujna.DAL
{
    public class KujnaContext : DbContext

    {
        public KujnaContext() : base("KujnaContext")
        {
        }
        
        public DbSet<Obrok> Obroks { get; set; }
        public DbSet<Recept> Recepts { get; set; }
        public DbSet<Kujna> Kujnas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}