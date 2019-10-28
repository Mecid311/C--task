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
            Console.WriteLine("5 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("5 reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            int d = c;
            int b = a;
            int k = 1;
            double cem;
            double hesab;
            while (a / 10 != 0 && c/10!=0)
            {
                a = a / 10;
                c = c / 10;
                k++;
            }
            cem = b + d;
            hesab = 5 * Math.Pow(10, k) + cem;
            hesab = (hesab * 10 + 5)*0.05;

            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
