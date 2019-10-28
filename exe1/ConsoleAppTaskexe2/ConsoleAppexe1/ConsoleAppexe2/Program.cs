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
            Console.WriteLine("6 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
           int  cem = 0;

            while (a != 0)
            {
                if (a / 1000 == 0)
                {
                    cem += a % 10;
                }
                a /= 10;
            }
            Console.WriteLine(cem);
            Console.ReadKey();
      
            

          

            Console.WriteLine(cem);
            Console.ReadKey();
        }
    }
}
