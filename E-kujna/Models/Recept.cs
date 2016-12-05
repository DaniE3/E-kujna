using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_kujna.Models;

namespace E_kujna.Models
{
    public class Recept
    {
        public int ReceptId { get;  set; }
        public int ObrokId { get; set; }
        public int KujnaId { get; set; }
    //    public int SostojkaId { get; set; }

      //  public int GotvacId { get; set; }
        public string ImeR { get; set; }
        public string UrlSlika { get; set; }
     //   public int Cena { get; set; }
       public string Tekst { get; set; }
       public string Sostojki { get; set; }

     //   public string UrlTekst { get; set; }
        public Obrok Obrok { get; set; }
        public Kujna Kujna { get; set; }

        public virtual ICollection<Sostojka> Sostojkas { get; set; }

       

        /****/
       // public IEnumerable<Obrok> ObrokList { get; set; }
        //public IEnumerable<Kujna> KujnaList { get; set; }
       // public IEnumerable<Sostojka> SostojkaList { get; set; }



    }
}