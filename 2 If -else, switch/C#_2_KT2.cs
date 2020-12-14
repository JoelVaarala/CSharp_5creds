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
            // Muuttujat
            int kk;

            // Konsoli tyylisäätöä
            Console.Title = "Kuukausi tutka";
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BufferHeight = 50;
            Console.BufferWidth = 60;

            // Kysytään kuukauden numero
            Console.Write("Anna kuukauden nro (1-12) : ");
            kk = int.Parse(Console.ReadLine());

           // Luodaan switch-rakenne kuukauden selvittämiseksi
           switch (kk)
            {
                case 1:
                    Console.WriteLine("Tammikuu");
                    break;
                case 2:
                    Console.WriteLine("Helmikuu");
                    break;
                case 3:
                    Console.WriteLine("Maaliskuu");
                    break;
                case 4:
                    Console.WriteLine("Huhtikuu");
                    break;
                case 5:
                    Console.WriteLine("Toukokuu");
                    break;
                case 6:
                    Console.WriteLine("Kesäkuu");
                    break;
                case 7:
                    Console.WriteLine("Heinäkuu");
                    break;
                case 8:
                    Console.WriteLine("Elokuu");
                    break;
                case 9:
                    Console.WriteLine("Syyskuu");
                    break;
                case 10:
                    Console.WriteLine("Lokakuu");
                    break;
                case 11:
                    Console.WriteLine("Marraskuu");
                    break;
                case 12:
                    Console.WriteLine("Joulukuu");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }


        }
    }
}
