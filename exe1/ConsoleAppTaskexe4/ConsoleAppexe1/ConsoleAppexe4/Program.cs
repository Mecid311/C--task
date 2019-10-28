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
            int b;
            
            for (int i = 1; i <= 1000; i++)
            {
                b = i % 10;
                if (i % 3 == 0 && b!=3) Console.WriteLine(" " + i);
            }



            Console.ReadKey();
        }
    }
}
