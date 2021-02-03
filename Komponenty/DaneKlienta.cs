using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponenty
{
    public partial class DaneKlienta : UserControl
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DaneKlienta()
        {
            InitializeComponent();
        }

        private void DaneKlienta_Load(object sender, EventArgs e)
        {

        }

        public void UstawPola(string imie, string nazwisko)
        {
            this.imieTextBox.Text = imie;
            this.nazwiskoTextBox.Text = nazwisko;
        }

        private void imieTextBox_TextChanged(object sender, EventArgs e)
        {
            Imie = this.imieTextBox.Text;
        }

        private void nazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {
            Nazwisko = this.nazwiskoTextBox.Text;
        }
    }
}
