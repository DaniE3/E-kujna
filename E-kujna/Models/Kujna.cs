using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_kujna.Models
{
    public class Kujna
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KujnaID { get; set; }
        public string KujnaIme { get; set; }
       

        public virtual ICollection<Recept> Recepts { get; set; }
    }
}