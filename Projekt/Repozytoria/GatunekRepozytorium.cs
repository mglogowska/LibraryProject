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
    public class GatunekRepozytorium : IRepository<Gatunek>
    {
        private readonly BibliotekaBaza db;

        public GatunekRepozytorium(BibliotekaBaza db)
        {
            this.db = db;
        }
        public async Task<Gatunek> DodajAsync(Gatunek encja)
        {
            db.Gatunki.Add(encja);
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

        public async Task<Gatunek> EdytujAsync(Gatunek encja)
        {
            var temp = await db.Gatunki.FindAsync(encja.ID);
            temp.NazwaGatunku = encja.NazwaGatunku;

            db.Gatunki.AddOrUpdate(temp);
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

        public async Task<Gatunek> PobierzAsync(int ID)
        {
            return await db.Gatunki.FindAsync(ID);
        }

        public async Task<List<Gatunek>> PobierzWszystkieAsync()
        {
            return await db.Gatunki.ToListAsync();
        }

        public async Task<bool> UsunAsync(int ID)
        {
            var temp = await db.Gatunki.FindAsync(ID);
            db.Gatunki.Remove(temp);

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

