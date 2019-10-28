using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = 1; i < 1000; i++)
            {
                int c;
              
                Hesabla(i);
                if (i < 100) c = i / 10;
                else c = i / 100;
                



                if (i % 2 == 0 && Hesabla(i) % 2 != 0 && c%2!=0) Console.WriteLine(i);
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
