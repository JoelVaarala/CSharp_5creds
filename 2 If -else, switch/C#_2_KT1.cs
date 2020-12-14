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
            int arvosana;

            // Konsoli tyylisäätöä
            Console.Title = "Arvosana seula";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään arvosana
            Console.Write("Anna arvosana (4-10) : ");
            arvosana = int.Parse(Console.ReadLine());

            // Tarkastetaan onko arvosana valid
            if (arvosana >= 9 && arvosana <= 10)
            {
                Console.WriteLine("hyvä");
            }
            else if (arvosana >= 7 && arvosana <= 8)
            {
                Console.WriteLine("kelpo");
            }
            else if (arvosana >= 5 && arvosana <= 6)
            {
                Console.WriteLine("tyydyttävä");
            }
            else if (arvosana == 4)
            {
                Console.WriteLine("heikko");
            }
            // Else - kun mikään aiemmista säännöistä ei toteudu
            else
            {
                Console.WriteLine("et antanut arvosanaa annetulta väliltä");
            }


        }
    }
}
