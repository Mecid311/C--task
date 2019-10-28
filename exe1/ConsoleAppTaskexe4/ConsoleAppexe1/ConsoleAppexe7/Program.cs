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
            int k;
            for (int i = 1; i < 1000; i++)
            {
                k = i;
                bool d = false;
                while (k != 0 && !d)
                {
                    if (k % 10 == 3)
                    {
                        d = true;
                    }
                    k /= 10;
                }
             
            }
            Console.ReadKey();
        }
        
    }
}
