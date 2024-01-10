using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]
            int a, b, n, count = 0;
            Console.WriteLine("Introduceti valorile lui a b si n");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if (a < b)
                for (int i = a; i <= b; i++)
                {
                    if (i % n == 0)
                    {
                        count++;
                    }

                }
            Console.WriteLine($"In intervalul {a} si {b} sunt {count} divizori");

        }
    }
}

        
    

