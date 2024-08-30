using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class Rend
    {
        public List<Mester> Mesterek { get; private set; }
        public List<Tanitvany> Tanitvanyok { get; private set; }

        public Rend(int mesterSzam, int tanitvanySzam)
        {
            Mesterek = new List<Mester>();
            Tanitvanyok = new List<Tanitvany>();

            for (int i = 1; i <= mesterSzam; i++)
            {
                Mesterek.Add(new Mester($"Erohasznalo {i}"));
            }

            for (int i = 1; i <= tanitvanySzam; i++)
            {
                Tanitvanyok.Add(new Tanitvany($"Erohasznalo {mesterSzam + i}"));
            }
        }

        public int JediTanacsTagokSzama()
        {
            return Mesterek.Count(m => m.Oldal && m.Tanacstag);
        }

        public List<Tanitvany> ListazTanitvanyokatKardSzinAlapjan(KardSzin szin)
        {
            return Tanitvanyok.Where(t => t.Oldal && t.KardSzine == szin).ToList();
        }

        public Mester LegtobbTanitvannyalRendelkezoMesterKapucnisSzurkeKopenyben()
        {
            return Mesterek
                .Where(m => m.Oldal && m.Kopeny == KopenyTipus.KapucnisSzurke)
                .OrderByDescending(m => m.KorabbiTanivanyok)
                .FirstOrDefault();
        }
    }
}
