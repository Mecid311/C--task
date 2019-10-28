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
            
            Console.WriteLine("3 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int c = a % 10;
            int d = a / 100;
            int h = a / 10;
            int f =  h % 10;

            if (d + c == f) Console.WriteLine("Beli");
            else Console.WriteLine("Xeyr");
            Console.ReadKey();
        }
    }
}
