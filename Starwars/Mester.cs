using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Mester : Erohasznalo
    {
        public bool Tanacstag { get; private set; }
        public KopenyTipus Kopeny { get; private set; }
        public int KorabbiTanivanyok { get; private set; }

        public Mester(string nev) : base(nev + " Mester")
        {
            Kopeny = (KopenyTipus)rnd.Next(0, Enum.GetValues(typeof(KopenyTipus)).Length);
            KorabbiTanivanyok = rnd.Next(0, 21);

            if (Oldal)
            {
                Tanacstag = rnd.NextDouble() <= 0.5;
            }
            else
            {
                Tanacstag = false;
            }
        }

        public void KopenyCsere(KopenyTipus ujKopeny)
        {
            Kopeny = ujKopeny;
        }
    }

    public enum KopenyTipus
    {
        KapucnisBarna,
        KapucnisSzurke,
        LengeVaszon
    }

}
