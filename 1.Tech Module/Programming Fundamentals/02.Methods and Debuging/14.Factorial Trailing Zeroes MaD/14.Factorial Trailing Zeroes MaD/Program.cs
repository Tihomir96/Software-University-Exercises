using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes_MaD
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(num);
            int zeroes = 0;
            BigInteger digit = factorial % 10;
            while (digit == 0)
            {
                zeroes++;
                factorial = factorial / 10;
                digit = factorial % 10;
            }
            Console.WriteLine(zeroes);
            
        }
        public static BigInteger Factorial(BigInteger n)
        {

            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum = i * sum;


            }
            return sum;
        }
    }
}
