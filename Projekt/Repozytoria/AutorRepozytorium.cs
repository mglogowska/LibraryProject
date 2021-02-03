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
    public class AutorRepozytorium : IRepository<Autor>
    {
        private readonly BibliotekaBaza db;

        public AutorRepozytorium(BibliotekaBaza db)
        {
            this.db = db;
        }
        public async Task<Autor> DodajAsync(Autor encja)
        {
            db.Autorzy.Add(encja);
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

        public async Task<Autor> EdytujAsync(Autor encja)
        {
            var temp = await db.Autorzy.FindAsync(encja.ID);

            temp.Imie = encja.Imie;
            temp.Nazwisko = encja.Nazwisko;

            db.Autorzy.AddOrUpdate(temp);
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

        public async Task<Autor> PobierzAsync(int ID)
        {
            return await db.Autorzy.FindAsync(ID);
        }

        public async Task<List<Autor>> PobierzWszystkieAsync()
        {
            return await db.Autorzy.ToListAsync();
        }

        public async Task<bool> UsunAsync(int ID)
        {
            var temp = await db.Autorzy.FindAsync(ID);
            db.Autorzy.Remove(temp);

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

