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
    public partial class DaneKlientaForm : Form
    {
        private readonly KlienciForm klienciForm;
        private IRepository<Klient> _klientRepozytorium;
        Klient k;
        public event KlientAkt UsuniecieKlienta;
        public DaneKlientaForm(Klient klient, KlienciForm klienciForm)
        {
            InitializeComponent();
            daneKlienta1.UstawPola(klient.Imie, klient.Nazwisko);
            _klientRepozytorium = (IRepository<Klient>)Program.ServiceProvider.GetService(typeof(IRepository<Klient>));
            this.klienciForm = klienciForm;
            UsuniecieKlienta += klienciForm.UsunieciezListy;
            k = klient; 

        }

        private void dodajKlientaLabel_Click(object sender, EventArgs e)
        {

        }

        private void DaneKlientaForm_Load(object sender, EventArgs e)
        {
            edytujKlientaButton.FlatAppearance.BorderSize = 3;
            usunKlientaButton.FlatAppearance.BorderSize = 3;
        }

        private void edytujKlientaButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new EdytujKlientaForm(k, this, klienciForm);
            form.Show();
        }

        private void powrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
            klienciForm.Show();
        }

        private async void usunKlientaButton_ClickAsync(object sender, EventArgs e)
        {
            string message = "Czy na pewno chcesz usunac klienta?";
            string title = "Komunikat";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) 
            {
                await _klientRepozytorium.UsunAsync(k.ID);
                UsuniecieKlienta?.Invoke(k);
                MessageBox.Show("Usunięto klienta", title, MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
