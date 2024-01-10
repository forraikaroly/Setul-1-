using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim.
            int n;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            if (n < 2) 
            {
                Console.WriteLine("Numarul nu este prim");
            }
            for (int i = 2; i <= Math.Sqrt(n); i++) 
            {
                if (n%i== 0)
                {
                   Console.WriteLine("Numarul nu este prim ");
                }
            
            else 
            {
                Console.WriteLine("Numarul este prim"); 
            }
        }
    }
}
