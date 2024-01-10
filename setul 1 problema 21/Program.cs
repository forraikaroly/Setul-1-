using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_1_problema_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma " +
                             "'numarul este mai mare sau egal decat x ? '. ");
            int n = new Random().Next(1, 1024);
            int guess = -1;
            while (n != guess)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == n) Console.WriteLine("Numarul este " + n);
                else if (guess < n) Console.WriteLine("Numarul este mai mare");
                else Console.WriteLine("Numarul este mai mic");

            }
            Console.ReadKey();
        }
    }
}
