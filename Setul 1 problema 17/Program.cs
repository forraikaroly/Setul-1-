using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a, y = b;
            while (x != 0)
            {
                int r = y % x;
                y = x;
                x = r;
            }
            Console.WriteLine("Cel mai mare divizor comun este" + " " + y);
            Console.WriteLine("Cel mai mic multiplu comun este" + " " + (a * b) / y);

        }
    }
}
