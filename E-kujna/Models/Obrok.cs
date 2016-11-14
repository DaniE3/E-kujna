using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public class Obrok
    {
        public int ObrokID { get; set; }
        public string ObrokIme { get; set; }

        public virtual ICollection<Recept> Recepts { get; set; }

    }
}