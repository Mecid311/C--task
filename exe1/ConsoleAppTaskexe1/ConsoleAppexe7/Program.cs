using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("7  reqemli bir eded daxil edin:");
            int c = int.Parse(Console.ReadLine());
            int d = c;
            int b = a;
            double cem;
            double hesab;
            double hesab1;
            hesab = a * 0.04;
            hesab1 = c * 0.09;
            cem = (hesab + hesab1)*0.1;
           

            Console.WriteLine(cem);
            Console.ReadKey();
        }
    }
}
