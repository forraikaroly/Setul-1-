using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_1_pb_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. " +
    "De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            string n = Console.ReadLine();
            string t = "";
            for (int i = 0; i < n.Length; i++)
                if (!t.Contains(n[i]))
                    t += n[i];
            if (t.Length > 2)
                Console.WriteLine("Numarul este format din mai mult 2 cifre");
            else
                Console.WriteLine("Numarul este format din cel mult 2 cifre");
            Console.ReadKey();


        }
    }
}
