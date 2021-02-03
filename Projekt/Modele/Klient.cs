using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    [Table("Klienci")]
    public class Klient
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public virtual ICollection<Wypozyczenia> WypozyczeniaKlienta { get; set; }

    }
}
