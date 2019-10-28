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
            Console.WriteLine("eded daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int c = n;
            int b;
            double hesab;
            n = n % 10;


            hesab = c * Math.Pow(10, 1);
            hesab = hesab + n;
            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
