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


        static void Main(string[] args)
        {
            // Konsoli tyylisäätöä
            Console.Title = "6-1";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Hakemistot\n");

            DirectoryInfo drInfo = new DirectoryInfo("c:\\temp");

            if (drInfo.Exists != true)
            {
                drInfo.Create();
            }

            // Luodaan alihakemistot
            for (int i = 1; i<=10; i++) 
            {
                drInfo.CreateSubdirectory("alihakemisto"+i);
            }

            // Lisätään hakemistot taulukkoon
            string[] hakemistot = Directory.GetDirectories("c:\\temp");

            // Testaus print onko hakemistot taulukossa --- miksiköhän hakemistot[1] tulostaa "alihakemisto10" & index 9 tulostaa alihakemisto9 ??
            // Console.WriteLine(hakemistot[0].ToString()+ "\n ... \n" +hakemistot[1].ToString());

            foreach (string h in hakemistot)
            {
                Console.WriteLine(h);
            }

            //Console.WriteLine(drInfo.FullName);

            
            for(int i = 1; i<11; i++)
            {
                DirectoryInfo dr = new DirectoryInfo("c:\\temp\\alihakemisto"+i);
                dr.Delete(true);
            }

        }
    }
}
