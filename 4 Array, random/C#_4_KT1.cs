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
            Console.Title = "Taulukko :O";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            Console.WriteLine("Taulu????\n\n");

            double[] luvut = new double[3];
            double luku, ka;
            double summa = 0;


            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Anna numero : ");
                luku = double.Parse(Console.ReadLine());
                luvut[i] = luku;
                summa = summa + luku;
            }

            ka = summa / 3;

            Console.WriteLine("\n\nSyötettyjen lukujen summa : " + summa + "\nKeskiarvo : " + ka.ToString("#.##"));
        }
    }
}
