namespace _6.Find_and_Sum_Int
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            var sum =input.Select(n =>
            {
                long value;
                bool success = long.TryParse(n, out value);
                return new { value, success };
            }).Where(s => s.success).Select(n => n.value).ToList();
            if (sum.Count == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(sum.Sum());
            }
            
        }
    }
}

