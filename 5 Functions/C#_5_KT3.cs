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

        static void KysyHypynPituus()
        {
            // Kysytään käyttäjältä hypyn pituus
            double pituus;
            Console.WriteLine("Hypyn pituus 0.5m tarkkuudella : ");
            pituus = double.Parse(Console.ReadLine());
            KysyTuomareidenPisteet(pituus);
        }

        static void KysyTuomareidenPisteet(double pituus)
        {
            // Kysytään 5 tuomarin pisteet ja asetetaan taulukkoon
            Console.WriteLine();
            double[] pisteet = new double[5];
            for (int i = 0; i < 5; i++)
            {
                double piste;
                Console.WriteLine("Anna tuomarin " + (i+1) + ". pisteet : ");
                piste = double.Parse(Console.ReadLine());
                pisteet[i] = piste;
            }
            // Kutsutaan laskevaa funtiota antaen edellisten funktioden tarvittavat arvot parametrina
            LaskeHypynPisteet(pisteet, pituus);
        }

        static void LaskeHypynPisteet(double[] pisteet, double pituus)
        {
            // Annetaan vakioksi kriittinen piste 90m
           const int KR_PISTE = 90;

            Array.Sort(pisteet);
            //Array.ForEach<double>(pisteet, n => Console.WriteLine(n));  --> voi tarkistaa onnistuiko sort

            // lasketaaan 3 keskimmäistä arvoa yhdeksi muuttujaksi
            double tPisteet = 0;
            for (int i = 1; i<4; i++)
            {
                tPisteet += pisteet[i];
            }
            // Hypynpisteiden laskukaava
            double hyppyPisteet = (pituus - KR_PISTE) * 1.8 + tPisteet + 60;

            // Kutsutaan tulosta funktiota ja annetaan hypyn pisteet parametrina
            Tulosta(hyppyPisteet);
        }

        static void Tulosta(double hyppyPisteet)
        {
            
            Console.WriteLine("\nHypyn pisteet olivat : " + hyppyPisteet);
        }


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "5-3";
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Functions\n");

            KysyHypynPituus();
            

        }
    }
}
