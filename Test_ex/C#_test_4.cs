using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {

      

        

        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "Kysymys 4";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nTämä ohjelma laskee työmarkkinatuen määrän.\n");

            char valinta = 'k';

            // Suoritetaan kunnes kierroksen lopussa valinnan arvoksi annetaan 'e'
            while (valinta == 'k'){

                int lapsetLkm;
                int palveluPv;
                int palkka;
                char asunto;
                
                // Tuen määrä kun 32,68/ pv ja 5pv/vk -> 4vk/kk
                double tuki = 32.68 * 5 * 4;

                // Lapsilisät tuelle (lyehmpikin tyyli olisi tuki += vs tuki = tuki + ...)
                Console.WriteLine("Kuinka monta lasta sinulla on: ");
                lapsetLkm = int.Parse(Console.ReadLine());
                if (lapsetLkm == 0)
                    continue;
                else if (lapsetLkm == 1)
                    tuki = tuki +(5.27 * 20);
                else if (lapsetLkm == 2)
                    tuki = tuki + (7.74 * 20);
                else if (lapsetLkm >2)
                    tuki = tuki + (9.98 * 20);

                // Lisätään tukeen palvelu lisät
                Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: ");
                palveluPv = int.Parse(Console.ReadLine());
                tuki = tuki + (palveluPv * 4.78);

                // Piikitetään tuen määrästä jos tienestit yli 300
                Console.WriteLine("Kuinka paljon olet saanut palkkaa: ");
                palkka = int.Parse(Console.ReadLine());           
                if (palkka > 300)
                {
                    double yli = palkka - 300;
                    tuki = tuki - (yli*0.5);
                }

                // Asuintilanteen vaikutus tuenmäärään -50%
                Console.WriteLine("Asutko vanhempiesi luona (k/e): ");
                asunto = char.Parse(Console.ReadLine());
                if (asunto == 'k')
                {
                    tuki = tuki / 2; 
                }
                 
                // Tulostetaan tuen määrä
                Console.WriteLine("Saat työmarkkinatukea " + tuki + " euroa kuukaudessa\n");

                // Kysytään halutaanko jatkaa vai lopettaa
                Console.WriteLine("Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): ");
                valinta = char.Parse(Console.ReadLine());

            } 
        }
    }
}
