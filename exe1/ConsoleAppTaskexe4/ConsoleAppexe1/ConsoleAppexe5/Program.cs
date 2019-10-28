using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = 1; i <= 1000; i++)
            {
                Hesabla(i);
                if (i % 5 == 0 && Hesabla(i)% 5 == 0) Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        private static int Hesabla(int n)
        {
            int cem = 0;
            int b;
            while(n!=0)
            {
                b = n % 10;
                n = n / 10;
                cem += b;
            }
            return cem;
        }
    }
}
