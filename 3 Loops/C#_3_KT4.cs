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
           
            // Konsoli tyylisäätöä
            Console.Title = "Askelluksia ja tulostuksia";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // muuttujien alustamista
            int alku,
                loppu,
                askel;

            bool jatko = true;

            // "kääritty while loopin sisään joka mahdollistaa kysymysten toistamisen jos syötteessä vikaa"
            while (jatko == true) { 

            Console.WriteLine("Anna aloitus luku : ");
            alku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna lopetus luku : ");
            loppu = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna askeleen suuruus : ");
            askel = int.Parse(Console.ReadLine());

            if (alku < loppu && askel != 0)
            {
                    // clear console
                    Console.Clear();

                    // loops (3)
                    // for loop
                    for (int i = alku; i <= loppu; i+=askel)
                    {
                        Console.Write(i+" ");
                    }

                    // tyhjä rivi tulosteeseen erottamaan looppien tulokset
                    Console.WriteLine(" ");

                    int luku = alku;
                    // while loop
                    while (luku <= loppu)
                    {
                        Console.Write(luku+" ");
                        luku += askel;
                    }

                    // tyhjä rivi tulosteeseen erottamaan looppien tulokset
                    Console.WriteLine(" ");

                    // do - while loop
                    int luku2 = alku;
                    do
                    {
                        Console.Write(luku2+" ");
                        luku2 += askel;
                    } while (luku2 <= loppu);

                    // set jatko = false
                    jatko = false;
            }
                else
                {
                    // virheellisen syötteen tapauksessa virhe ilmoitus ja kyssärit uudelleen
                    Console.Clear();
                    Console.WriteLine("Yritetäänpäs uudelleen\n");
                    
                }
                
                // siistimpi lopetus tulosteeseen...
                Console.WriteLine("");

            }

        }
    }
}
