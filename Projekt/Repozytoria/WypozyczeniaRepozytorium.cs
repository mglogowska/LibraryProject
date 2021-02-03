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
    public class WypozyczeniaRepozytorium : IWypozyczeniaRepozytorium
    {
        private readonly BibliotekaBaza db = new BibliotekaBaza();

        public WypozyczeniaRepozytorium()
        {
            
        }
        public async Task<Wypozyczenia> DodajAsync(Wypozyczenia encja)
        {
            db.Wypozyczenia.Add(encja);
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

        public async Task<Wypozyczenia> EdytujAsync(Wypozyczenia encja)
        {
            var temp = await db.Wypozyczenia.FindAsync(encja.ID);

            temp.DataOddania = encja.DataOddania;

            db.Wypozyczenia.AddOrUpdate(temp);
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

        public async Task<Wypozyczenia> PobierzAsync(int IDKlienta)
        {
            return await (from wyp in db.Wypozyczenia       //linq -> technologia do odpytywania bazy z poziomu .NET
                          where wyp.KlientID == IDKlienta
                          orderby wyp.DataWypozyczenia descending
                          select wyp).Include(w => w.Ksiazka).FirstOrDefaultAsync();
        }

        public async Task<List<Wypozyczenia>> PobierzWszystkieAsync(int IDKlienta)
        {
            return await (from wyp in db.Wypozyczenia       //linq -> technologia do odpytywania bazy z poziomu .NET
                          where wyp.KlientID == IDKlienta
                          orderby wyp.DataWypozyczenia descending
                          select wyp).Include(w => w.Ksiazka).ToListAsync();
        }

        public async Task<List<Wypozyczenia>> PobierzWszystkieAsync(int IDKlienta, DateTime Data)
        {
            return await (from wyp in db.Wypozyczenia       //linq -> technologia do odpytywania bazy z poziomu .NET
                          where wyp.KlientID == IDKlienta && wyp.DataWypozyczenia > Data
                          orderby wyp.DataWypozyczenia descending
                          select wyp).Include(w => w.Ksiazka).ToListAsync();
        }
    }
}
