using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1000)
            {
                Hesabla(i);
                i++;
                if(Hesabla(i)==11) Console.WriteLine(i);

            }
            Console.ReadKey();
        }

        private static int Hesabla(int n)
        {
            int b;
            int cem = 0;
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
