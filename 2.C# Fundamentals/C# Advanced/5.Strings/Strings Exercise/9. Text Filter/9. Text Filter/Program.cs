using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Text_Filter
{
    class Program
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new char[]{' ', ','},StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            var replaced = input;
            var str = input.Split(new char[] {' ', ',', '.', '!', '?','/' , '\\','(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < bannedWords.Length; j++)
                {
                    if (str[i] == bannedWords[j])
                    {
                        var wordToChange = str[i];
                        var stars = string.Empty;
                        for (int k = 0; k < wordToChange.Length; k++)
                        {
                            stars += '*';
                        }
                        replaced = replaced.Replace(wordToChange, stars);
                    }
                }
            }
           
            Console.WriteLine(replaced);
       }
    }
}
