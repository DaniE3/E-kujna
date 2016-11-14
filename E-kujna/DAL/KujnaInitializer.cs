using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using E_kujna.Models;

namespace E_kujna.DAL
{
    public class KujnaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KujnaContext>
    {
        protected override void Seed(KujnaContext context)
        {
            var obroks = new List<Obrok>
            {
            new Obrok{ObrokID = 1, ObrokIme="Ручек"},
            new Obrok{ObrokID = 3, ObrokIme="Вечера"},
            new Obrok{ObrokID = 4, ObrokIme="Доручер"},
            new Obrok{ObrokID = 5, ObrokIme="Десерт"}
            };
            obroks.ForEach(o => context.Obroks.Add(o));
            context.SaveChanges();


            var kujnas = new List<Kujna>
            {
                new Kujna{KujnaID = 111, KujnaIme="Домашна"},
                new Kujna{KujnaID = 222, KujnaIme="Интернационална"},
                new Kujna{KujnaID = 333, KujnaIme="Медитеранска"}
            };
            kujnas.ForEach(o => context.Kujnas.Add(o));
            context.SaveChanges();

            var recepts = new List<Recept>
            {
                new Recept{ObrokID=1, KujnaID=111, Vreme="30 min"},
                new Recept{ObrokID=2, KujnaID=111, Vreme="45 min"},
                new Recept{ObrokID=4, KujnaID=222, Vreme="20 min"},
                new Recept{ObrokID=1, KujnaID=111, Vreme="60 min"},
                new Recept{ObrokID=3, KujnaID=333, Vreme="35 min"}
                
            };
            recepts.ForEach(o => context.Recepts.Add(o));
            context.SaveChanges();
        }
    }
}
