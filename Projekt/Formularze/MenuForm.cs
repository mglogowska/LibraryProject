using Projekt.Dane;
using Projekt.Formularze;
using Projekt.Repozytoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            wypozyczeniaButton.FlatAppearance.BorderSize = 3;
            klienciButton.FlatAppearance.BorderSize = 3;
            wyjdzButton.FlatAppearance.BorderSize = 3;

            timer.Interval = 1000;
            timer.Start();
        }

        private void klienciButton_Click(object sender, EventArgs e)
        {
            var form = new KlienciForm(this);
            form.Show();
            this.Hide();
        }

        private void edycjaButton_Click(object sender, EventArgs e)
        {

        }

        private void wyjdzButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clockPictureBox_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            var r1 = this.clockPictureBox.ClientRectangle;

            // zmniejsz rectangle
            r1.Inflate(-3, -3);     //kwadrat zegara
            g.DrawEllipse(Pens.Black, r1);
            var r2 = r1;
            r2.Inflate(-5, -5);     //kwadrat wskazówek
            TextRenderer.DrawText(g, DateTime.Now.ToString("HH:mm:ss"), this.Font,
                new Rectangle(r1.Left, r1.Top + 2 * r1.Height / 3, r1.Width, r1.Height / 3),
                Color.Black);       //kwadrat cyfrowego, dwa pierwsze argumenty określają gdzie jest lewy górny róg

            // Translate układu wspołrzednych do środka
            e.Graphics.TranslateTransform(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);  //przenosimy punkt 0.0 na środek
            var c = g.BeginContainer(); //zapisuje stan układu współrzędnych
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Obrot ukladu do wskazowki Godzin
            //Obracamy cały czas układ, tak, że wskazówka jest na osi -y
            e.Graphics.RotateTransform(DateTime.Now.Hour * 30f + DateTime.Now.Minute / 2f);

            // Narysuj czarne kolko
            g.FillEllipse(Brushes.Black, -5, -5, 10, 10);

            // Wskazowka godziny
            using (var p = new Pen(Color.Black, 4))//usinga używamy tylko w następujących klamrach
            { g.DrawLine(p, 0, 0, 0, -r2.Height / 2 + 30); } // rysujemy wskazówkę na osi -y
            g.EndContainer(c); //wraca do nieobróconego układu współrzędnych
            c = g.BeginContainer();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Obrot ukladu do wskazowki Minut
            e.Graphics.RotateTransform(DateTime.Now.Minute * 6);

            // Wskazowka minuty
            using (var p = new Pen(Color.Black, 2))
                g.DrawLine(p, 0, 0, 0, -r2.Height / 2 + 10);
            g.EndContainer(c);
            c = g.BeginContainer();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Obrot ukladu do wskazowki Sekund
            e.Graphics.RotateTransform(DateTime.Now.Second * 6);

            // Wskazowka sekund
            using (var p = new Pen(Color.Red, 2))
                g.DrawLine(p, 0, 10, 0, -r2.Height / 2 + 15);
            g.EndContainer(c);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            clockPictureBox.Invalidate();
        }

        private void wypozyczeniaButton_Click(object sender, EventArgs e)
        {
            var form = new WypozyczeniaForm(this);
            form.Show();
            this.Hide();
        }
    }
}
