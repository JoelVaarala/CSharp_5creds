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
           

            Console.WriteLine("Taulu2????\n\n");

            int[] luvut = new int[10];
            int luku;

            Random rn = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                do
                {
                    luku = rn.Next(9);
                    if (luku % 2 == 0 && luku != 0)
                        luvut[i] = luku;
                    else
                        continue;
                } while (luku%2 != 0 || luku == 0);
            }
            for (int i = 0; i < 10; i++)
            {

                Console.Write(luvut[i]+"\t");
            }
            
            
        }
    }
}
