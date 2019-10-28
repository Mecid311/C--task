using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4 reqemli eded daxil edin: ");
            int a = int.Parse(Console.ReadLine());
            int c = a;
           
            int k = 0;
            double hesab;

            while (c != 0)
            {
                c = c / 10;
                k++;
            }
            int[] b = new int[k];
            string d="";
            
            for ( int i = 0; i < k; i++)
            {
                b[i] = a % 10;
                a = a / 10;
                d =d+b[i].ToString();
            }
            hesab = 8 * Math.Pow(10, k) + Convert.ToInt32(d);
            hesab = (hesab * 10) + 8;
            Console.Write(hesab);
            Console.ReadKey();
        }
    }
}
