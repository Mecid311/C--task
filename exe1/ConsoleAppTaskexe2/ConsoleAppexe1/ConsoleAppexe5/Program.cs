using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int b;
            int c;
            int d;
            int cem = 0;

            b = a % 1000000;
            c = b / 1000;

            while (c != 0)
            {
                d = c % 10;
                c = c / 10;
                cem += d;
            }
            
            Console.WriteLine(cem);
            Console.ReadKey();
        }
    }
}
