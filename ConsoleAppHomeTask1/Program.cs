using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTask1
{
    class Program
    {
        static void Main(string[] args)
        { //EXsample1(cut-cut cemle, ekrana yazdir;
            Console.WriteLine("a ededini daxil edin:");
            string A = Console.ReadLine();
            Console.WriteLine("b ededini daxil edin:");
            string B = Console.ReadLine();
            Console.WriteLine("c ededini daxil edin:");
            string C = Console.ReadLine();
            Console.Clear();
            int a, b, c;
            a = int.Parse(A);
            b = int.Parse(B);
            c = int.Parse(C);
            int cavab = a + b;
            int cavab1 = a + c;
            int cavab2 = b + c;

            Console.WriteLine($"{a}+{b}={cavab} {a}+{c}={cavab1} {b}+{c}={cavab2}");
            Console.ReadLine();


        }
    }
}
