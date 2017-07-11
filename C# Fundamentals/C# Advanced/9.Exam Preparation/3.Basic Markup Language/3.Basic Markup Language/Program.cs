namespace _3.Basic_Markup_Language
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\s*(?<withValue><.+\s*value\s*=\s*""(?<value>[0-9]+)""\s*content\s*=\s*""(?<content>.+)""\s*/\s*>\s*)|(?<withoutValue>\s*<.+\s*content\s*=\s*""(?<content>.+)""\s*/\s*>\s*)");
            var counter = 1;
            while (input != "<stop/>")
            {
                var match = regex.Match(input);
                
                var content = match.Groups["content"].Value;
                if (input.Contains("inverse"))
                {
                    var sb = new StringBuilder();
                    foreach (var symbol in content)
                    {
                        if (char.IsLower(symbol))
                        {
                            sb.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            sb.Append(symbol.ToString().ToLower());
                        }
                    }
                    Console.WriteLine($"{counter}. {sb}");
                    counter++;
                }
                else if (input.Contains("reverse"))
                {
                    content = Reverse(content);
                    Console.WriteLine($"{counter}. {content}");
                    counter++;
                }
                else if (input.Contains("repeat"))
                {
                    if (match.Groups["value"].Success)
                    {
                        int value = int.Parse(match.Groups["value"].Value);
                        for (int i = 0; i < value; i++)
                        {
                            Console.WriteLine($"{counter}. {content}");
                            counter++;
                        }                        
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. {content}");
                        counter++;
                    }
                }
                input = Console.ReadLine();
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
