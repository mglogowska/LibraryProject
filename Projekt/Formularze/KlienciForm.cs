using Projekt.Interfaces;
using Projekt.Modele;
using Projekt.Repozytoria;
using Projekt.Formularze;
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
    public partial class KlienciForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly IRepository<Klient> _klientRepozytorium;
        public List<Klient> Klienci { get; set; }
        

        public KlienciForm(MenuForm menuForm)
        {
            InitializeComponent();
            _klientRepozytorium = (IRepository<Klient>)Program.ServiceProvider.GetService(typeof(IRepository<Klient>));
            this.menuForm = menuForm;
        }

        private async void KlienciForm_LoadAsync(object sender, EventArgs e)
        {
            Klienci = await _klientRepozytorium.PobierzWszystkieAsync();
            foreach (var klient in Klienci)
            {
                DodanieDoListyItemow(klient);
            }
            ColumnHeader column = new ColumnHeader();
            column.Width = 200;
            column.Text = "Klienci:";
            klienciListView.Columns.AddRange(new ColumnHeader[] {column});
            klienciListView.View = View.Details;
        }
        public void DodanieDoListyKlientow(Klient klient)
        {
            ListViewItem item = new ListViewItem();
            item.Text = klient.Imie + " " + klient.Nazwisko;
            // ***********************
            item.Tag = klient.ID;
            klienciListView.Items.Add(item);
            Klienci.Add(klient);
        }

        public void DodanieDoListyItemow(Klient klient)
        {
            ListViewItem item = new ListViewItem();
            item.Text = klient.Imie + " " + klient.Nazwisko;
            // ***********************
            item.Tag = klient.ID;
            klienciListView.Items.Add(item);
        }

        public void EdycjaListy(Klient klient)
        {
            UsunieciezListy(klient);
            DodanieDoListyKlientow(klient);
        }

        public void UsunieciezListy(Klient klient)
        {
            IEnumerable<ListViewItem> lv = klienciListView.Items.Cast<ListViewItem>();
            var itemToDelete = (from x in lv
                                where (int)x.Tag == klient.ID
                                select x).Single();

            Klienci.Remove(klient);
            klienciListView.Items.Remove(itemToDelete);
        }

        private void zobaczKlientaButton_Click(object sender, EventArgs e)
        {
            if(klienciListView.SelectedItems.Count == 0)
            {
                string message = "Najpierw musisz wybrać klienta";
                string title = "Komunikat";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
                var zaznaczonyItem = klienciListView.SelectedItems[0];
                Klient tempKlient = Klienci.Where(k => k.ID == (int)zaznaczonyItem.Tag).First();
                var form = new DaneKlientaForm(tempKlient, this);
                form.Show();
            }
            
        }

        private void nowyKlientButton_Click(object sender, EventArgs e)
        {
            var form = new DodajKlientaForm(this);
            form.Show();
        }

        private void wrocButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }
    }
}
