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
            Console.WriteLine("5 reqemli eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            int qaliq;
            int nisbet = a;
            int k = 0;
            int cem = 0;
            int cem1 = 0;

            while (a != 0)
            {
                qaliq = a % 10;
                a = a / 10;
                k++;
                }
            for (int i = 0; i < k; i++)
            {
                if (i == 1) { cem += Convert.ToInt32(nisbet % Math.Pow(10, i)); }
                if (i==k-1) { cem += Convert.ToInt32(nisbet / Math.Pow(10, i)); }

                cem1 = Convert.ToInt32(Math.Pow(cem, 2));
            }

            Console.WriteLine(cem1);
            Console.ReadKey();





        }
    }
}
