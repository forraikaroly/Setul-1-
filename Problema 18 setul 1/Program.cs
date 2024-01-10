using System;

namespace Problema_18_setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n. " +
                              "De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.");
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n * 2 + 1]; // Modificarea aici

            for (int i = 0; i < prime.Length; i++)
                prime[i] = true;

            for (int i = 2; i <= n && i * i <= n * 2; i++) // Modificarea aici
                if (prime[i])
                    for (int j = i * 2; j <= n * 2; j += i) // Modificarea aici
                        prime[j] = false;

            bool x = false;
            for (int i = 2; i < prime.Length; i++)
            {
                if (prime[i] && n > 0 && n % i == 0)
                {
                    int y = 0;
                    while (n % i == 0)
                    {
                        y++;
                        n /= i;
                    }
                    if (x)
                    {
                        Console.Write(" x " + i + "^" + y);
                    }
                    else
                    {
                        Console.Write(i + "^" + y);
                        x = true;
                    }
                }
            }
        }
    }
}
