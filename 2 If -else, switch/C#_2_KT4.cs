using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muuttujat
            int luku1, luku2;
            double vastaus;
            String lasku;

            // Konsoli tyylisäätöä
            Console.Title = "Nelilaskin";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään luvut ja operaattori
            Console.Write("Anna ensimmäinen luku : ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku : ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Valitse operaatio (+ , - , * tai /)");
            lasku = Console.ReadLine();


            // Luodaan switch --> selvittää laskun
            switch (lasku)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    Console.WriteLine("Lukujen summa on : {0}", vastaus);
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    Console.WriteLine("Lukujen erotus on : {0}", vastaus);
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    Console.WriteLine("Lukujen tulo on : {0}", vastaus);
                    break;
                case "/":
                    if(luku1 != 0 && luku2 != 0)
                    {
                        vastaus = luku1 / luku2;
                        Console.WriteLine("Lukujen jako on : {0}", vastaus);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nollalla jakoa ei salittu");
                        break;
                    }
                default:
                    Console.WriteLine("Syötteessä vikaa");
                    break;
                
            }

        }
    }
}
