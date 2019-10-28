using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli bir eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            int k = 1;
            double hesab;
            while (a / 10 != 0)
            {
                a = a / 10;
                k++;
            }
            hesab = 4*Math.Pow(10, k)+b;
            hesab = (hesab *100+44) * 0.44;

            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
