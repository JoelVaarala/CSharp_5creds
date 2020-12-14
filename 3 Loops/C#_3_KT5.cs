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
           
            // Konsoli tyylisäätöä
            Console.Title = "MeRkKeJä";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // int muuttuja ascii arvolle
            int asciiA;

            Console.WriteLine("Syötä merkkejä (enter lopettaa) : ");

            do
            {
                // luetaan konsoli
                asciiA = Console.ReadKey(true).KeyChar;

                // tarkastetaan onko a-z
                if (asciiA <= 122 && asciiA >= 97)
                {
                    // muutos a -> A
                    asciiA -= 32;
                    Console.Write((char)asciiA);
                }
                // tarkastetaan onko A-Z
                else if (asciiA <= 90 && asciiA >= 65) 
                {
                    // muutos A -> a
                    asciiA += 32;
                    Console.Write((char)asciiA);
                }
                else
                {
                    // hypätään muiden merkkien "ohi"
                    continue;
                }
                
              // silmukka päättyy entterin painallukseen
            } while (asciiA != '\r');

            Console.WriteLine("\n ");

        }
    }
}
