using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_programarii_Setul_1_problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        // Sa se rezolve ecuatia ax+b=0 
        {
            double a, b, x;
            Console.WriteLine("a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = double.Parse(Console.ReadLine());
            
            if (a == 0)
            {
                Console.WriteLine("Nu se poate");
            }
            if (b == 0)
            {
                Console.WriteLine("0");
            }
            
            x = (-b) / a;
            
            Console.WriteLine($"Necunoscuta x este{x}");
        }
    }
}
