using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {



        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "5-4";
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Functions - Main parameters\n");

            Console.WriteLine("Parametreja tuli {0} kpl", args.Length);

            if (args.Length != 0)
            {
                String a = args[0];
                if (a == "opettaja")
                    Console.WriteLine("Koita saada oppilaat oppimaan");
                else if (a == "opiskelija")
                    Console.WriteLine("koita opiskella ahkerasti");
                else
                    Console.WriteLine("en ymmärrä");

            }
        }
    }
}
