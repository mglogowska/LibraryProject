using Projekt.Formularze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Projekt.Interfaces;
using Projekt.Modele;
using Projekt.Repozytoria;

namespace Projekt
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices() 
        { 
            var services = new ServiceCollection();
            services.AddSingleton<IRepository<Autor>, AutorRepozytorium>();
            services.AddSingleton<IRepository<Gatunek>, GatunekRepozytorium>();
            services.AddSingleton<IRepository<Klient>, KlientRepozytorium>();
            services.AddSingleton<IRepository<Ksiazka>, KsiazkaRepozytorium>();
            services.AddSingleton<IWypozyczeniaRepozytorium, WypozyczeniaRepozytorium>();
            ServiceProvider = services.BuildServiceProvider(); 
        }

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new MenuForm());
        }
    }
}
