using System;

namespace _1.MathOperations
{
    public class Program
    {
        public static void Main()
        {
            var MathOperation = new MathOperations();
            Console.WriteLine(MathOperation.Add(2, 3));
            Console.WriteLine(MathOperation.Add(2.2, 3.3, 5.5));
            Console.WriteLine(MathOperation.Add(2.2m, 3.3m, 4.4m));

        }
    }
}
