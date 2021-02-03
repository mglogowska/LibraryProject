using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Modele
{
    public abstract class Produkt
    {
        public int? ID { get; set; }    //? - nullable int
        public int Ilosc { get; set; }
        public DateTime DataDodania { get; set; }
        public DateTime DataModyfikacji { get; set; }
    }
}
