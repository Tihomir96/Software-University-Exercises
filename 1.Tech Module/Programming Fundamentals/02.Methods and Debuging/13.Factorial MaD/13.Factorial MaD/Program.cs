using System;
using System.Numerics;

namespace _13.Factorial_MaD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));

        }
        public static BigInteger Factorial(BigInteger n)
        {

            BigInteger sum = 1;
            for (int i = 1; i <=n; i++)
            {
                sum = i*sum;


            }
            return sum;
        }
    }
}
