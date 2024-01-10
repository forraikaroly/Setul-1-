using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor.
            int a, b;
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b=int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Dupa swap valorile sunt a={a} si b={b}");
        }
    }
}
