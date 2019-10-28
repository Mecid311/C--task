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
            Console.WriteLine("eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            string d = "";
            for (int i = 1; i <= a; i++)
            {
                d = Convert.ToString(i);
            }
            Console.Clear();
            switch (Convert.ToInt32(d))
            {
                case 1:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Yanvar");
                    break;
                case 2:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Fevral ");
                    break;
                case 3:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Mart ");
                    break;
                case 4:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Aprel ");
                    break;
                case 5:
                    Console.WriteLine($"{Convert.ToInt32(d)}.May ");
                    break;
                case 6:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Iyun ");
                    break;
                case 7:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Iyul ");
                    break;
                case 8:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Avqust ");
                    break;
                case 9:
                    Console.WriteLine($"{Convert.ToInt32(d)}.sentyabr ");
                    break;
                case 10:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Oktyabr ");
                    break;
                case 11:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Noyabr ");
                    break;
                case 12:
                    Console.WriteLine($"{Convert.ToInt32(d)}.Dekabr ");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }

            Console.ReadKey();


        }
    }
}

