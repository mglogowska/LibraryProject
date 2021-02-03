using Projekt.Interfaces;
using Projekt.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Formularze
{
    public delegate void KlientAkt(Klient klient);

    public partial class DodajKlientaForm : Form
    {
        private IRepository<Klient> _klientRepozytorium;
        public event KlientAkt DodanieKlienta;  //event -> można odpalić to wydarzenie tylko wewnątrz tej klasy
        public DodajKlientaForm(KlienciForm klienciForm)
        {
            InitializeComponent();
            _klientRepozytorium = (IRepository<Klient>)Program.ServiceProvider.GetService(typeof(IRepository<Klient>));
            DodanieKlienta += klienciForm.DodanieDoListyKlientow;
        }

        private void DodajKlientaForm_Load(object sender, EventArgs e)
        {
            dodajKlientaButton.FlatAppearance.BorderSize = 3;
        }

        private async void dodajKlientaButton_ClickAsync(object sender, EventArgs e)
        {
            if(Weryfikacja())
            {
                var tempKlient = new Klient()
                {
                    Imie = daneKlienta1.Imie,
                    Nazwisko = daneKlienta1.Nazwisko
                };

                var outcome = await _klientRepozytorium.DodajAsync(tempKlient);

                if(outcome != null)
                {
                    DodanieKlienta?.Invoke(outcome);     //? - invoke tylko jak jest subskrypcja
                    daneKlienta1.UstawPola(string.Empty, string.Empty);
                }

                //string message = "Klient został dodany";
                //string title = "Komunikat";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
                string message = "Nieprawidłowe dane klienta.";
                string title = "Błąd";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
           
        }

        private bool Weryfikacja()
        {
            if (daneKlienta1.Imie is null ||
                daneKlienta1.Nazwisko is null)
                return false;

            if (!daneKlienta1.Imie.All(Char.IsLetter) ||
                !daneKlienta1.Nazwisko.All(Char.IsLetter))
                return false;

            return true;
        }

        private void powrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
