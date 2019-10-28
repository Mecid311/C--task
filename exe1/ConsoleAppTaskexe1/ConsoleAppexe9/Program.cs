using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("4  reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("4  reqemli bir eded daxil edin:");
            int e = int.Parse(Console.ReadLine());
            int d = c;
            int f = e;
            int b = a;
            double ferq;
            double ferq1;
            double ferq2;
            double hesab;
            double hesab1;
            double hesab2;
            double hesab3;
            hesab = a * 0.01;
            hesab1 = c * 0.02;
            hesab2 = e * 0.03;
            hesab3 = hesab2 * 0.07;
            
            
                ferq = hesab1 - hesab2 + hesab3;
                ferq1 = hesab2 - hesab1 + hesab3;
                ferq2 = hesab2 - hesab + hesab3;

            
        
            Console.WriteLine(ferq );
            Console.WriteLine(ferq1);
            Console.WriteLine(ferq2);
            Console.ReadKey();
        }
    }
}
