using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    [Table("Gatunki")]
    public class Gatunek
    {
        public int ID { get; set; }
        public string NazwaGatunku { get; set; }
    }
}
