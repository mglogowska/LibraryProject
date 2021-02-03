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
    public class KsiazkaRepozytorium : IRepository<Ksiazka>
    {
        private readonly BibliotekaBaza db = new BibliotekaBaza();

        public KsiazkaRepozytorium()
        {

        }
        public async Task<Ksiazka> DodajAsync(Ksiazka encja)
        {
            encja.DataDodania = DateTime.Now;
            db.Ksiazki.Add(encja);
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

        public async Task<Ksiazka> EdytujAsync(Ksiazka encja)
        {
            var temp = await db.Ksiazki.FindAsync(encja.ID);

            temp.Tytul = encja.Tytul;
            temp.GatunekID = encja.GatunekID;
            temp.AutorID = encja.AutorID;
            temp.DataModyfikacji = DateTime.Now;

            db.Ksiazki.AddOrUpdate(temp);
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

        public async Task<Ksiazka> PobierzAsync(int ID)
        {
            return await db.Ksiazki.FindAsync(ID);
        }

        public async Task<List<Ksiazka>> PobierzWszystkieAsync()
        {
            return await db.Ksiazki.ToListAsync();
        }

        public async Task<bool> UsunAsync(int ID)
        {
            var temp = await db.Ksiazki.FindAsync(ID);
            db.Ksiazki.Remove(temp);

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
