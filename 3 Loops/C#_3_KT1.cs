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
            Console.Title = "While - k/a";

            // Muuttujat numeroiden määrälle, summalle ja k/a
            int iMaara = 0;
            int yht = 0;
            int luku = 0;
            double ka;

            // silmukka, joka päättyy kun syötetään -1 konsoliin
            while (luku != -1)
            {
                Console.WriteLine("Anna luku (-1 lopettaa) : ");
                luku = int.Parse(Console.ReadLine());
                if (luku != -1)
                {
                    iMaara = iMaara + 1;
                    yht = yht + luku;
                }
                
            }

            Console.Clear();

            ka = yht / iMaara;
            Console.WriteLine("Keskiarvo luvuille on : {0}", ka);
        }
    }
}
