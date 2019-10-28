using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("eded cut ededdir!");
            }
            else Console.WriteLine("eded tek ededdir!");

            Console.ReadKey();
        }
    }
}
