using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir eded daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int b;
            int k = 0;
            while (n != 0)
            {
                b = n % 10;
                n = n / 10;
                k++;
                if (b == 5) Console.WriteLine("Beli");
                else Console.WriteLine("Xeyr");
                if (k == 1) break;
            }
            Console.ReadKey();
        }
    }
}
