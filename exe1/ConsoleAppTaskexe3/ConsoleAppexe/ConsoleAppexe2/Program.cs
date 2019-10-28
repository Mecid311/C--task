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
            Console.WriteLine("eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int c = a % 10;
            if (c == 7)
            {
                Console.WriteLine("ededin son reqemi 7 ile qurtarir");
            }
            else Console.WriteLine("ededin son reqemi 7 ile qurtarmir");

            Console.ReadKey();
        
    }
    }
}
