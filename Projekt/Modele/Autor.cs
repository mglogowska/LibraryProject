using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    [Table("Autorzy")]
    public class Autor
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

    }
}
