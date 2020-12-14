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
            // Luodaan arvattava vakio 1-500
            const int ARVATTAVA_LUKU = 45;
            int arvaus;
            int spin;

            bool jatko = true;
           
            // Konsoli tyylisäätöä
            Console.Title = "Aika arvailla lukuja...";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään ensimmäinen arvaus
            Console.WriteLine("Arvaa luku (1-500) : ");
            arvaus = int.Parse(Console.ReadLine());

            // For - lause, jossa ehtona luku halutulta väliltä, sekä kierros laskuri
            for (spin = 0; arvaus <= 500 && arvaus >= 1 && jatko == true; spin++)
            {
                // Jos arvaus osuu oikeaan toteutetaan tämä
                if (arvaus == ARVATTAVA_LUKU)
                {
                    Console.WriteLine("\nOikein, arvasit luvun {0} kerralla!\n", spin+1);
                    jatko = false;
                    // loopista poistuminen onnistuisi myös break komennolla, mutta suositusten vuoksi on for() ehtoon... 
                    // lisätty boolean joka mahdollistaa loopista poistumisen.
                    // break;
                }
                // Jos arvaus on liian suuri suoritetaan tämä ja kysytään uusi arvaus
                else if (arvaus > ARVATTAVA_LUKU)
                {
                    Console.WriteLine("Annoit liian ison luvun");
                    Console.WriteLine("\nArvaa luku (1-500) : ");
                    arvaus = int.Parse(Console.ReadLine());
                }
                // Jos arvaus on liian pieni suoritetaan tämä ja kysytään uusi arvaus
                else if (arvaus < ARVATTAVA_LUKU)
                {
                    Console.WriteLine("Annoit liian pienen luvun");
                    Console.WriteLine("\nArvaa luku (1-500) : ");
                    arvaus = int.Parse(Console.ReadLine());
                }
            }

            // "Virhe viesti" jos vastaaja ei anna numeroa 1-500
            if(arvaus > 500 || arvaus < 1)
            Console.WriteLine("\nOliko liian vaikeaa valita annetulta väliltä?\n");

        }
    }
}
