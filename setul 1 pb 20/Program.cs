using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_1_pb_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). " +
                  "Exemplu: 13/30 = 0.4(3).");
            string[] t = Console.ReadLine().Split(' ');
            int numarator = int.Parse(t[0]);
            int numitor = int.Parse(t[1]);


            List<int> listaCaturi = new List<int>();
            List<int> listaResturi = new List<int>();

            int rest = numarator % numitor;
            listaResturi.Add(rest);

            bool periodica = false;
            do
            {
                listaCaturi.Add(rest * 10 / numitor);
                rest = rest * 10 % numitor;

                if (!listaResturi.Contains(rest)) listaResturi.Add(rest);
                else periodica = true;
            } while (rest != 0 && periodica == false);

            String numarFinal = (numarator / numitor) + ".";

            if (!periodica)
                foreach (int i in listaCaturi)
                    numarFinal += i;
            else
            {
                for (int i = 0; i < listaCaturi.Count; i++)
                {
                    if (listaResturi[i] == rest) numarFinal += "(";
                    numarFinal += listaCaturi[i];
                }

                numarFinal += ")";
            }

            Console.WriteLine(numarFinal);
            Console.ReadKey();

        }
    }
}
