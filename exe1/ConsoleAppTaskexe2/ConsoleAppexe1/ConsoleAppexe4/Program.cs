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
            Console.WriteLine("5 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int qaliq;
            int nisbet = a;
            int k = 0;
            int cem = 0;
            double hesab=0;

            while (a != 0)
            {
                qaliq = a % 10;
                a = a / 10;
                k++;
            }
            for (int i = 0; i < k; i++)
            {
                
                if (i == k - 1) { cem += Convert.ToInt32(nisbet / Math.Pow(10, i)); }
                hesab = nisbet * Math.Pow(10, 1) + cem;
            }

            Console.WriteLine(hesab);
            Console.ReadKey();

        }
    }
}
