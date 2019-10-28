using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int c = n;
            int k = 0;
            int hesab;
            while (n != 0)
            {
                int b = n % 10;
                n = n / 10;
                k++;
            }

            hesab = Convert.ToInt32(c / Math.Pow(10, k-1));
            hesab = hesab + c * 10;
            Console.WriteLine(hesab);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
