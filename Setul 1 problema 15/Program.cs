using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Se dau 3 numere. Sa se afiseze in ordine crescatoare
        Console.Write("Introduceti primul numar: ");
            int numar1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            int numar3 = int.Parse(Console.ReadLine());

            // Sortarea numerelor în ordine crescătoare
            if (numar1 > numar2)
            {
                int temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            if (numar2 > numar3)
            {
                int temp = numar2;
                numar2 = numar3;
                numar3 = temp;
            }

            if (numar1 > numar2)
            {
                int temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            Console.WriteLine($"Numerele in ordine crescatoare: {numar1}, {numar2}, {numar3}");
        }
    }
}
    

