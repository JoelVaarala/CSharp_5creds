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
            // Alustetaan muuttujat
            int luku1;
            int luku2;

            // Kysytään käyttäjältä kokonaisluvut
            Console.Write("Anna ensimmäinen kokonaisluku : ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku : ");
            luku2 = int.Parse(Console.ReadLine());

            // Tyhjennetään konsoli
            Console.Clear();

            // Laskujen tulokset
            int sum = luku1 + luku2;
            int ero = luku1 - luku2;
            int tulo = luku1 * luku2;


            // Tulostetaan konsoliin
            Console.WriteLine("Summa : \t {0} + {1} = {2}", luku1, luku2, sum);

            Console.WriteLine("Erotus : \t {0} - {1} = {2}", luku1, luku2, ero);

            Console.WriteLine("Tulo : \t \t {0} * {1} = {2}", luku1, luku2, tulo);

        }
    }
}
