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
            int temp;

            // Konsoli tyylisäätöä
            Console.Title = "Lämpötila Laki";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään lämpötila ja asetetaan temp muuttujaan
            Console.Write("Anna lämpötila asteen tarkkuudella : ");
            temp = int.Parse(Console.ReadLine());

            if (temp > 39)
            {
                Console.WriteLine("Liian kuuma");
            }
            else if (temp <= 39 && temp >= 11)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (temp < 11 && temp >= 0)
            {
                Console.WriteLine("Haaleaa");
            }
            else if (temp <= -1 && temp >= -30)
            {
                Console.WriteLine("Pakkasta");
            }
            else if (temp < -30)
            {
                Console.WriteLine("Liian kylmä");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
