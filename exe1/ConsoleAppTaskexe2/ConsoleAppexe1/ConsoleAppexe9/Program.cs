using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("9 reqemli eded daxil edin: ");
            int a = int.Parse(Console.ReadLine());
            int c ;
            int d = 0;
            int k = 0;
            

            while (a != 0)
            {
                c = a % 10;
                a = a / 10;
                k++;
                Console.WriteLine(k);
            }

            for (int i = 1; i < k; i++)
            {
                if (k % 2 != 0)
                {
                    d++;
                    
                }
            }
            Console.WriteLine(d);



            Console.ReadKey();
        }
    }
}
