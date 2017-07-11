namespace _3.Text_Transformer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main()
        {            
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            while (input!="burp")
            {                
                sb.Append(input);
                input = Console.ReadLine();                
            }
            var sb2 = Regex.Replace(sb.ToString(), @"\s+", " ");
            var translated = new StringBuilder();
            var regex = new Regex(@"'(?<weight4>\w+)'|&(?<weight3>\w+)&|%(?<weight2>\w+)%|\$(?<weight1>\w+)\$");
            var matches = regex.Matches(sb2);
            foreach (Match match in matches)
            {
                if (match.Groups["weight4"].Success)
                {
                    translated.Append(TranslatingDrunkText(match.Groups["weight4"].Value, 4));
                }
                if (match.Groups["weight3"].Success)
                {
                    translated.Append(TranslatingDrunkText(match.Groups["weight3"].Value, 3));
                }
                if (match.Groups["weight2"].Success)
                {
                    translated.Append(TranslatingDrunkText(match.Groups["weight2"].Value, 2));
                }
                if (match.Groups["weight1"].Success)
                {
                    translated.Append(TranslatingDrunkText(match.Groups["weight1"].Value, 1));
                }
            }
            Console.WriteLine(translated.ToString());
        }
        private static string TranslatingDrunkText(string text, int weight)
        {
            var charArr = text.ToCharArray();
            var sb = new StringBuilder();
            for (int j = 0; j < charArr.Length; j++)
            {
                if (j % 2 == 0)
                {
                    var newChar = (char)((int)charArr[j] + weight);
                    sb.Append(newChar);
                }
                else
                {
                    var newChar = (char)((int)charArr[j] - weight);
                    sb.Append(newChar);
                }
            }
            sb.Append(' ');
            return sb.ToString();
        }
    }
}
