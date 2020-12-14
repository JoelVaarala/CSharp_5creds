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
            // Luodaan kaksi muuttujaa laskurille
            int laskeva = 10;
            int nouseva = 11;
            int i;

            // Konsoli tyylisäätöä
            Console.Title = "For looppia";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // For - silmukka toistoa varten
            for (i=0; i<10; i++)
            {
                // Tulostetaan muuttujat vierekkäin 
                Console.WriteLine(nouseva + "\t" + laskeva);

                // Vähennetään laskevasta -1 per kierros
                laskeva--;
                // Lisätään nousevaan +1 per kierros
                nouseva++;
            }

        }
    }
}
