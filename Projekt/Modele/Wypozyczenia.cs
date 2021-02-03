using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    [Table("Wypozyczenia")]
    public class Wypozyczenia
    {
        public int ID { get; set; }
        public int KlientID { get; set; }
        public virtual Klient Klient { get; set; }
        public int KsiazkaID { get; set; }
        public virtual Ksiazka Ksiazka { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime DataOddania { get; set; }

    }
}
