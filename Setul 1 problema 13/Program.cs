
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_problema_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2"
            int y1, y2, nr = 0;
            Console.WriteLine("Inreoduceti anii");
            y1=int.Parse(Console.ReadLine());
            y2=int.Parse(Console.ReadLine());
            for(int i=y1-1; i<y2; i++) 
            {
                if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0)) nr++;
            }
                Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");
        }
    }
}
