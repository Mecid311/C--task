using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            double hesab;

            hesab = a * 0.18;
            hesab = hesab * 0.03;
            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
