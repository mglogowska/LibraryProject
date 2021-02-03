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
    public partial class WypozyczeniaForm : Form
    {
        private readonly MenuForm menuForm;
        private readonly IRepository<Klient> _klientRepozytorium;
        public List<Klient> Klienci { get; set; }
        public WypozyczeniaForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            _klientRepozytorium = (IRepository<Klient>)Program.ServiceProvider.GetService(typeof(IRepository<Klient>));
        }

        private void klienciwypozListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void WypozyczeniaForm_LoadAsync(object sender, EventArgs e)
        {
            Klienci = await _klientRepozytorium.PobierzWszystkieAsync();
            foreach (var klient in Klienci)
            {
                DodanieDoListyItemow(klient);
            }
            ColumnHeader column = new ColumnHeader();
            column.Width = 200;
            column.Text = "Klienci:";
            klienciwypozListView.Columns.AddRange(new ColumnHeader[] { column });
            klienciwypozListView.View = View.Details;
        }

        public void DodanieDoListyItemow(Klient klient)
        {
            ListViewItem item = new ListViewItem();
            item.Text = klient.Imie + " " + klient.Nazwisko;
            item.Tag = klient.ID;
            klienciwypozListView.Items.Add(item);
        }

        private void wrocButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.Show();
        }

        private void zobaczWypozyczeniaButton_Click(object sender, EventArgs e)
        {
            if (klienciwypozListView.SelectedItems.Count == 0)
            {
                string message = "Najpierw musisz wybrać klienta";
                string title = "Komunikat";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
                var zaznaczonyItem = klienciwypozListView.SelectedItems[0];
                Klient tempKlient = Klienci.Where(k => k.ID == (int)zaznaczonyItem.Tag).First();
                var form = new WypozyczeniaKlientaForm(tempKlient, this);
                form.Show();
            }
        }
    }
}
