using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "Kysymys 2";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n");

            // Otetaan käyttäjän syötä muuttujaan
            Console.WriteLine("Syötä tekti : ");
            String teksti = Console.ReadLine();

            // String muuttuja teksti pienillä kirjaimilla
            teksti = teksti.ToLower();

            // String muuttujan merkit char tauluun
            char[] kirjaimet = teksti.ToCharArray();
            Console.WriteLine("\n");

            // Tulostetaan joka toinen merkki "kirjaimet" taulusta
            for (int i = 0; i<kirjaimet.Length;)
            {
                Console.WriteLine(kirjaimet[i]);
                i+=2;
            }
            Console.WriteLine("\n");
        }
    }
}
