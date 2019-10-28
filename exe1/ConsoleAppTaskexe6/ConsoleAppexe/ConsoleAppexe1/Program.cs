using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir metn daxil edin:");
            string text = Console.ReadLine();
            int k = 0;
            int d = 0;
            for (int i = 0; i < text.Length; i++)
            {
                k++;
                if (i % 2 != 0)
                {
                    d++;
                }

            }
            string[] t = new string[d];
            for (int i = 0; i < d; i++)
            {
                
            }

            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
