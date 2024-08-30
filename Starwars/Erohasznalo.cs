using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Erohasznalo
    {
        public string Nev { get; private set; }
        public int Midiklorianok { get; private set; }
        public KardSzin KardSzine { get; private set; }
        public bool Oldal { get; private set; } // true: jó oldal, false: sötét oldal
        private int oldalValtasok = 0;

        // Módosítás: a rnd mezőt "protected static" szintre állítjuk
        protected static Random rnd = new Random();

        public Erohasznalo(string nev)
        {
            if (string.IsNullOrWhiteSpace(nev) || nev.Length < 3)
                throw new ArgumentException("A név legalább 3 karakter hosszú kell legyen.");

            Nev = nev;
            Midiklorianok = rnd.Next(3001, 20001); // [3001, 20000]
            Oldal = rnd.NextDouble() <= 0.8;

            KardSzine = Oldal ? (KardSzin)rnd.Next(0, 4) : KardSzin.Piros;
        }

        public void ValtsOldalt()
        {
            if (oldalValtasok < 2)
            {
                Oldal = !Oldal;
                oldalValtasok++;
                if (!Oldal) // Ha a sötét oldalra kerül
                {
                    KardSzine = KardSzin.Piros;
                }
            }
            else
            {
                throw new InvalidOperationException("Az oldal legfeljebb kétszer változhat.");
            }
        }
    }

    public enum KardSzin
    {
        Kek,
        Zold,
        Sarga,
        Lila,
        Piros
    }
}
