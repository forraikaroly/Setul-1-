﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)"
            Console.Write("Introduceti primul numar: ");
            int numar1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            int numar3 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al patrulea numar: ");
            int numar4 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al cincilea numar: ");
            int numar5 = int.Parse(Console.ReadLine());

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

            if (numar3 > numar4)
            {
                int temp = numar3;
                numar3 = numar4;
                numar4 = temp;
            }

            if (numar4 > numar5)
            {
                int temp = numar4;
                numar4 = numar5;
                numar5 = temp;
            }

            // Repetăm pasul anterior pentru a asigura ordinea corectă
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

            if (numar3 > numar4)
            {
                int temp = numar3;
                numar3 = numar4;
                numar4 = temp;
            }

            // Afișarea numerelor în ordine crescătoare
            Console.WriteLine($"Numerele în ordine crescătoare: {numar1}, {numar2}, {numar3}, {numar4}, {numar5}");
        }

    }
}

