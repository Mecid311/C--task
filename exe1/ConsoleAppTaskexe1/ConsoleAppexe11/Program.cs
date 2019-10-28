using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("5 reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("5  reqemli bir eded daxil edin:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("5  reqemli bir eded daxil edin:");
            int g = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            int h = g;
            double hesab;
            double hesab1;
            double hesab2;
            double hesab3;

            hesab = a + e;
            hesab1 = c + g;
            hesab2 = e * 0.03;
            hesab3 = hesab * hesab1 - hesab2;
            Console.WriteLine(hesab3);
            Console.ReadKey();
        }
    }
}
