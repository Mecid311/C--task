using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("6  reqemli bir eded daxil edin:");
            int e = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            double cem;
            double hesab;
            double hesab1;
            double hesab2;
            hesab = a * 0.1;
            hesab1 = c * 0.1;
            hesab2 = e * 0.1;
            cem = (hesab + hesab1+hesab2) * 0.1;


            Console.WriteLine(cem);
            Console.ReadKey();
        }
    }
}
