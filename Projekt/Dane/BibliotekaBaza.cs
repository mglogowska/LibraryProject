using Projekt.Modele;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Dane
{
    public class BibliotekaBaza:DbContext
    {
        public BibliotekaBaza(): base("name=myDatabaseConnection") {} //wywołuje bazowy konstruktor
        public DbSet<Autor> Autorzy { get; set; }
        public DbSet<Gatunek> Gatunki { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Wypozyczenia> Wypozyczenia { get; set; }

    }
}
