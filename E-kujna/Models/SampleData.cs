using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using E_kujna.Models;

namespace MvcMusicStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<E_kujnaEntities>
   //     public class SampleData:DropCreateDatabaseAlways<E_kujnaEntities>
    {
        protected override void Seed(E_kujnaEntities context)
        {
            var obroks = new List<Obrok>
            {
                new Obrok{ ImeO = "Поручек" },
                new Obrok{ ImeO = "Ручек" },
                new Obrok{ ImeO = "Вечера" },
                new Obrok{ ImeO = "Супи" },
                new Obrok{ ImeO = "Чорби" }
            };
            var kujnas = new List<Kujna>
            {
                new Kujna{ ImeK = "Национална" },
                new Kujna{ ImeK = "Медитеранска" },
                new Kujna{ ImeK = "Интернационална" },
                new Kujna{ ImeK = "Вегетаријанска" }
                
            };
            /*
            var sostojkas = new List<Sostojka>
            {
                new Sostojka{ ImeS = "Масло" },
                new Sostojka{ ImeS = "Млеко" },
                new Sostojka{ ImeS = "Шеќер" },
                new Sostojka{ ImeS = "Моркови" }
                
            };
            
           */

            new List<Recept>
            {
                new Recept { ImeR = "Recept 1", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png",
                    Tekst=@"Ставете ги измешани брашното, солта и прашокот за печење во сад за месење и направете вдлабнатина во средината. Истурете 300 мл од млаката вода, издробете го квасецот и додадете го шеќерот. Оставете да се активира, па додадете го јајцето, киселината и маслото и замесете со остатокот млака вода глатко тесто. Покријте го и оставете го на топло да нарасти.

Од нараснатото тесто кинете мали парчиња, малку поголеми од орев и сукајте ги овално, па на крајот засечете со нож, а на другиот ставете од филот (испасирано сирење и жолчка) и завиткајте кифла.

" },

                new Recept { ImeR = "Recept 4", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png",
                    Tekst=@" 4 4 4 Ставете ги измешани брашното, солта и прашокот за печење во сад за месење и направете вдлабнатина во средината. Истурете 300 мл од млаката вода, издробете го квасецот и додадете го шеќерот. Оставете да се активира, па додадете го јајцето, киселината и маслото и замесете со остатокот млака вода глатко тесто. Покријте го и оставете го на топло да нарасти.

Од нараснатото тесто кинете мали парчиња, малку поголеми од орев и сукајте ги овално, па на крајот засечете со нож, а на другиот ставете од филот (испасирано сирење и жолчка) и завиткајте кифла.",
                },
                new Recept { ImeR = "Recept 5", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder4.png",
                
                Tekst=@" 5 5 5 5 Ставете ги измешани брашното, солта и прашокот за печење во сад за месење и направете вдлабнатина во средината. Истурете 300 мл од млаката вода, издробете го квасецот и додадете го шеќерот. Оставете да се активира, па додадете го јајцето, киселината и маслото и замесете со остатокот млака вода глатко тесто. Покријте го и оставете го на топло да нарасти.

Од нараснатото тесто кинете мали парчиња, малку поголеми од орев и сукајте ги овално, па на крајот засечете со нож, а на другиот ставете од филот (испасирано сирење и жолчка) и завиткајте кифла."},

                new Recept { ImeR = "Recept 6", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 7", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Медитеранска"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 8", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder4.png" },
                new Recept { ImeR = "Recept 9", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 10", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Медитеранска"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 11", Obrok = obroks.Single(o => o.ImeO == "Поручек"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 12", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Вегетаријанска"),UrlSlika = "/Content/Images/placeholder5.png" },
                new Recept { ImeR = "Recept 13", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 14", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Интернационална"), UrlSlika = "/Content/Images/placeholder4.png" },
                new Recept { ImeR = "Recept 15", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 16", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },
                new Recept { ImeR = "Recept 17", Obrok = obroks.Single(o => o.ImeO == "Поручек"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder3.png" },

                new Recept { ImeR = "Recept 2", Obrok = obroks.Single(o => o.ImeO == "Вечера"),Kujna = kujnas.Single(k => k.ImeK == "Национална"), UrlSlika = "/Content/Images/placeholder.gif" },
                new Recept { ImeR = "Recept 3", Obrok = obroks.Single(o => o.ImeO == "Чорби"), Kujna = kujnas.Single(k => k.ImeK == "Национална"),UrlSlika = "/Content/Images/placeholder.gif" },
            }.ForEach(r => context.Recepts.Add(r));
        }
    }
}