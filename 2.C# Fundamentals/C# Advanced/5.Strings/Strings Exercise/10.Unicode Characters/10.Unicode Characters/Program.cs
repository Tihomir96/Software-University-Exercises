namespace _10.Unicode_Characters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            foreach (var letter in input)
            {
                Console.Write($"\\u{(int)letter:x4}");

            }
            Console.WriteLine();

        }
    }
}
