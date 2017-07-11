namespace _7.Bounded_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Select(int.Parse).Where(x => bounds.Min() <= x && x <= bounds.Max()).ToList()));

        }
    }
}
