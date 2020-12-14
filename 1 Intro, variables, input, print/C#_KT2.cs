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
            // Luodaan nimi muuttujat
            String sEtunimi;
            String sSukunimi;

            // Tulostaa kysymyksen
            Console.Write("Anna etunimi : ");

            // Lukee konsolista arvon ja asettaa muuttujaan
            sEtunimi = Console.ReadLine();

            Console.Write("Anna sukunimi : ");
            sSukunimi = Console.ReadLine();

            // Luodaan syötteestä koko nimi
            String sKokonimi = sEtunimi + " " + sSukunimi;

            // Tyhjentää konsolin
            Console.Clear();

            // Tulostetaan saatu nimi
            Console.WriteLine("Nimesi on {0}", sKokonimi);

        }
    }
}
