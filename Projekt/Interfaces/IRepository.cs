using Projekt.Dane;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Interfaces
{
    public interface IRepository<T> //interface generyczny
    {
        Task<bool> UsunAsync(int ID);
        Task<T> PobierzAsync(int ID);
        Task<List<T>> PobierzWszystkieAsync();
        Task<T> DodajAsync(T encja);
        Task<T> EdytujAsync(T encja);
    }
}
