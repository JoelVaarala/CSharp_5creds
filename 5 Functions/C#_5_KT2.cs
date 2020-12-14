using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiCsharp
{
    class Program
    {

        static int KysyKoko()
        {
            // kysytään käyttäjältä taulun alkioiden määrä, funtio palauttaa 
            int koko = 1;
            Console.WriteLine("Syötä taulun koko : ");
            koko = int.Parse(Console.ReadLine());
            return koko;
        }

        static int[] LuoTaulukko(int koko)
        {
            // luodaan halutun kokoinen taulukko
            int[] arvosanat = new int[koko];
            return arvosanat;
        }

        static void ArvoArvosanat(int koko, int[] arvosanat)
        {
            // arvotaan random lukuja ja sijoitetaan taulukkoon
            Console.WriteLine("\nArvosanat:");
            Random random = new Random();
            for (int i = 0; i < koko; i++)
            {
                int num = random.Next(0, 6);
                arvosanat[i] = num;
                Console.Write(arvosanat[i] + " ");
            }
            Console.WriteLine();

        }

        static int TutkiHylatyt(int[] arvosanat)
        {
            // Funktio palauttaa hylattajen määrän, joten alkaa nollasta ja käydään talukko läpi __ jos 0 -> hylatyt +1
            int hylatyt = 0;
            for (int i = 0; i < arvosanat.Length; i++)
            {
                if (arvosanat[i] == 0)
                {
                    hylatyt++;
                }
            }
            return hylatyt;
        }

        static void Tulosta(int hylatyt)
        {
            //for (int i = 0; i<arvosanat.Length; i++ ){Console.WriteLine(arvosanat[i]);}
            Console.WriteLine("\nHylättyjä oli yhteensä : " + hylatyt + "\n");
        }

        static void Main(string[] args)
        {
           
            // Konsoli tyylisäätöä
            Console.Title = "5-2";
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("Functions\n");

            // Konsoli tyylisäätöä
            Console.Title = "5-2";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Functions\n");

            // Koko muuttuja saa arvokseen funktiossa kysytyn luvun
            int koko = KysyKoko();
            // Annetaan luku parametrina funktiolle, joka luo taulukon[koko]
            LuoTaulukko(koko);
            // Alustetaan taulukko, joka vastaa funktion luomaa
            int[] arvosanat = LuoTaulukko(koko);
            // Funktio saa parametrina koon ja taulukon (koko hieman turha voisi käyttää myös taulukko.length... mutta parametri harkkaa)
            ArvoArvosanat(koko, arvosanat);
            // Hylatyt muuttujan saa arvonsa tutkivasta funktiosta returnin avulla
            int hylatyt = TutkiHylatyt(arvosanat);
            // Lopuksi tulostetaan funktioiden palauttama arvo, kuinka monta 0 x-koon taulussa.
            Tulosta(hylatyt);


        }
    }
}
