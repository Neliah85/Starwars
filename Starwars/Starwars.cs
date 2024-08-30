using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    internal class Starwars
    {
        static void Main()
        {
            Rend rend = new Rend(100, 20);

            Console.WriteLine($"Jedi Tanács tagok száma: {rend.JediTanacsTagokSzama()}");

            var legtobbTanitvannyalRendelkezoMester = rend.LegtobbTanitvannyalRendelkezoMesterKapucnisSzurkeKopenyben();
            if (legtobbTanitvannyalRendelkezoMester != null)
            {
                Console.WriteLine("Mester a legtöbb tanítvánnyal, kapucnis szürke köpenyben:");
                Console.WriteLine($"Név: {legtobbTanitvannyalRendelkezoMester.Nev}");
                Console.WriteLine($"Midikloriánok: {legtobbTanitvannyalRendelkezoMester.Midiklorianok}");
                Console.WriteLine($"Korábbi tanítványok száma: {legtobbTanitvannyalRendelkezoMester.KorabbiTanivanyok}");
            }
            else
            {
                Console.WriteLine("Nincs kapucnis szürke köpenyt viselő mester.");
            }
            Console.ReadKey();
        }
    }
    

}
