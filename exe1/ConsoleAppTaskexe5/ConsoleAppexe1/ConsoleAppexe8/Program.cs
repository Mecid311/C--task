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
            Console.WriteLine("eded daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int c = n;
            int k = 0;
            int hesab;
            int hesab1;
            while (n != 0)
            {
                int b = n % 10;
                n = n / 10;
                k++;
            }
            
            hesab = Convert.ToInt32(c / Math.Pow(10, k - 1));
            hesab1 = Convert.ToInt32(c % Math.Pow(10, 1));
            int hesab2 = Convert.ToInt32((hesab1 * Math.Pow(10, k) +c)*Math.Pow(10,1)+hesab);
            Console.WriteLine(hesab);
            Console.WriteLine(hesab1);
            Console.WriteLine(hesab2);

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
