using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Tanitvany : Erohasznalo
    {
        // Tulajdonságok
        public double TincsHossza { get; private set; }
        public int KepzettsegiSzint { get; private set; }

        // Konstruktor véletlen értékekkel
        public Tanitvany(string nev) : base("Ifjú " + nev)
        {
            TincsHossza = RandomTincsHossza();
            KepzettsegiSzint = RandomKepzettsegiSzint();
        }

        // Konstruktor konkrét értékekkel
        public Tanitvany(string nev, double tincsHossza, int kepzettsegiSzint)
            : base("Ifjú " + nev)
        {
            TincsHossza = tincsHossza;
            KepzettsegiSzint = kepzettsegiSzint;
        }

        // Véletlen tincshossz generálása (0.5 és 15 között)
        private double RandomTincsHossza()
        {
            Random rnd = new Random();
            return rnd.NextDouble() * (15 - 0.5) + 0.5;
        }

        // Véletlen képzettségi szint generálása (0 és 100 között)
        private int RandomKepzettsegiSzint()
        {
            Random rnd = new Random();
            return rnd.Next(0, 101); // [0, 100] intervallum
        }
    }

}
