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

        static void ArvoTaulukkoon(int[] luvut)
        {
            // Luodaan random olio
            Random rn = new Random();

            // täytetään alkiot 0-103
            for (int i = 0; i<104; i++)
            {
                // valitaan lukuja väliltä 9-29
                int luku = rn.Next(9, 30);
                // Lisätään luvut taulukkoon "luvut"
                luvut[i] = luku;
            }

            /* Testi josta näkee nopeasti talukkoon lisätyt numerot
             
            Array.Sort(luvut);
            for (int i = 0; i<luvut.Length; i++)
            {
                Console.WriteLine(luvut[i]);
            }*/

            // Kutsutaan seuraavaa funktiota
            TallennaTiedoston(luvut);
        }

        static void TallennaTiedoston(int[] luvut)
        {
            // Esitellään haluttu tiedosto ja "avataan" StreamWriter
            String tiedosto = "c:\\temp\\numerot.txt";
            StreamWriter kirj = new StreamWriter(tiedosto, true);

            // Kirjoitetaan kaikki luvut talusta tiedostoon
            foreach (int luku in luvut)
            {
                kirj.WriteLine(luku);
            }
            // Suljetaan yhteys
            kirj.Close();

            /*for (int i = 0; i <= 104; i++) {
                int luku = luvut[i];
                kirj.WriteLine(luku);
            }*/

            LueLuvutJaTulostaParittomat();
        }

        static void LueLuvutJaTulostaParittomat()
        {
            // Uusi taulu johon numerot tiedosta luetaan
            int[] numerot = new int[104];
            int i = 0;

            // Esitetään taas haluttu tiedosto ja tällä kertaa luetaan sisältöä
            String tiedosto = "c:\\temp\\numerot.txt";
            StreamReader luk = new StreamReader(tiedosto);
            while (luk.EndOfStream == false)
            {
                numerot[i] = int.Parse(luk.ReadLine());
                i++;               
            }
            luk.Close();

            // Tulostaa vain parittomat
            foreach(int num in numerot)
            {
                if(num % 2 != 0)
                Console.WriteLine(num);
            }
        }

        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "Kysymys 3";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\n");

            // Luodaan  104-alkioinen taulukko
            int[] luvut = new int[104];

            // Kutsutaan funktiota
            ArvoTaulukkoon(luvut);

        }
    }
}
