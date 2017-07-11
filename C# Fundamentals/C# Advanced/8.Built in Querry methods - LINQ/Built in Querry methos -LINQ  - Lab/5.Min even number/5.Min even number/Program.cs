namespace _5.Min_even_number
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var min = Console.ReadLine().Split().Select(double.Parse).Where(x => x % 2 == 0).ToList();
            if (min.Count != 0)
            {
                Console.WriteLine($"{min.Min():f2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
