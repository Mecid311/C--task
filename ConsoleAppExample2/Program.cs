using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Example2 kvardratdan -char ni cix*/
            Console.Write("a ededini daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b ededini daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c ededini daxil edin:");
            int c = int.Parse(Console.ReadLine());
            Console.Clear();
            double cavab = Math.Pow((a + b), 2) - c;
            Console.Write(cavab);
            Console.ReadKey();

        }
    }
}
