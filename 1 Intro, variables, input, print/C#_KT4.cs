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

            String nimi;
            double pituus;
            double paino;

            Console.Write("Anna nimesi : ");
            nimi = Console.ReadLine();

            Console.Write("Anna pituus (m) : ");
            pituus = double.Parse(Console.ReadLine());

            Console.Write("Anna paino (kg) : ");
            paino = double.Parse(Console.ReadLine());

            double bmi = (paino / (pituus * pituus));

            Console.Clear();

            Console.WriteLine("{0}, pituutesi on {1} m ja painosi {2} kg \nPainoindeksisi on siten {3:F2}", nimi, pituus, paino, bmi);
            

        }
    }
}
