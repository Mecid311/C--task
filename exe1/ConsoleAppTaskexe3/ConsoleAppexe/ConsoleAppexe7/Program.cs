using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int c = a % 10;
            switch (c)
            {
                case 1:
                    Console.WriteLine("I gun");
                    break;
                case 2:
                    Console.WriteLine("II gun ");
                    break;
                case 3:
                    Console.WriteLine("III gun ");
                    break;
                case 4:
                    Console.WriteLine("IV gun ");
                    break;
                case 5:
                    Console.WriteLine("V gun ");
                    break;
                case 6:
                    Console.WriteLine("VI gun ");
                    break;
                case 7:
                    Console.WriteLine("VII gun ");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadKey();
        }
    }
}
