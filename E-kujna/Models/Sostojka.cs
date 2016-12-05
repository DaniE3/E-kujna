using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public class Sostojka
    {
        public int SostojkaId { get; set; }
        public string ImeS { get; set; }

       public virtual ICollection<Recept> Recepts { get; set; }
    }
}