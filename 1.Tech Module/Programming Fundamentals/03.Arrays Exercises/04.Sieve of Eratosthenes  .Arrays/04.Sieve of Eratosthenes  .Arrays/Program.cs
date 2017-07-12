using System;
using System.Linq;


namespace _04.Sieve_of_Eratosthenes.Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for(int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.Write(i+" ");
                    for (int j = 2; j*i <= n; j++)
                    {
                        primes[i*j] = false;
                    }
                }
            }
        }
    }
}
