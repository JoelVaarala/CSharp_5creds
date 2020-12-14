using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {

        static int KysyJaTestaaLuku()
        {
            int luku;

            Console.Write("Anna luku : ");
            luku = int.Parse(Console.ReadLine());

            if (luku > 0)
            {
                return 1;
            }
            else if (luku < 0)
            {
                return -1;
            }
            else
                return 0;
        } 


        static void Main(string[] args)
        {
           
            // Konsoli tyylisäätöä
            Console.Title = "5-1";
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("Check if + / -\n");

            int luku = KysyJaTestaaLuku();

            switch (luku)
            {
                case 0:
                    Console.WriteLine("\nLuku oli nolla\n");
                    break;
                case 1:
                    Console.WriteLine("\nLuku oli positiivinen\n");
                    break;
                case -1:
                    Console.WriteLine("\nLuku oli negatiivinen\n");
                    break;
            }

        }
    }
}
