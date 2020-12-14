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
        static void Main(string[] args)
        {
           
            // Konsoli tyylisäätöä
            Console.Title = "Taulukko :O";
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("T3\n\n");

            String teksti;

            Console.WriteLine("Syötä tekstiä : ");
            teksti = Console.ReadLine();
            
            // Tuloste isoilla kirjaimilla.
            Console.WriteLine("\n"+teksti.ToUpper());

            // Tuloste, jossa A = !
            Console.WriteLine("\n\n"+teksti.Replace('A','!'));

            // Tuloste ilman välilyöntejä
            Console.WriteLine("\n"+teksti.Replace(" ", ""));

            // Tulosteessa joke merkin jälkeen väli
            String uusi = "";

            for (int i = 0; i <= teksti.Length-1; i++)
            {
                char j = teksti[i];
                String b = j.ToString();
                if (b != " ")
                {
                   uusi =  uusi + b + " ";  
                }
                else if (b == " ")
                {
                    continue;
                }
            }

            Console.WriteLine("\n" + uusi + "\n");
        }
    }
}
