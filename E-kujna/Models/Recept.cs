using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public class Recept
    {
        public int ReceptID { get; set; }
        public int ObrokID { get; set; }
        public int KujnaID { get; set; }

       // public string Sostojki { get; set; }
        public string Vreme { get; set; }
       // public string ImgPath { get; set; }

        public virtual Obrok Obrok { get; set; }
        public virtual Kujna Kujna  { get; set; }
    }
}