using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int b = a;
            double hesab;

            hesab = a * 0.20;
            hesab = Math.Pow(hesab * 0.1,2);
            Console.WriteLine(hesab);
            Console.ReadKey();
        }
    }
}
