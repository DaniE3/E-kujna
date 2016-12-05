using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public partial class Obrok
    {
        public int ObrokId { get; set; }
        public string ImeO { get; set; }
     
       public List<Recept> Recepts { get; set; } 
     
       
    }
}