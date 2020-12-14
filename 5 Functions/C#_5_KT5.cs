using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {

        static void LuoTaulukko()
        {
            float[] taulu = new float[7];
            KysyArvot(taulu);
        }

        static void KysyArvot(float[] taulu)
        {
            float luku;
            bool lis;

            for (int i = 0; i<taulu.Length; i++)
            {
                // arvo numero -> jos success niin continue, jos fail niin loop uudestaan kunnes success

                    Console.WriteLine("\nSyötä taulukkoon float luku : ");
                    lis = float.TryParse(Console.ReadLine(), out luku);

                while(lis == false)
                {
                    Console.WriteLine("try again");
                    Console.WriteLine("\nSyötä taulukkoon float luku : ");
                    lis = float.TryParse(Console.ReadLine(), out luku);
                }

                taulu[i] = luku;
            }

            LajitteleArvot(taulu);
        }

        static void LajitteleArvot(float[] taulu)
        {
            // Lajittelu taulukon arvot nousevaan järjestykseen
            Array.Sort(taulu);

            TulostaTiedot(taulu);
        }

        static void TulostaTiedot(float[] taulu)
        {
            // Tulosta taulu + talun ensimmäinene ja viimeinen arvo (suurin ja pienin)
            Console.WriteLine("\n| " + String.Join(" | ", taulu) + " |");
            Console.WriteLine("Pienin : " + taulu[0]);
            Console.WriteLine("Suurin : " + taulu[6] + "\n");
        }


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "5-5";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Functions\n");

            LuoTaulukko(); 

        }
    }
}
