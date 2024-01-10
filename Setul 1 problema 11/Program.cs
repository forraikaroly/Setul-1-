using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n. ");
            int nr = int.Parse(Console.ReadLine());
            int semn = 1;
            nr = Math.Abs(nr);

            int nrIntors = 0;
            while (nr > 0)
            {
                nrIntors = nrIntors * 10 + nr % 10;
                nr /= 10;
            }
            Console.WriteLine(semn * nrIntors);
        }
    }
}
