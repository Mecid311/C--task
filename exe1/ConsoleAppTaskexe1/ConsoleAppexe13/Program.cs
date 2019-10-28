using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe13
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
            Console.WriteLine("6 reqemli bir eded daxil edin:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int x = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            int h = g;
            int n = m;
            int y = x;
            int k=1;
            double hesab;
            double hesab1;
            double hesab2;
           

            hesab = a + c + e + g + m + x;
            Console.WriteLine(hesab);
            while (a / 10 != 0 && e/10!=0)
            {
                a = a / 10;
                e = e / 10;
                k++;
            }
            hesab1 = b * Math.Pow(10, k);
            hesab1 = hesab1 + f;
            Console.WriteLine(hesab1);

            hesab2 = (-1*(hesab - hesab1))*0.1+h+n  ;
            Console.WriteLine(hesab2);
            Console.ReadKey();
        }
    }
}
