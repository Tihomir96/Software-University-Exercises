namespace _1.Match_Count
{
    using System;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            int count = regex.Matches(text).Count;

            Console.WriteLine(count);
        }
    }
}
