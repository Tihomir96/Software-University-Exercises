namespace _2.Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"[AEIOUYaeiouy]";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text).Count;
            Console.WriteLine($"Vowels: {matches}");
        }
    }
}
