using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_kujna.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<E_kujnaEntities>
    {
         protected override void Seed(E_kujnaEntities context)
        {
            var obroks = new List< Obrok>
            {
                new Obrok { Name = "Супи" },
                new Obrok { Name = "Чорби" },
                new Obrok { Name = "Десерт" },
                new Obrok { Name = "Предјадење" },
                new Obrok { Name = "Главно јадење" }
            };

            var kuvars = new List<Kuvar>
            {
                new Kuvar { Ime = "Timot na E-kujna" }
                
            };
             new List<Recept>
            {
                new Recept { Ime = "naslov 1", Obrok = obroks.Single(o => o.Name == "Супи"),  Kuvar = kuvars.Single(a => a.Ime == "Timot na E-kujna"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                
            }.ForEach(a => context.Recepts.Add(a));
        }
    }
}



    
