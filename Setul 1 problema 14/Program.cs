using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Determianti daca un numar n este palindrom. 
            //un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int nIntors = 0;

            while (nCopy > 0)
            {
                nIntors = nIntors * 10 + nCopy % 10;
                nCopy /= 10;
            }
            if (n == nIntors)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }

        }
    }
}
