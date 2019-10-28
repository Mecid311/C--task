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
            Console.WriteLine("bir eded daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int c = n;
            while (n != 0)
            {
                int b = n % 10;
                n = n / 10;

                if (Tap(c))
                {
                    cem(c);
                    Console.WriteLine(c);
                    break;
                }
                if (!Tap(c))
                {
                    hasil(c);
                    Console.WriteLine(c);
                    break;
                }

            }
            Console.ReadKey();
        }
        private static int cem(int n)
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
        private static int hasil(int n)
        {
            int b;
            int hasil = 1;
            while (n != 0)
            {
                b = n % 10;
                n = n / 10;
                hasil *= b;
            }
            return hasil;

        }
        static bool Tap (int n)
        {
           while(n!=0){
                int b = n % 10;
                if (b == 5)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
            }
}
        
    }

