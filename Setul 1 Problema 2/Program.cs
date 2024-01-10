using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_Problema_2
{
    internal class Program
    {
        //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.Write("Ecuatia nu are solutii");
            }

            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1= {x1}");
                Console.WriteLine($"x2= {x2}");
            }
            else
               if (delta == 0)
            {
                Console.WriteLine($"Ecuatia are o singura solutie= {-b / (2 * a)}");

            }
            else
            {
                // delta < 0; 
                Console.WriteLine($"Solutii complexe x1,x2= ({-b} +- {Math.Sqrt(-delta)} * i) / {2 * a} ");
            }
            Console.ReadKey();
        }
    }
}
