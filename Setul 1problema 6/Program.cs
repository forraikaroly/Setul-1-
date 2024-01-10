using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            int a, b, c;
            Console.Write("Latura a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("Latura b=");
            b=int.Parse(Console.ReadLine());
            Console.Write("Latura c=");
            c=int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {

                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.Write("Numerele pot fii laturi ale triunghiului");
                }
                else
                {
                    Console.Write("Nu pot fii laturi ale triunghiului");
                }
            }
         }
    }
}
