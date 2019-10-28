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
                if (!d && Hesabla(i) == 3)
                {

                    Console.WriteLine(i);
                }


            }
            Console.ReadKey();
        }
        private static int Hesabla(int n)
        {
            int cem = 0;
            int b;
            while (n != 0)
            {
                b = n % 10;
                n = n / 10;
                cem += b;
            }
            return cem;
        }
    }
}
