using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 8 == 0) Console.WriteLine(i);
            }
            


            Console.ReadKey();
        }
    }
}
