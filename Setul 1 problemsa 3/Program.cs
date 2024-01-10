using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problemsa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            double n, k;
            Console.Write("Numarul n=");
            n= double .Parse(Console.ReadLine());
            Console.Write("Este divizibil sau nu cu k=");
            k = double.Parse(Console.ReadLine());
            if (n == 0 )
            {
                Console.WriteLine("Numarul nu are divizori");
            }
            if (n % k == 0)
            {
                Console.WriteLine("N se divide cu k");
            }
            else
            {
                Console.WriteLine("N nu se divide cu k");
            }
        }
    }
}
