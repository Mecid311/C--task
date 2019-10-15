using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example3
            Console.Write("a ededini daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("b ededini daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("c ededini daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.Clear();

            double cavab = Math.Pow((a * b * c), 1 / 3.0);
            Console.WriteLine("Hendesi orta:" + cavab);
            double cavab1 = (a + b + c) / 3;
            Console.WriteLine("Ededi orta:" + cavab1);
            Console.ReadKey();


        }
    }
}
