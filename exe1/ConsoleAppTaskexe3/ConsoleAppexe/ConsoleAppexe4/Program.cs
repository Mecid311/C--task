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
            Console.WriteLine("2 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int c = a % 10;
            int d = a / 10;
            int e = c + d;

            if (e%2==0) Console.WriteLine($"hasil = {c*d}");
            else Console.WriteLine("Null");
            Console.ReadKey();

        }
    }
}
