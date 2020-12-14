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
            Console.Title = "2-ulotteinen taulukko";
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Console.WriteLine("Sademäärät\n");

            double[,] dTaulu = new double[5, 4];
            double mittaus;
            String pv;

            // 2-silmukkaa taulukon ulottuvuuksien käyttöön
            // Ensimmäinen sitoo mittaukset oikeaan päivään ja toinen kysyy tarvittavat 4 arvoa
            for (int i = 0; i < dTaulu.GetLength(0); i++)
            {
                switch (i+1)
                {
                    case 1:
                        pv = "Maanatai";
                        Console.WriteLine("\n" + pv + "\n");
                        break;
                    case 2:
                        pv = "Tiistai";
                        Console.WriteLine("\n" + pv + "\n");
                        break;
                    case 3:
                        pv = "Keskiviiko";
                        Console.WriteLine("\n" + pv + "\n");
                        break;
                    case 4:
                        pv = "Torstai";
                        Console.WriteLine("\n" + pv + "\n");
                        break;
                    case 5:
                        pv = "Perjantai";
                        Console.WriteLine("\n" + pv + "\n");
                        break;  
                }

                for (int j = 0; j < dTaulu.GetLength(1); j++)
                {
                    Console.Write("Anna päivän " + (j+1) + "/4 mittaustulos millimetreinä : ");
                    mittaus = double.Parse(Console.ReadLine());
                    dTaulu[i, j] = mittaus;
                }
            }
            Console.WriteLine("\n");

            // Tulosten printtausta varten jälleen 2-silmukkaa
            // Esimmäinen käy läpi päivän ja toinen muodostaa mittausten summan
            // Lopuksi tulostetaan päivien keskiarvot desimaalin tarkkuudella
            for (int i = 0; i < dTaulu.GetLength(0); i++)
            {
                switch (i + 1)
                {
                    case 1:
                        pv = "Maanatai";
                        Console.Write(pv + "\t: ");
                        break;
                    case 2:
                        pv = "Tiistai";
                        Console.Write(pv + "\t\t: ");
                        break;
                    case 3:
                        pv = "Keskiviiko";
                        Console.Write(pv + "\t: ");
                        break;
                    case 4:
                        pv = "Torstai";
                        Console.Write(pv + "\t\t: ");
                        break;
                    case 5:
                        pv = "Perjantai";
                        Console.Write(pv + "\t: ");
                        break;
                }
                double summa = 0.0;
                for (int j = 0; j < dTaulu.GetLength(1); j++)
                {
                    
                    double luku = dTaulu[i, j];
                    summa = summa + luku;
                    
                }
                double ka = summa / 4;
                Console.Write(ka.ToString("0.0") + " mm\n");
                
            }

            Console.WriteLine();

        }
    }
}
