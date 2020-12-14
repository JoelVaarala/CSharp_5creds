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

        static void LueArvot(int a, int b)
        {
            // Annettaan käyttäjän antaa luvuille arvot (0 as default from main) 

            Console.Write("Anna ensimmäinen kokonaisluku : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku : ");
            b = int.Parse(Console.ReadLine());

            // Funktio ei palauta mitään vaan kutsuu toista funktiota, ja antaa luvut parametrinä eteenpäin
            Tulosta(a, b);
        }

        static void Tulosta(int a, int b)
        {
            // Laitetaan luvut double tyyppisiksi ja näytetään tulos kahdella desimaalilla (muutama erilainen tapa esimerkkinä)
            double f = a;
            double d = b;
            double osamaara = f / d;
            //double osa = Math.Round(osamaara, 2);
            
            Console.WriteLine("\nLukujen osämäärä : {0:0.00}", osamaara);
            //Console.WriteLine(osamaara.ToString("F"));
            //Console.WriteLine(osa);
        }


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "Kysymys 1";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\n");

            // Esitellään 2-kokonaislukumuuttujaa
            int a = 0;
            int b= 0;

            // Kutsutaan LueArvot fuktiota ja toimitetaan muuttujat parametreina
            LueArvot(a, b);

        }
    }
}
