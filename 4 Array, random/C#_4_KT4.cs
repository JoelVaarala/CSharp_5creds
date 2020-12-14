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
            Console.Title = "Ja illan lottorivi on...";
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("T4\n\n");

            int[] numerot = new int[8];
            int luku;
            List<int> num = new List<int>(); 

            Random rnd = new Random();

            // Arvotaan numerot
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    luku = rnd.Next(1, 41);
                    // Käytetään listaa apuna lukujen uniikkiuden tarkastamiseksi
                } while (num.Contains(luku));
                // Jos luku on unniikki niin lisätään se listaan ja taulukon alkioon "i"
                num.Add(luku);
                numerot[i] = luku;
            }
            // Tarkistus onko lisänumero oikein
            //Console.WriteLine(numerot[7]);

            // Järjestetään ensimmäiset 7 numeroa, jättäen viimeisin (lisänumeron) sortin ulkopuolelle
            Array.Sort(numerot, 0, 7);

            // Tulostetaan kaikki päänumerot
            for (int i = 0; i<7; i++) 
            {
                Console.Write(numerot[i]+" "); 
            }
            // Ja lisänumeron tulostus
            Console.Write("+ " + numerot[7] + "\n\n");
        }
    }
}
