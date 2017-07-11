using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Parse_Tags
{
    class Program
    {
        static void Main()
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";
            var startIndex = inputText.IndexOf(openTag);
            var text = "";
            while (startIndex != -1)
            {
                int endTag = inputText.IndexOf(closeTag);
                if (endTag == -1)
                {
                    break;                    
                }
                var toBeReplaced = inputText.Substring(startIndex, endTag + closeTag.Length - startIndex);
                var replaced = toBeReplaced.Replace(openTag, String.Empty).Replace(closeTag, String.Empty).ToUpper();
                inputText = inputText.Replace(toBeReplaced, replaced);
                startIndex = inputText.IndexOf(openTag);

            }
            Console.WriteLine(inputText);
        }
    }
}
