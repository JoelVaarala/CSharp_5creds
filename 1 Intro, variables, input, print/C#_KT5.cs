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
            double pii = 3.141592;
            double halkaisija;

            // Konsoli tyylisäätöä
            Console.Title = "Ympyrä laskuri";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään halkaisija
            Console.Write("Anna ympyrän halkaisija (cm) : ");
            halkaisija = double.Parse(Console.ReadLine());

            // lasketaan piiri ja pinta-ala
            double sade = halkaisija / 2;
            double piiri = pii * halkaisija;
            double pa = pii * (sade * sade);

            // Tulostetaan halutut vastaukset
            Console.WriteLine("\n\nYmpyrän piiri on : {0:F2} cm", piiri);
            Console.WriteLine("Ympyrän pinta-ala on : {0:F2} neliösenttiä\n", pa);


        }
    }
}
