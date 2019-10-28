using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaskexe
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
            Console.WriteLine(k);
            hesab = 7 * Math.Pow(10, k)+b;
            hesab =(hesab * 10) + 8;
            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
