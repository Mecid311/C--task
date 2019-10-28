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
            Console.WriteLine("4 reqemli eded daxil edin:");
            int a=int.Parse(Console.ReadLine());
            int nisbet;
            int qaliq;
            int cem = 0;
            
            while (a!= 0)
            {
                nisbet = a / 10;
                qaliq = a % 10;
                a = nisbet;
                cem += qaliq;
            }
            Console.WriteLine(cem);
            Console.ReadKey();
           
            
        }
    }
}
