using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massivde nece element olsun?:");
            int k = int.Parse(Console.ReadLine());
            int[] eded = new int[k];
            int max = 0;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Massivin {i+1}-ci elementini daxil edin:");
                eded[i]= int.Parse(Console.ReadLine());
                if (eded[i] > max) max = eded[i];
            }
            Console.WriteLine("max="+max);
            Console.ReadKey();
        }
    }
}
