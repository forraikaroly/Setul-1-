using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

             long n, k;
            Console.Write("n=");
            n=long.Parse(Console.ReadLine());
            Console.Write("k=");
            k=long.Parse(Console.ReadLine());
            if (k > 0)
            {
                for ( int i = 0; i < k-1; i++)
                {
                    n /= 10;
                }
                long y = n % 10;
                Console.WriteLine($"A {k} cifra de la sfarsitul numarului este {y}");
            }
            else
            {
                Console.WriteLine("Valoarea lui k nu este valida");
            }
        }
    }
}
