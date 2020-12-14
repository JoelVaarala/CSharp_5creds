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
            const double PII = 3.141592;
            double sade, piiri, pa;
            int valinta;

            // Konsoli tyylisäätöä
            Console.Title = "Ympyrä seikkailut pt.2";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään luvut ja valinta käyttäjältä
            Console.Write("Anna ympyrän säde : ");
            sade = double.Parse(Console.ReadLine());

            // Pyydetään käyttäjää valitsemaan 1 tai 2 (haluttu laskutoimitus)
            Console.Write("Laske ympyrän piiri(1) tai pinta-ala(2) : ");
            valinta = int.Parse(Console.ReadLine());

            if (valinta == 1)
            {
                // Lasketaan ympyrän piiri
                piiri = PII * (sade * 2);
                Console.WriteLine("\nYmpyrän piiri on : {0:F2} cm", piiri);
            }
            else if (valinta == 2)
            {
                // Lasketaan ympyrän pinta-ala
                pa = PII * (sade * sade);
                Console.WriteLine("\nYmpyrän pinta-ala on : {0:F2} neliösenttiä", pa);
            }
            else
            {
                Console.WriteLine("\nError");
            }
        }
    }
}
