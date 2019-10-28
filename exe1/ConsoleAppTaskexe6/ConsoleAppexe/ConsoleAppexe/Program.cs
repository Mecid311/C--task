using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir metn daxil edin:");
            string text = Console.ReadLine();
            double k = 0;
            double c = 0;
            double d;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')  k++;
                if (text[i] == 'b') c++;
                }
            if (c > k) { d = c / k; Console.WriteLine($"b  a -dan {d} defe boyukdur! "); }
            if (c < k) { d = k / c; Console.WriteLine($"a  b -den {d} defe boyukdur! "); }
            Console.ReadKey();
        }
    }
}
