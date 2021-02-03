using Projekt.Modele;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projekt.Interfaces
{
    public interface IWypozyczeniaRepozytorium
    {
        Task<Wypozyczenia> DodajAsync(Wypozyczenia encja);
        Task<Wypozyczenia> EdytujAsync(Wypozyczenia encja);
        Task<Wypozyczenia> PobierzAsync(int IDKlienta);
        Task<List<Wypozyczenia>> PobierzWszystkieAsync(int IDKlienta);
        Task<List<Wypozyczenia>> PobierzWszystkieAsync(int IDKlienta, DateTime Data);
    }
    
}