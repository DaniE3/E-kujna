using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public class Recept
    {
   
        public int ReceptId { get; set; }
        public int ObrokId { get; set; }
        public int KuvarId { get; set; }
        public string Ime { get; set; }

        public string AlbumArtUrl { get; set; }
        public Obrok Obrok { get; set; }
        public Kuvar Kuvar { get; set; }

    }
}