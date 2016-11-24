using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_kujna.Models
{
    public class Obrok
    {
        public int ObrokId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Recept> Recepts { get; set; }
    }
}