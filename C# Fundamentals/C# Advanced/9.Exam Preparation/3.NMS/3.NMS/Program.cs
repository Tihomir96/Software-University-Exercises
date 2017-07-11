using System.Linq;

namespace _3.NMS
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            while (input != "---NMS SEND---")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }
            var words = new List<string>();
            var word = new StringBuilder();

            word.Append(sb.ToString()[0]);
            for (int i = 1; i < sb.Length; i++)
            {
                int currChar;
                int nextChar;
                if (char.IsUpper(sb[i - 1]))
                {
                    currChar = sb[i - 1] + 32;
                }
                else
                {
                    currChar = sb[i - 1];
                }
                if (char.IsUpper(sb[i]))
                {
                    nextChar = sb[i] + 32;
                }
                else
                {
                    nextChar = sb[i];
                }
                if (currChar <= nextChar)
                {
                    word.Append(sb[i]);
                }
                else
                {
                    words.Add(word.ToString());
                    word.Clear();
                    word.Append(sb[i]);
                }
            }
            words.Add(word.ToString());
            word.Clear();
            var delimeter = Console.ReadLine();
            Console.WriteLine(string.Join(delimeter, words.Where(x => x != "").ToList()));
        }
        }
    }

