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
    public partial class EdytujKlientaForm : Form
    {
        private IRepository<Klient> _klientRepozytorium;
        Klient k;
        DaneKlientaForm daneKlientaForm;
        KlienciForm klienciForm;
        public event KlientAkt EdycjaKlienta;
        public EdytujKlientaForm(Klient klient, DaneKlientaForm daneKlientaForm, KlienciForm klienciForm)
        {
            InitializeComponent();
            _klientRepozytorium = (IRepository<Klient>)Program.ServiceProvider.GetService(typeof(IRepository<Klient>));
            daneKlienta1.UstawPola(klient.Imie, klient.Nazwisko);
            this.daneKlientaForm = daneKlientaForm;
            this.klienciForm = klienciForm;
            k = klient;
            EdycjaKlienta += klienciForm.EdycjaListy;
        }

        private void EdytujKlientaForm_Load(object sender, EventArgs e)
        {
            zapiszButton.FlatAppearance.BorderSize = 3;
            wrodzButton.FlatAppearance.BorderSize = 3;
        }

        private async void zapiszButton_ClickAsync(object sender, EventArgs e)
        {
            if (Weryfikacja())
            {
                k.Imie = daneKlienta1.Imie;
                k.Nazwisko = daneKlienta1.Nazwisko;
                var outcome = await _klientRepozytorium.EdytujAsync(k);

                if (outcome != null)
                {
                    EdycjaKlienta?.Invoke(outcome);     //? - invoke tylko jak jest subskrypcja
                    daneKlienta1.UstawPola(string.Empty, string.Empty);
                }
            }
            else
            {
                string message = "Nieprawidłowe dane klienta.";
                string title = "Błąd";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void wrodzButton_Click(object sender, EventArgs e)
        {
            this.Close();
            klienciForm.Show();

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
    }
}
