using Projekt.Dane;
using Projekt.Interfaces;
using Projekt.Modele;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Repozytoria
{
    public class KlientRepozytorium : IRepository<Klient>
    {
        private readonly BibliotekaBaza db = new BibliotekaBaza();

        public KlientRepozytorium()
        {
        }
        public async Task<Klient> DodajAsync(Klient encja)
        {
            db.Klienci.Add(encja);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                return null;
            }
            return encja;
        }

        public async Task<Klient> EdytujAsync(Klient encja)
        {
            var temp = await db.Klienci.FindAsync(encja.ID);

            temp.Imie = encja.Imie;
            temp.Nazwisko = encja.Nazwisko;

            db.Klienci.AddOrUpdate(temp);
            try
            {
                await db.SaveChangesAsync();
                //czekamy na wynik ale nie blokujemy gui
            }
            catch (Exception)
            {
                return null;
            }
            return temp;
        }

        public async Task<Klient> PobierzAsync(int ID)
        {
            return await db.Klienci.FindAsync(ID);
        }

        public async Task<List<Klient>> PobierzWszystkieAsync()
        {
            return await db.Klienci.ToListAsync();
        }

        public async Task<bool> UsunAsync(int ID)
        {
            var temp = await db.Klienci.FindAsync(ID);
            db.Klienci.Remove(temp);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
