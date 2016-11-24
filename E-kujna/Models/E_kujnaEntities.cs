﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_kujna.Models
{
    public class E_kujnaEntities : DbContext
    {
        public DbSet<Recept>Recepts  { get; set; }
        public DbSet<Obrok> Obroks { get; set; }

        public System.Data.Entity.DbSet<E_kujna.Models.Kuvar> Kuvars { get; set; }
    }
}