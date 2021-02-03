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
    public partial class WypozyczeniaKlientaForm : Form
    {
        private readonly IWypozyczeniaRepozytorium _wypozyczeniaRepozytorium;
        private readonly Klient klient;
        private readonly WypozyczeniaForm wypozyczeniaForm;
        public List<Wypozyczenia> WypozyczeniaList { get; set; }
   
        public WypozyczeniaKlientaForm(Klient klient, WypozyczeniaForm wypozyczeniaForm)
        {
            InitializeComponent();
            _wypozyczeniaRepozytorium = (IWypozyczeniaRepozytorium)Program.ServiceProvider.GetService(typeof(IWypozyczeniaRepozytorium));
            this.klient = klient;
            this.wypozyczeniaForm = wypozyczeniaForm;
        }

        private async void WypozyczeniaKlientaForm_LoadAsync(object sender, EventArgs e)
        {
            WypozyczeniaList = await _wypozyczeniaRepozytorium.PobierzWszystkieAsync(klient.ID);
            foreach (var wypozyczenia in WypozyczeniaList)
            {
                await DodanieDoItemowAsync(wypozyczenia);
            }
            ColumnHeader column = new ColumnHeader();
            column.Width = 200;
            column.Text = "Wypożyczenia:";
            wypozyczeniaListView.Columns.AddRange(new ColumnHeader[] { column });
            wypozyczeniaListView.View = View.Details;
        }

        public async Task DodanieDoItemowAsync(Wypozyczenia wypozyczenia)
        {
            ListViewItem item = new ListViewItem();
            var doDodania = 
                (
                    await _wypozyczeniaRepozytorium.PobierzWszystkieAsync(wypozyczenia.KlientID)
                )
                .Where(w => w.ID == wypozyczenia.ID)
                .FirstOrDefault();
            
            item.Text = doDodania.Ksiazka.Tytul 
                + " " 
                + doDodania.DataWypozyczenia.ToString("MM/dd/yyyy H:mm") 
                + " " 
                + doDodania.DataOddania.ToString("MM/dd/yyyy H:mm");

            if(doDodania.DataOddania == doDodania.DataWypozyczenia)
            {
                item.Text = doDodania.Ksiazka.Tytul 
                    + " "
                    + doDodania.DataWypozyczenia.ToString("MM/dd/yyyy H:mm") 
                    + " " 
                    + "Nie Oddana";
            }
            item.Tag = doDodania.ID;
            wypozyczeniaListView.Items.Add(item);
        }

        public async Task DodanieDoWypozyczenAsync(Wypozyczenia wypozyczenia)
        {
            ListViewItem item = new ListViewItem();
            var doDodania =
                (
                    await _wypozyczeniaRepozytorium.PobierzWszystkieAsync(wypozyczenia.KlientID)
                )
                .Where(w => w.ID == wypozyczenia.ID)
                .FirstOrDefault();

            item.Text = doDodania.Ksiazka.Tytul
                + " "
                + doDodania.DataWypozyczenia.ToString("MM/dd/yyyy H:mm")
                + " "
                + doDodania.DataOddania.ToString("MM/dd/yyyy H:mm");

            if (doDodania.DataOddania == doDodania.DataWypozyczenia)
            {
                item.Text = doDodania.Ksiazka.Tytul
                    + " "
                    + doDodania.DataWypozyczenia.ToString("MM/dd/yyyy H:mm")
                    + " "
                    + "Nie Oddana";
            }
            item.Tag = doDodania.ID;
            wypozyczeniaListView.Items.Add(item);
            WypozyczeniaList.Add(wypozyczenia);
        }

        private void oddajKsiazkeButton_Click(object sender, EventArgs e)
        {
            if (wypozyczeniaListView.SelectedItems.Count == 0)
            {
                string message = "Najpierw musisz wybrać książkę";
                string title = "Komunikat";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
                var zaznaczonyItem = wypozyczeniaListView.SelectedItems[0];
                Wypozyczenia tempWypozyczenie = WypozyczeniaList.Where(k => k.ID == (int)zaznaczonyItem.Tag).First();
                tempWypozyczenie.DataOddania = DateTime.Now;
                _wypozyczeniaRepozytorium.EdytujAsync(tempWypozyczenie);
                EdytujWypozyczenie(tempWypozyczenie);
            }
        }

        private void EdytujWypozyczenie(Wypozyczenia tempWypozyczenie)
        {
            IEnumerable<ListViewItem> lv = wypozyczeniaListView.Items.Cast<ListViewItem>();
            var itemToEdit = (from x in lv
                                where (int)x.Tag == tempWypozyczenie.ID
                                select x).Single();

            var index = wypozyczeniaListView.Items.IndexOf(itemToEdit);
            wypozyczeniaListView.Items[index].Text = tempWypozyczenie.Ksiazka.Tytul
                + " "
                + tempWypozyczenie.DataWypozyczenia.ToString("MM/dd/yyyy H:mm")
                + " "
                + tempWypozyczenie.DataOddania.ToString("MM/dd/yyyy H:mm");
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
            wypozyczeniaForm.Show();

        }

        private void noweWypozyczenieButton_Click(object sender, EventArgs e)
        {
            var form = new NoweWypozyczenieForm(this, klient);
            form.Show();
        }

        private void wypozyczeniaListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
