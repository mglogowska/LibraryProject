using Projekt.Interfaces;
using Projekt.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Formularze
{
    public delegate Task WypozyczenieAkt(Wypozyczenia wypozyczenie);
    public partial class NoweWypozyczenieForm : Form
    {
        private readonly IRepository<Ksiazka> _ksiazkaRepozytorium;
        private readonly IWypozyczeniaRepozytorium _wypozyczenieRepozytorium;
        private readonly Klient klient;

        private event WypozyczenieAkt NoweWypozyczenie;
        public List<Ksiazka> Ksiazki { get; set; }
        public NoweWypozyczenieForm(WypozyczeniaKlientaForm wypozyczeniaKlientaForm, Klient klient)
        {
            InitializeComponent();
            _ksiazkaRepozytorium = (IRepository<Ksiazka>)Program.ServiceProvider.GetService(typeof(IRepository<Ksiazka>));
            _wypozyczenieRepozytorium = (IWypozyczeniaRepozytorium)Program.ServiceProvider.GetService(typeof(IWypozyczeniaRepozytorium));
            this.klient = klient;

            NoweWypozyczenie += wypozyczeniaKlientaForm.DodanieDoWypozyczenAsync;
        }

        private async void NoweWypozyczenieForm_LoadAsync(object sender, EventArgs e)
        {
            Ksiazki = await _ksiazkaRepozytorium.PobierzWszystkieAsync();
            foreach (var ksiazka in Ksiazki)
            {
                DodanieDoListyItemow(ksiazka);
            }
            ColumnHeader column = new ColumnHeader();
            column.Width = 200;
            column.Text = "Książki:";
            ksiazkiListView.Columns.AddRange(new ColumnHeader[] { column });
            ksiazkiListView.View = View.Details;
        }

        public void DodanieDoListyItemow(Ksiazka ksiazka)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ksiazka.Tytul + " " + ksiazka.Autor.Imie + " " + ksiazka.Autor.Nazwisko;
            item.Tag = ksiazka.ID;
            ksiazkiListView.Items.Add(item);
        }

        private async void wypozyczButton_ClickAsync(object sender, EventArgs e)
        {
            if (ksiazkiListView.SelectedItems.Count == 0)
            {
                string message = "Wybierz ksiazke.";
                string title = "Błąd";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
                var noweWypozyczenie = await _wypozyczenieRepozytorium.DodajAsync(new Wypozyczenia()
                {
                    DataWypozyczenia = DateTime.Now,
                    DataOddania = DateTime.Now,
                    KlientID = klient.ID,
                    KsiazkaID = (int)ksiazkiListView.SelectedItems[0].Tag,
                });
                NoweWypozyczenie?.Invoke(noweWypozyczenie);
            }
        }

        private void wrocButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
