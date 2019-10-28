using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int c = a % 10;
            int d = a / 10;

            if (c == d) Console.WriteLine("Ededin reqemleri =-dir");
            else Console.WriteLine("Ededin reqemleri = deyil");
            Console.ReadKey();

        }
    }
}
