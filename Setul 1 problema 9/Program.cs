using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n.
            int n;
            Console.Write("n= ");
            n=int.Parse(Console.ReadLine());    
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine($"divizorii lui n sunt {i} ");
                }
            }
        }
    }
}
