using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int b;
            int c;
            int d;

            b = a % 10000000;
            c = b / 10;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
