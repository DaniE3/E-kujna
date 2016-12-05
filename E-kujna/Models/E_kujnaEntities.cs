using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_kujna.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace E_kujna.Models
{
    public class E_kujnaEntities : DbContext
    {
        public DbSet<Recept> Recepts { get; set; }
        public DbSet<Obrok> Obroks { get; set; }
        public System.Data.Entity.DbSet<E_kujna.Models.Kujna> Kujnas { get; set; }

        public DbSet<E_kujna.Models.Sostojka> Sostojkas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Recept>()
                .HasMany(c => c.Sostojkas).WithMany(i => i.Recepts)
                .Map(t => t.MapLeftKey("ReceptId")
                    .MapRightKey("SostojkaId")
                    .ToTable("ReceptSostojka"));
        }



    }
}