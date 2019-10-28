using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("6 reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int g = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            int h = g;
            double hesab;
            double hesab1;
            double hesab2;
            double hesab3;
            double hesab4;
            double hesab5;
            double hesab6;
            double hesab7;
            double hesab8;
            double hesab9;
            double hesab10;

            hesab = a * 0.1;
            hesab1 = c * 0.1;
            hesab2 = e * 0.1;
            hesab3 = g * 0.1;
            hesab4 = hesab + hesab1 + hesab2 + hesab3;

            hesab5 = a * 0.15;
            hesab6 = c * 0.15;
            hesab7 = e * 0.15;
            hesab8 = g * 0.15;
            hesab9 = hesab5+ hesab6 + hesab7 + hesab8;

            hesab10 = ((hesab4 * hesab9)*0.1)*0.11;
            Console.WriteLine(hesab10);
            Console.ReadKey();
        }
    }
}
