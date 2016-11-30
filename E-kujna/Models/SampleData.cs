using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using E_kujna.Models;

namespace MvcMusicStore.Models
{
   // public class SampleData : DropCreateDatabaseIfModelChanges<E_kujnaEntities>
        public class SampleData:DropCreateDatabaseAlways<E_kujnaEntities>
    {
        protected override void Seed(E_kujnaEntities context)
        {
            var obroks = new List<Obrok>
            {
                new Obrok{ ImeO = "Поручек" },
                new Obrok{ ImeO = "Rucek" },
                new Obrok{ ImeO = "Vecera" },
                new Obrok{ ImeO = "Supi" },
                new Obrok{ ImeO = "Corbi" }
            };
            var kujnas = new List<Kujna>
            {
                new Kujna{ ImeK = "Национална" },
                new Kujna{ ImeK = "Медитеранска" },
                new Kujna{ ImeK = "Интернационална" },
                new Kujna{ ImeK = "Вегетаријанска" }
                
            };


           

            new List<Recept>
            {
                new Recept { ImeR = "Recept 1", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 4", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 5", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder4.png" },
                new Recept { ImeR = "Recept 6", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 7", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Медитеранска"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 8", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder4.png" },
                new Recept { ImeR = "Recept 9", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 10", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Медитеранска"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 11", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 12", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Вегетаријанска"),UrlSlika = "/Content/Images/placeholder5.png" },
                new Recept { ImeR = "Recept 13", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 14", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Интернационална"), UrlSlika = "/Content/Images/placeholder4.png" },
                new Recept { ImeR = "Recept 15", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 16", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },


                new Recept { ImeR = "Recept 2", Obrok = obroks.Single(o => o.ImeO == "Vecera"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder.gif" },
                new Recept { ImeR = "Recept 3", Obrok = obroks.Single(o => o.ImeO == "Corbi"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder.gif" },
            }.ForEach(r => context.Recepts.Add(r));
        }
    }
}