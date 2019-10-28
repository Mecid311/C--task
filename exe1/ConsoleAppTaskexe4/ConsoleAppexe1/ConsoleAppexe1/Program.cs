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
            int cem = 0;
            for (int i = 1; i <= 1000; i++)
            {
                cem += i;
               
            }
            if (cem % 7 == 0) Console.WriteLine("bolunur!");
            else Console.WriteLine("bolunmur!");


            Console.ReadKey();
        }
    }
}
