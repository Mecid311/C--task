using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("3 reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("4  reqemli bir eded daxil edin:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("4 reqemli bir eded daxil edin:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("5  reqemli bir eded daxil edin:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("5  reqemli bir eded daxil edin:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int r = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            int h = g;
            int n = m;
            int y = x;
            int l = r;
            int k = 1;
            int s = 1;
            double hesab;
            double hesab1;
            double hesab2;
            double hesab3;
            hesab = a + c+(e*g) ;
            Console.WriteLine(hesab);
            hesab2 = a * c;
            while (hesab2 / 10 == 0)
            {
                hesab2 = hesab2 / 10;
                s++;
            }
            hesab3 = hesab2 * Math.Pow(10, k);
            hesab3 = (hesab3 + 1);
            Console.WriteLine(hesab3);
            while (hesab/ 10 == 0)
            {
                hesab = hesab / 10;
                k++;
            }
            Console.WriteLine("k="+k);
            hesab1 = hesab * Math.Pow(10, k);
            hesab1 = (((((hesab1 + 7)+(x+m)-hesab3+r-(a+c+e+g))*0.18)*0.03)*0.01)+(m+x);
            Console.WriteLine(hesab1);
            Console.ReadKey();


        }
    }
}
