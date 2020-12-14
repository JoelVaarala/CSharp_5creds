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

        static void ArvoJaTallennaTiedostoon()
        {
            double min = 1.4;
            double max = 5.8;
            Random rn = new Random();

            String tiedosto = "c:\\temp\\datat.txt";
            StreamWriter kirj = new StreamWriter(tiedosto, true);

            for (int i = 1; i<=40; i++)
            {
                var next = rn.NextDouble();
                double luku = min + (next * (max - min));
                double num = Math.Round((double)luku, 2);
                //Console.WriteLine(luku + "  " + num);
                kirj.WriteLine(num);
            }
            kirj.Close();
            LueTiedostosta();
        }

        static void LueTiedostosta()
        {
            double[] luvut = new double[40];
            int i = 0;
            String tiedosto = "c:\\temp\\datat.txt";
            StreamReader luk = new StreamReader(tiedosto);
            while (luk.EndOfStream == false)
            {
                luvut[i] = double.Parse(luk.ReadLine());
                i++;
                if (i == 39)
                    break;
            }
            luk.Close();

           
            TulostaTiedot(luvut);
        }

        static void TulostaTiedot(double[] luvut)
        {

            double avg, sum = 0;

            for (int j = 0; j <= luvut.Length - 1; j++)
            {
                double x = luvut[j];
                sum += x;
            }

            avg = sum / luvut.Length;
            Array.Sort(luvut);

            Console.WriteLine("\nSumma : " + sum + "\nKeskiarvo : " + avg + "\nSuurin : " + luvut[39] + "\nPienin : " + luvut[1] + "\n");
        }


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "6-2";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("File_s\n");

            ArvoJaTallennaTiedostoon();
             
        }
    }
}
