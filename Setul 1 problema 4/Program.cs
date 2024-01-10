using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect.
            int x;
            Console.Write("Itroduceti anul:");
            x = int.Parse(Console.ReadLine());
            if (x % 4 == 0)
            {
                Console.WriteLine($"Anul {x} este bisect");
            }
            else
            {
                Console.WriteLine("Nu este bisect");
            }


        }
    }
}
