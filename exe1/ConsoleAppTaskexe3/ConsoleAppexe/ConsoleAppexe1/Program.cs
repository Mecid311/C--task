using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b ededini daxil edin:");
            int b = int.Parse(Console.ReadLine());

            if (a%b==0)
            {
               int c = a / b;
                Console.WriteLine("c="+c);
            }
            else Console.WriteLine("eded bolunmur");

            Console.ReadKey();
        }
    }
}
