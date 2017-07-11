using System.Text.RegularExpressions;
using System;

namespace _3.Non_Digit_Count
{    
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\D";
            var regex = new Regex(pattern);
            var count = regex.Matches(text).Count;
            Console.WriteLine($"Non-digits: {count}");

        }
    }
}
