using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe12
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
            Console.WriteLine("3 reqemli bir eded daxil edin:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("3  reqemli bir eded daxil edin:");
            int m= int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            int h = g;
            int n = m;
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

            hesab = a * 0.05;
            hesab1 = c * 0.05;
            hesab2 = e * 0.05;
            hesab4 = hesab * hesab1 * hesab2 ;

            hesab5 = g * 0.03;
            hesab6 = m * 0.03;
            hesab7 = hesab5 + hesab6 ;

            hesab8 = (hesab4+hesab7) * 0.1;

            Console.WriteLine(hesab8);
            Console.ReadLine();
            
        }
    }
}
