using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 reqemli eded daxil edi:");
            int a = int.Parse(Console.ReadLine());
            int b;
            int c;
            int d;
            b = a / 100;
            c = b % 10;
            Console.WriteLine("axirdan 3-cu reqem: "+c);
            d = a % 10;
                Console.WriteLine("sonuncu reqem: "+d); 
            int cem = c + d;
            Console.WriteLine("cemi= "+cem);
            Console.ReadKey();
        }
    }
}
