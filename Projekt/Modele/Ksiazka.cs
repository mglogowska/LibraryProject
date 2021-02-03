using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    [Table("Ksiazki")]
    public class Ksiazka:Produkt
    {
        public string Tytul { get; set; }
        public int GatunekID { get; set; }
        public virtual Gatunek Gatunek { get; set; }
        public int AutorID { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual ICollection<Wypozyczenia> WypozyczeniaKsiazki { get; set; }
    }
}
